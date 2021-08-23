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
    public partial class HomePage : Form
    {
        string ime = Prijava.ime;
        public HomePage()
        {
            InitializeComponent();
            ime_label.Text = ime;
            
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void Prijava_button_Click(object sender, EventArgs e)
        {
            
            Prijava pr = new Prijava();
            pr.Show();
            this.Hide();
            
            
            
            
        }

        private void Restavracije_button_Click(object sender, EventArgs e)
        {
            Registracija rg = new Registracija();
            rg.Show();
            this.Hide();
            
            
            
        }

        private void Zemljevid_button_Click(object sender, EventArgs e)
        {
            Zemljevid rg = new Zemljevid();
            rg.Show();
            this.Hide();
            
        }

        private void Nastavitve_Click(object sender, EventArgs e)
        {
            if (Prijava.ime == null) MessageBox.Show("Za spreminjanje nastavitev se prijavite!");
            else
            {
                NAstavitvecs rg = new NAstavitvecs();
                rg.Show();
                this.Hide();
            }
            
        }

        private void Restavracije_button_Click_1(object sender, EventArgs e)
        {
            SeznamRestavracij sz = new SeznamRestavracij();
            sz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ime = null;
            ime_label.Text = null;
            MessageBox.Show("Odjava uspešna");
            HomePage hp = new HomePage();
            hp.Refresh();
        }
    }
}
