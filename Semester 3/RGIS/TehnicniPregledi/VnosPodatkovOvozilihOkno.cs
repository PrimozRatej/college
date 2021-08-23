using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class VnosPodatkovOvozilihOkno : Form
    {
        VoziloControl vozContr;
        public VnosPodatkovOvozilihOkno()
        {
            InitializeComponent();
            vozContr = new VoziloControl();
        }

        private void buttonShrani_Click(object sender, EventArgs e)
        {
            if (vozContr.AliSoPodatkiPravilni(int.Parse(textBoxID.Text), textBoxZnamka.Text, textBoxModel.Text, int.Parse(textBoxLetnik.Text), double.Parse(textBoxPorabaLitri.Text), int.Parse(textBoxSerijskaŠtevilka.Text), dateTimePickerDatumPrveReg.MaxDate, int.Parse(textBoxMasa.Text), textBoxTip.Text))
            {
                int ID = int.Parse(textBoxID.Text);
                string znamka = textBoxZnamka.Text;
                string model = textBoxModel.Text;
                int letnik = int.Parse(textBoxLetnik.Text);
                double porabaLitri = double.Parse(textBoxPorabaLitri.Text);
                int serijskaŠtevilka = int.Parse(textBoxSerijskaŠtevilka.Text);
                DateTime datumRegistracije = dateTimePickerDatumPrveReg.MaxDate;
                double masa = double.Parse(textBoxMasa.Text);
                string tip = textBoxTip.Text;

                Vozilo vozilo = new Vozilo(ID, znamka, model, letnik, porabaLitri, serijskaŠtevilka, datumRegistracije, masa, tip, new List<Opravilo>().ToArray());
                vozilo.VoziloShrani();
                OknoZacetno OknoZAc = new OknoZacetno();
                OknoZAc.Show();
                this.Close();
            }
        }
    }
}
