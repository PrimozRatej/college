using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHP
{
    public partial class Zacetni : Form
    {
        public Zacetni()
        {
            InitializeComponent();
        }

        private void btnUsdtvari_Click(object sender, EventArgs e)
        {
            Hide();
            new AHPOkno().Show();
        }

        private void btnIzDiska_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Title = "Izberite ime datoteke za odpiranje modela",
                FileName = "model.dat",
                Filter = "Datoteke modela (*.dat)|*.dat",
                DefaultExt = "dat"
            };
            if (DialogResult.OK != ofd.ShowDialog())
                return;

            Model m;
            try
            {
                using (FileStream stream = File.OpenRead(ofd.FileName))
                {
                    var formatter = new BinaryFormatter();
                    m = (Model)formatter.Deserialize(stream);
                }
            }
            catch {
                MessageBox.Show("Nepodprti format!");
                return;
            }
            Hide();
            new AHPOkno(m).Show();
        }
    }
}
