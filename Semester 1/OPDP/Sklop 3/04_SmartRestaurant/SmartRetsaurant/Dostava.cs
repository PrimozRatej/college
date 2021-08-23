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
    public partial class Dostava : Form
    {
        public Dostava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfilRestavracije pf = new ProfilRestavracije();
            pf.Show();
            this.Close();

        }

        private void NaročiDostvao_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naročilo dostave uspešno");
            ProfilRestavracije pf = new ProfilRestavracije();
            pf.Show();
            this.Close();
        }
    }
}
