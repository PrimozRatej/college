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
    public partial class buttonDodajKomitenta : Form
    {
        WebServiceMoj servis;
        public buttonDodajKomitenta()
        {
            servis = new WebServiceMoj();
            InitializeComponent();
            monthCalendarDatumRoj.MaxSelectionCount = 1;
        }

        private void buttonShrani_Click(object sender, EventArgs e)
        {
            string ime = textBoxIme.Text;
            string priimek = textBoxPriimek.Text;
            string Davčna = textBoxEMŠO.Text;
            DateTime datumRoj = monthCalendarDatumRoj.SelectionStart;

            Komitent kom = servis.komitent(Davčna);
            if (kom != null)
                MessageBox.Show("Komitent z takšno davčno številko je že v sistemu");
            else
            {
                Komitent novKom = new Komitent() { Ime = ime, Priimek = priimek, DavcnaStevilka = Davčna, DatumRojstva = datumRoj };
                servis.KomitentShrani(novKom);
                this.Close();
            }
            
            
        }

       
    }
}
