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
    
    public partial class Prijava : Form
    {
        static public string ime = null;
        public Prijava()
        {
            InitializeComponent();
                   
        }

        private void Prijava_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Prijava_button_Click(object sender, EventArgs e)
        {
            if (ime_textBox.Text == "") MessageBox.Show("Nepravilno uporabniško ime");
            if (Geslo_textBox.Text == "") MessageBox.Show("Nepravilno geslo");
            else
            {
                ime = ime_textBox.Text;
                MessageBox.Show("Prijava uspešna");
                this.Close();
                HomePage hp = new HomePage();
                hp.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }
    }
}
