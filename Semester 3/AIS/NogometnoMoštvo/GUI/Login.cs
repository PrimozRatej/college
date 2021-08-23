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
    public partial class FormLogin : Form
    {
        static WebServiceMoj servise;
        public static UporabniskiRacun upo;
        
        
        public FormLogin()
        {
            InitializeComponent();
            servise = new WebServiceMoj();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string ime = textBoxUporabniškoIme.Text;
            string geslo = textBoxGeslo.Text;
            upo = servise.prijava(ime, geslo);
            if (upo == null) MessageBox.Show("Nepravilno uporabniško ime ali geslo");
            else
            {
                Glavno glavno = new Glavno();
                glavno.Show();
                this.Hide();
                                

            }

        }
    }
}
