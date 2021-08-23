using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRetsaurant
{
    public partial class ProfilRestavracije : Form
    {
        public ProfilRestavracije()
        {
            InitializeComponent();
            if (Prijava.ime == null)
            {
                Dostava_button.Visible = false;
                Rezervacija_button.Visible = false;
            }
            else
            {
                Dostava_button.Visible = true;
                Rezervacija_button.Visible = true;
            }
        }

        private void MENI_Button_Click(object sender, EventArgs e)
        {
            MENI mn = new MENI();
            mn.Show();
            this.Close();
        }

        private void Rezervacija_button_Click(object sender, EventArgs e)
        {
            RezervacijaMize rm = new RezervacijaMize();
            rm.Show();
            this.Close();
        }

        private void NAZAJ_Button_Click(object sender, EventArgs e)
        {
            Zemljevid zm = new Zemljevid();
            zm.Show();
            this.Close();
        }

        private void Dostava_button_Click(object sender, EventArgs e)
        {
            Dostava ds = new Dostava();
            ds.Show();
            this.Close();
        }
    }
}
