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
    public partial class RezervacijaMize : Form
    {
        public RezervacijaMize()
        {
            InitializeComponent();
        }

        private void Nazaj_button_Click(object sender, EventArgs e)
        {
            ProfilRestavracije pf = new ProfilRestavracije();
            pf.Show();
            this.Close();
        }

        private void Rezerviraj_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rezervacija mize uspešna");
            ProfilRestavracije pf = new ProfilRestavracije();
            pf.Show();
            this.Close();
        }
    }
}
