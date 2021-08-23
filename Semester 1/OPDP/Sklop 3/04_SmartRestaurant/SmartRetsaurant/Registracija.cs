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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PogojiUporabe pg = new PogojiUporabe();
            pg.Show();
        }

        private void Registracija_butten_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) MessageBox.Show("Najprej se morate strinjati s pogoji uporabe");
            else
            {
                MessageBox.Show("Registracija uspela");
                
                this.Close();
                HomePage hp = new HomePage();
                hp.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
