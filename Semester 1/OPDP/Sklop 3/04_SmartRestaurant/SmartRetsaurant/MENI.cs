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
    public partial class MENI : Form
    {
        public MENI()
        {
            InitializeComponent();
            DateTime dt = DateTime.Today;
            

            label2.Text = (dt.Day + "." + dt.Month + "." + dt.Year).ToString();
        }

        private void MENI_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfilRestavracije pf = new ProfilRestavracije();
            pf.Show();

            this.Close();
        }
    }
}
