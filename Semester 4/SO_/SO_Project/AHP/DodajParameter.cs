using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHP
{
    public partial class DodajParameter : Form
    {
        public string Naziv { get; set; }
        
        public DodajParameter()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text)) {
                MessageBox.Show("Naziv ne more ostati prazen!");
                return;
            }
            Naziv = txtNaziv.Text;
            Close();
        }
    }
}
