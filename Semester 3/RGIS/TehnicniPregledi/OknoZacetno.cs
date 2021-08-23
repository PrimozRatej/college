using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OknoZacetno : Form
    {
        List<Vozilo> seznamVozil;
        VoziloControl vozControl;
        List<Vozilo> seznamKritičnihVozil;
        OpravilaControl opraControl;
        int index = 0;
        public OknoZacetno()
        {
            vozControl = new VoziloControl();
            opraControl = new OpravilaControl();
            InitializeComponent();
            WindowsFormsApplication1.BAZA.NaložiOpravila();
            WindowsFormsApplication1.BAZA.NaložiVozila();
            WindowsFormsApplication1.BAZA.NaložiTehničnePreglede();
           
            seznamVozil = vozControl.GetSeznamVozil().ToList();
            if(seznamVozil.Count == 0)
            {
                IzpisObvestila();
                return;
            }
            seznamVozil = vozControl.SortirajSeznamVozil().ToList();

            listBox.DataSource = vozControl.VoziloIzpis(seznamVozil.ToArray()).ToList();
            seznamKritičnihVozil = vozControl.SeznamKritiènihVozil(seznamVozil.ToArray()).ToList();
            foreach (var vozilo in seznamKritičnihVozil)
            {
                listBoxKritičnaVozila.Items.Add(vozilo.Izpis());
                foreach (var opravila in opraControl.SeznamKritiènihOpravil(vozilo))
                {
                    listBoxKritičnaVozila.Items.Add("-"+opravila.Izpis());
                }
            }           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void IzpisObvestila()
        {
            MessageBox.Show("Obvestilo");
        }
        
        public bool Nalozi()
        {
            throw new System.Exception("Not implemented");
        }
        public bool Osvezi()
        {
            Nalozi();
            return true;
        }
        public void IzpisVozila(string nizVozila)
        {
            throw new System.Exception("Not implemented");
        }


        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Tehnični pregledi");
            cm.MenuItems.Add("Opravila");
            cm.MenuItems[0].Click += new System.EventHandler(this.menuItem1_Click);
            cm.MenuItems[1].Click += new System.EventHandler(this.menuItem2_Click);

            listBox.ContextMenu = cm;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Vozilo voz = new Vozilo().IzlušèiVozilo(listBox.Items[index].ToString());
                EvidencaControl contr = new EvidencaControl(voz);
                contr.IzpisEvidence();

            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Vozilo voz = new Vozilo().IzlušèiVozilo(listBox.Items[index].ToString());
                TehnicniPreglediControl tehControl = new TehnicniPreglediControl();
                TehnicniPregledi[] tehPreglediVozila = tehControl.vrniTehniènePreglede(voz);
                tehControl.IzpisTehniènihPregledov(tehPreglediVozila.ToList());

            }
        }

        private void buttonVnosPodatkov_Click(object sender, EventArgs e)
        {
            VnosPodatkovOvozilihOkno okno = new VnosPodatkovOvozilihOkno();
            okno.Show();
            
        }




        //private AžurirajOkno ažurirajPodatke;
        //private SpremeniOpavilaOkno spreminjanjeOpravil;
        //private PregledPodatkov_oVozilihOkno pregledPodatkovVozila;

    }
}
