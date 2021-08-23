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
    public partial class SeznamRestavracij : Form
    {
        public SeznamRestavracij()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfilRestavracije2 pf = new ProfilRestavracije2();
            pf.Show();
            this.Close();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfilRestavracije2 pf = new ProfilRestavracije2();
            pf.Show();
            this.Close();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfilRestavracije2 pf = new ProfilRestavracije2();
            pf.Show();
            this.Close();
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfilRestavracije2 pf = new ProfilRestavracije2();
            pf.Show();
            this.Close();
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfilRestavracije2 pf = new ProfilRestavracije2();
            pf.Show();
            this.Close();
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfilRestavracije2 pf = new ProfilRestavracije2();
            pf.Show();
            this.Close();
        }
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfilRestavracije2 pf = new ProfilRestavracije2();
            pf.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage mp = new HomePage();
            mp.Show();
            this.Close();
        }
    }
}
