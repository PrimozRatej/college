using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AHP
{
    public partial class AHPOkno : Form
    {
        public List<string> NaziviAlternativ { get; set; }

        public IEnumerable<Vozlisce> SestavljenaVozlisca { get; set; }
        public List<DataGridView> GridiSestavljenih { get; set; } = new List<DataGridView>();
        public List<int> StevciStolpcevSestavljenih { get; set; } = new List<int>();

        public IEnumerable<Vozlisce> OsnovnaVozlisca { get; set; }
        public List<DataGridView> GridiOsnovnih { get; set; } = new List<DataGridView>();
        public List<int> StevciStolpcevOsnovnih { get; set; } = new List<int>();

        public int StevecRezultatov { get; set; }

        public AHPOkno(){
            InitializeComponent();
            hierarhija.Nodes.Add(new Vozlisce("Ocena"));
            flowGridi.AutoScroll = false;
            flowGridi.HorizontalScroll.Maximum = 0;
            flowGridi.VerticalScroll.Visible = false;
            flowGridi.AutoScroll = true;
        }

        public AHPOkno(Model m)
        {
            InitializeComponent();
            flowGridi.AutoScroll = false;
            flowGridi.HorizontalScroll.Maximum = 0;
            flowGridi.VerticalScroll.Visible = false;
            flowGridi.AutoScroll = true;

            foreach (string a in m.NaziviAlternativ) {
                dgAlternative.Rows.Add(a);
            }
            btnShrani_Click(null, null);
            hierarhija.Nodes.Add(m.Koren);
            hierarhija.ExpandAll();
            btnGrid_Click(null, null);
        }

        #region Dogodki
        private void AHPOkno_Load(object sender, EventArgs e)
        {
            if (GridiOsnovnih != null && GridiSestavljenih != null)
                GridiOsnovnih.Concat(GridiSestavljenih).ForEach(g => g.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders));
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {
            var alternative = new List<string>();
            foreach (DataGridViewRow row in dgAlternative.Rows)
            {
                if (row.IsNewRow) continue;

                var naziv = row.Cells["NazivAlternative"].Value as string;
                if (string.IsNullOrWhiteSpace(naziv))
                {
                    MessageBox.Show("Vsaka alternativa mora imeti naziv!");
                    return;
                }
                alternative.Add(naziv);
            }

            if (alternative.Count < 2)
            {
                MessageBox.Show("Vnesite vsaj 2 alternativi!");
                return;
            }

            NaziviAlternativ = alternative;
            dgAlternative.ReadOnly = true;
            dgAlternative.AllowUserToAddRows = false;
            btnShrani.Enabled = false;
            panelHierarhija.Enabled = true;
            btnGrid.Enabled = true;
        }

        private void dodajParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var okno = new DodajParameter();
            okno.ShowDialog();
            var v = new Vozlisce(okno.Naziv);
            hierarhija.SelectedNode.Nodes.Add(v);
            hierarhija.SelectedNode.ExpandAll();
        }

        private void odstraniParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hierarhija.SelectedNode.Parent != null)
                hierarhija.SelectedNode.Remove();
            else
                MessageBox.Show("Odstranjevanje korena ni dovoljeno!");
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            SestavljenaVozlisca = hierarhija.Nodes.CollectReverse().Where(x => x.Nodes.Count > 0).Cast<Vozlisce>();
            OsnovnaVozlisca = hierarhija.Nodes.CollectReverse().Where(x => x.Nodes.Count == 0).Cast<Vozlisce>();

            foreach (TreeNode voz in SestavljenaVozlisca)
            {
                var lbl = new Label
                {
                    AutoSize = true,
                    Text = $"Uteži za sestavljen parameter {voz.Text}:"
                };
                flowGridi.Controls.Add(lbl);
                DataGridView dgv = GenerirajGrid(voz);
                StevciStolpcevSestavljenih.Add(dgv.Columns.Count);
                GridiSestavljenih.Add(dgv);
            }

            flowGridi.Controls.Add(
                new Label
                {
                    AutoSize = true,
                    Text = "\n\n\n--- Osnovni parametri ---\n",
                    Font = new Font(Font, FontStyle.Bold)
                });

            foreach (TreeNode voz in OsnovnaVozlisca)
            {
                var lbl = new Label
                {
                    AutoSize = true,
                    Text = $"Koristnost za osnovni parameter {voz.Text}:"
                };
                flowGridi.Controls.Add(lbl);
                DataGridView dgv = GenerirajGrid(voz);
                StevciStolpcevOsnovnih.Add(dgv.Columns.Count);
                GridiOsnovnih.Add(dgv);
            }

            btnGrid.Enabled = false;
            panelHierarhija.ContextMenuStrip.Enabled = false;
            btnOvrednoti.Enabled = true;
            btnNaDisk.Enabled = true;
        }

        private void btnNaDisk_Click(object sender, EventArgs e)
        {
            var model = new Model()
            {
                NaziviAlternativ = new List<string>(NaziviAlternativ),
                Koren = SestavljenaVozlisca.Count() > 0 ? SestavljenaVozlisca.ElementAt(SestavljenaVozlisca.Count() - 1) : OsnovnaVozlisca.ElementAt(0) 
            };
            var sfd = new SaveFileDialog
            {
                Title = "Izberite ime datoteke za shranjevanje modela",
                FileName = "model.dat",
                Filter = "Datoteke modela (*.dat)|*.dat",
                DefaultExt = "dat"
            };
            if (DialogResult.OK != sfd.ShowDialog())
                return;

            using (FileStream stream = File.Create(sfd.FileName))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, model);
            }
            MessageBox.Show("Datoteka shranjena!");
        }

        private void btnOvrednoti_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridiSestavljenih.Count; i++)
            {
                if (!OvrednotiGrid(GridiSestavljenih[i], StevciStolpcevSestavljenih[i], "Utež"))
                {
                    MessageBox.Show("Izpolnite vsa polja pri tabelah sestavljenih parametrov!");
                    return;
                }
            }
            for (int i = 0; i < GridiOsnovnih.Count; i++)
            {
                if (!OvrednotiGrid(GridiOsnovnih[i], StevciStolpcevOsnovnih[i], "Koristnost"))
                {
                    MessageBox.Show("Izpolnite vsa polja pri tabelah osnovnih parametrov!");
                    return;
                }
            }

            ZberiVrednosti();
            OvrednotiDrevo();
            PrikaziRezultate();
        }

        private void tabela_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (sender == null) return;
            string niz = (e.FormattedValue as string);
            if (string.IsNullOrEmpty(niz)) return;
            if (!double.TryParse(niz, out double st))
            {
                MessageBox.Show("Vnesite realno število!");
                prekini();
            }
            else if (st <= 0 || st > 9) {
                MessageBox.Show("Uporabite števila od 1 do 9 in njihovo obratno vrednost!");
                prekini();
            }

            void prekini()
            {
                dgv.CurrentCell.Value = null;
                dgv.CancelEdit();
                e.Cancel = true;
            };
        }

        private void flowGridi_SizeChanged(object sender, EventArgs e)
        {
            flowGridi.SuspendLayout();
            foreach (Control ctrl in flowGridi.Controls)
            {
                if (ctrl is DataGridView) ctrl.Width = flowGridi.ClientSize.Width - 20;
            }
            flowGridi.ResumeLayout();
        }
        
        private void AHPOkno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private DataGridViewRow DodajVrstico(DataGridView grid, string glava)
        {
            grid.Rows.Add();
            var vrstica = grid.Rows.Cast<DataGridViewRow>().Last();
            for (int i = 0; i < vrstica.Cells.Count; i++)
            {
                DataGridViewCell celica = vrstica.Cells[i];
                celica.Style.Format = "N2";
                celica.ValueType = typeof(double);
                celica.ReadOnly = true;
                celica.Style.BackColor = Color.LightGray;
            }

            //po diagonali nastavimo na 1
            DataGridViewCell lastCell = vrstica.Cells.Cast<DataGridViewCell>().Last();
            lastCell.Value = 1.0;

            vrstica.HeaderCell = new DataGridViewRowHeaderCell
            {
                Value = glava
            };
            return vrstica;
        }

        private DataGridView GenerirajGrid(TreeNode vozlisce)
        {
            var dgv = new DataGridView()
            {
                AllowUserToAddRows = false,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            };
            dgv.CellValidating += tabela_CellValidating;

            if (vozlisce.Nodes.Count > 0)
            {
                foreach (TreeNode otrok in vozlisce.Nodes)
                {
                    dgv.Columns.Add(otrok.Text, otrok.Text);
                    DodajVrstico(dgv, otrok.Text);
                }
            }
            else
            {
                foreach (string alternativa in NaziviAlternativ)
                {
                    dgv.Columns.Add(alternativa, alternativa);
                    DodajVrstico(dgv, alternativa);
                }
            }

            flowGridi.Controls.Add(dgv);
            dgv.Columns.Cast<DataGridViewColumn>().ForEach(x => x.SortMode = DataGridViewColumnSortMode.NotSortable);
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            return dgv;
        }

        /// <summary>
        /// Ovrednoti posamezne primerjave vnešene v grid
        /// </summary>
        /// <param name="dg">grid</param>
        /// <param name="stevecStolpcev">dejansko število stolpcev grida</param>
        /// <param name="imeZadnjega">tekst prikazan za povprečni stolpec</param>
        /// <returns></returns>
        private bool OvrednotiGrid(DataGridView dg, int stevecStolpcev, string imeZadnjega)
        {
            var obdelaniStolpci = new List<List<double>>();
            for (int stolpec = 0; stolpec < stevecStolpcev; stolpec++)
            {
                var vrednosti = new List<double>();

                //zapolni prvi del tabele
                for (int vrstica = 0; vrstica < dg.Rows.Count; vrstica++)
                {
                    DataGridViewCell celica = dg[stolpec, vrstica];
                    double vrednost;
                    string vnosCelica = celica.Value?.ToString();
                    if (celica.ReadOnly)
                    {
                        string prezrcaljena = dg[vrstica, stolpec].Value?.ToString();
                        if (string.IsNullOrEmpty(prezrcaljena))
                            return false;
                        double cellAcross = double.Parse(prezrcaljena);
                        vrednost = 1.0 / cellAcross;
                        dg[stolpec, vrstica].Value = Math.Round(vrednost, 2);
                    }
                    else
                        vrednost = double.Parse(vnosCelica);
                    vrednosti.Add(vrednost);
                }

                //dodaj normaliziran stolpec
                string obdelana = dg.Columns[stolpec].HeaderText + "*";
                if (!dg.Columns.Contains(obdelana))
                    dg.Columns.Add(obdelana, obdelana);
                int zadnjiStolpec = dg.Columns[obdelana].Index;
                double vsota = vrednosti.Sum();
                var obdelaniStolpec = new List<double>();
                for (int vrstica = 0; vrstica < vrednosti.Count; vrstica++)
                {
                    DataGridViewCell celica = dg[zadnjiStolpec, vrstica];
                    double v = vrednosti[vrstica] / vsota;
                    celica.Value = v;
                    obdelaniStolpec.Add(v);
                    celica.Style.Format = "N2";
                    celica.Style.BackColor = Color.LightGray;
                    celica.ReadOnly = true;
                }
                obdelaniStolpci.Add(obdelaniStolpec);
            }

            //dodaj povprečje
            obdelaniStolpci = obdelaniStolpci.Transpose();
            if (!dg.Columns.Contains(imeZadnjega))
                dg.Columns.Add(imeZadnjega, imeZadnjega);
            int i = 0;
            int dodanStolpec = dg.Columns[imeZadnjega].Index;
            foreach (List<double> vrstica in obdelaniStolpci)
            {
                double vrednost = vrstica.Average();
                DataGridViewCell celica = dg[dodanStolpec, i];
                celica.Value = vrednost;
                celica.Style.Format = "N2";
                celica.Style.BackColor = Color.LightGray;
                celica.ReadOnly = true;
                i++;
            }
            dg.Columns.Cast<DataGridViewColumn>().ForEach(x => x.SortMode = DataGridViewColumnSortMode.NotSortable);
            return true;
        }

        /// <summary>
        /// Zbere vrednosti iz vseh gridov v drevo
        /// </summary>
        private void ZberiVrednosti()
        {
            for (int i = 0; i < SestavljenaVozlisca.Count(); i++)
            {
                DataGridView grid = GridiSestavljenih[i];
                Vozlisce v = SestavljenaVozlisca.ElementAt(i);
                v.ImaOtroke = true;
                v.Uteži = grid.Rows
                             .OfType<DataGridViewRow>()
                             .Select(r => r.Cells[r.Cells.Count - 1].Value.ToString())
                             .Select(r => double.Parse(r))
                             .ToList();
            }

            for (int i = 0; i < OsnovnaVozlisca.Count(); i++)
            {
                DataGridView grid = GridiOsnovnih[i];
                Vozlisce v = OsnovnaVozlisca.ElementAt(i);
                v.ImaOtroke = false;
                v.Koristnosti = grid.Rows
                             .OfType<DataGridViewRow>()
                             .Select(r => r.Cells[r.Cells.Count - 1].Value.ToString())
                             .Select(r => double.Parse(r))
                             .ToList();
            }
        }

        /// <summary>
        /// Na podlagi drevesa zgradi oceno alternativ
        /// </summary>
        private void OvrednotiDrevo()
        {
            foreach (var stars in SestavljenaVozlisca)
            {
                stars.Ocene = new List<double>();
                for (int i = 0; i < NaziviAlternativ.Count; i++)
                {
                    double rezultat = 0;
                    int indexOtroka = 0;
                    foreach (Vozlisce otrok in stars.Nodes.Cast<Vozlisce>())
                    {
                        double utezParametra = stars.Uteži[indexOtroka];
                        double koristnost;
                        if (otrok.ImaOtroke)
                            koristnost = otrok.Ocene[i];
                        else
                            koristnost = otrok.Koristnosti[i];
                        double zmnozek = utezParametra * koristnost;
                        rezultat += zmnozek;
                        otrok.IndeksOtroka = indexOtroka++;
                    }
                    rezultat = Math.Round(rezultat, 2);
                    stars.Ocene.Add(rezultat);
                }
            }
        }

        private void PrikaziRezultate()
        {
            //generiraj slovar izhodov
            var slovar = new Dictionary<string, List<double>>();
            foreach (Vozlisce vozlisce in hierarhija.Nodes.Collect())
            {
                string ime = vozlisce.Text.Insert(0, string.Join("", Enumerable.Repeat("--", vozlisce.Level)));
                List<double> vrednosti;
                if (vozlisce.ImaOtroke)
                    vrednosti = vozlisce.Ocene;
                else
                    vrednosti = vozlisce.Koristnosti;
                if (vozlisce.Parent != null) {
                    var starts = vozlisce.Parent as Vozlisce;
                    vrednosti.Add(starts.Uteži[vozlisce.IndeksOtroka]);
                }
                slovar.Add(ime, vrednosti);
            }

            //generiranje grida
            var dgv = new DataGridView {
                AllowUserToAddRows = false,
                ReadOnly = true,
                ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            };
            NaziviAlternativ.ForEach(x => dgv.Columns.Add(x, x));
            dgv.Columns.Add("Utež", "Utež");
            foreach (var par in slovar)
            {
                dgv.Rows.Add();
                var vrsta = dgv.Rows[dgv.Rows.Count - 1];
                vrsta.HeaderCell = new DataGridViewRowHeaderCell
                {
                    Value = par.Key,
                };
                
                int i = 0;
                par.Value.ForEach(x => {
                    var celica = vrsta.Cells[i++];
                    celica.Value = x;
                    celica.Style.Format = "N2";
                });
            }

            //prikaz grida
            flowGridi.Controls.Add(new Label
            {
                Text = $"\n\nRezultati #{++StevecRezultatov}\n",
                AutoSize = true,
                Font = new Font(Font, FontStyle.Bold)
            });
            flowGridi.Controls.Add(dgv);

            //dodatni gumbi
            var panel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight
            };
            var gumbExcel = new Button
            {
                Text = "Pošlji v Excel",
                AutoSize = true,
            };
            gumbExcel.Click += (sender, e) =>
            {
                dgv.OpenInExcel();
            };
            var gumbGraf = new Button
            {
                Text = "Graf",
                AutoSize = true,
            };
            gumbGraf.Click += (sender, e) =>
            {
                DialogResult odgv = MessageBox.Show("Ali želite graf shraniti v datoteko?", "Shranjevanje grafa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (odgv == DialogResult.Cancel)
                    return;

                Chart graf = NarediGraf(slovar);
                if (odgv == DialogResult.Yes) {
                    var sfd = new SaveFileDialog
                    {
                        Title = "Izberite pot za shranjevanje slike grafa",
                        DefaultExt = "png", 
                        Filter = "PNG slika (*.png)|*.png",
                        FileName = "graf.png"
                    };
                    if (DialogResult.OK != sfd.ShowDialog())
                        return;
                    graf.SaveImage(sfd.FileName, ChartImageFormat.Png);
                    MessageBox.Show($"Graf shranjen v {sfd.FileName}!");
                }
                PrikaziGraf(graf);
            };
            panel.Controls.AddRange(new[] { gumbGraf, gumbExcel });
            flowGridi.Controls.Add(panel);
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgv.Columns.Cast<DataGridViewColumn>().ForEach(x => x.SortMode = DataGridViewColumnSortMode.NotSortable);
            flowGridi_SizeChanged(flowGridi, null);
        }

        Chart NarediGraf(Dictionary<string, List<double>> rezultati) {
            var chart = new Chart { Dock = DockStyle.Fill, BorderlineColor = Color.Black, BorderlineWidth = 1, Size = new Size(800, 500) };
            var area = new ChartArea("Main");
            area.AxisY.Title = "ocena alternative";
            area.AxisX.Title = "naziv alternative";
            area.AxisX.MajorGrid.LineWidth = 0;
            area.AxisY.Minimum = 0;
            area.AxisY.Interval = 0.1;
            area.AxisY.Maximum = 1;
            chart.ChartAreas.Add(area);
            chart.Legends.Add(new Legend("Legenda")
            {
                Title = "Legenda",
                Docking = Docking.Right,
                Alignment = StringAlignment.Center,
                BorderColor = Color.Black,
                BorderWidth = 1
            });

            var seriesColumns = new Series("alternative");
            seriesColumns.IsValueShownAsLabel = true;
            seriesColumns.LabelBackColor = Color.White;
            chart.Series.Add(seriesColumns);

            for (int i = 0; i < NaziviAlternativ.Count; i++)
            {
                var dp = new DataPoint(seriesColumns)
                {
                    YValues = new double[] { rezultati["Ocena"][i] }
                };
                dp.AxisLabel = NaziviAlternativ[i];
                seriesColumns.Points.Add(dp);
            }
            chart.Titles.Add(new Title("Primerjava alternativ", Docking.Top, new Font("Verdana", 14.0f), Color.Black));
            return chart;
        }

        void PrikaziGraf(Chart chart) {
            var mainForm = new Form
            {
                Visible = false,
                TopMost = true,
                Width = 800,
                Height = 500
            };
            mainForm.Controls.Add(chart);
            mainForm.ShowDialog();
        }
    }
}
