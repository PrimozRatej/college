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
    public partial class Zemljevid : Form
    {
        public Zemljevid()
        {
            InitializeComponent();
        }

        private void nazaj_button_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }

        private void SmartRestaurant_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfilRestavracije pf = new ProfilRestavracije();
            pf.Show();
            this.Hide();
        }
    }
}
