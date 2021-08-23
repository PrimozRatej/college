using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.servis;

namespace GUI
{
    public partial class DodajTransakcijo : Form
    {
        WebServiceMoj servis;
        static string davcna;
        static Komitent kom;
        static Račun rač;
        public DodajTransakcijo()
        {
            
            servis = new WebServiceMoj();
            InitializeComponent();
            dataGridViewIšči.DataSource = servis.SeznamKomitentov();
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void ButtonIšči_Click(object sender, EventArgs e)
        {
            davcna = textBoxIšči.Text;
            List<Račun> listRač = servis.RačuniKomitenta(davcna).ToList();
            dataGridViewIšči.DataSource = listRač;
            
        }

        private void dataGridViewIšči_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewIšči.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewIšči.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewIšči.Rows[selectedrowindex];

                //int a = int.Parse(selectedRow.Cells["RačunId"].Value);
                int a = 0;
                kom = servis.komitent(davcna);
                rač = servis.RačunPridobi(kom, a);
                labelObvestila.Text = ("Izbran je račun komitenta "+kom.Ime+" "+kom.Priimek+" z IDjem"+a);
            }
        }

        private void buttonVstavi_Click(object sender, EventArgs e)
        {
            Transakcija tra = new Transakcija();
            int value;
            if (int.TryParse(textBoxZnesek.Text, out value))
            {
                tra.datumTransakcije = monthCalendar1.SelectionStart;
                tra.znesek = value;
            }
            else
            {
                MessageBox.Show("Vstavite pravilenznesek");
                return;
            }
            if(rač != null)
            {
                tra.račun = rač;
                servis.TransakcijaShrani(tra);
                
            }
            else
            {
                MessageBox.Show("Napaka pri nalaganju na račun");
                return;
            }
            MessageBox.Show("Transakcija je bila uspešno dodana na račun");
            this.Close();
        }
    }
}
