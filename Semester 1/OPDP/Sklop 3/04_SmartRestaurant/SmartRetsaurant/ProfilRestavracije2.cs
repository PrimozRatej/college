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
    public partial class ProfilRestavracije2 : Form
    {
        public ProfilRestavracije2()
        {
            InitializeComponent();
            if(Prijava.ime == null)
            {
                Rezervacija_button.Visible = false;
                Dostava_button.Visible = false;
            }
        }

        private void NAZAJ_Button_Click(object sender, EventArgs e)
        {
            SeznamRestavracij sz = new SeznamRestavracij();
            sz.Show();
            this.Close();
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

        private void Dostava_button_Click(object sender, EventArgs e)
        {
            Dostava ds = new Dostava();
            ds.Show();
            this.Close();

        }

        private void ProfilRestavracije2_Load(object sender, EventArgs e)
        {

        }
    }
}
