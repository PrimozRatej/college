using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FerkvencnaAnaliza
{
    public partial class Form1 : Form
    {
        public static Datoteka referencna;
        public static Datoteka sifrirna;
        public static Datoteka dekriptirana;

        public string dešifrirana = "";
        public Form1()
        {
            InitializeComponent();
            this.grafReferencna.Enabled = false;
            this.grafSifrirna.Enabled = false;
            this.grafOdkriptirana.Enabled = false;
            this.button2.Enabled = false;
            this.desifriraj.Enabled = false;
            this.Zamenjaj.Enabled = false;

        }
        


        private void refDatButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (TXT)|*.TXT;";
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                string filePath = dialog.FileName;
                referencna = new Datoteka(filePath);
                izpisAnalize(analizaIzpisTextBlock, refDatTextBlock, referencna);
                
            }
            this.grafReferencna.Enabled = true;

            
        }

        public void izpisAnalize(RichTextBox textBlockReferencna,RichTextBox textBlock, Datoteka dat)
        {
            textBlock.Text = "";
            textBlockReferencna.Text = "";
            foreach (var par in dat.ferkvencnaAnaliza)
            {
                textBlockReferencna.Text += (char)par.Key + ": " + par.Value +""+Environment.NewLine;
            }
            textBlock.Text = dat.text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (TXT)|*.TXT;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                sifrirna = new Datoteka(filePath);
                izpisAnalize(izpisAnalizeŠifDat, izpisŠifDat, sifrirna);

            }
            this.grafSifrirna.Enabled = true;
            this.desifriraj.Enabled = true;
            
        }

        private void desifriraj_Click(object sender, EventArgs e)
        {
            Dešifrirnik deš = new Dešifrirnik();
            dešifriranNiz.Text = deš.dešifrirajDelno(referencna, sifrirna);
            this.Zamenjaj.Enabled = true;
            this.button2.Enabled = true;
        }

        private void Zamenjaj_Click(object sender, EventArgs e)
        {
            Dešifrirnik deš = new Dešifrirnik();
            dešifriranNiz.Text = deš.zamenjaj(crkaKiJoZamenjujemoTextBlock.Text,crkaZaZamenjavo.Text,dešifriranNiz.Text);
            dešifrirana = dešifriranNiz.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "dešifriranaDatoteka.txt";
            
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(dešifriranNiz.Text);
                writer.Dispose();
                writer.Close();
            }
            dekriptirana = new Datoteka(Path.GetFullPath(save.FileName));
            this.grafOdkriptirana.Enabled = true;
        }

        private void grafReferencna_Click(object sender, EventArgs e)
        {
            
            grafForm form = new grafForm(referencna);
            form.Show();
        }

        private void grafSifrirna_Click(object sender, EventArgs e)
        {
            grafForm form = new grafForm(sifrirna);
            form.Show();
        }

        private void grafOdkriptirana_Click(object sender, EventArgs e)
        {
            grafForm form = new grafForm(dekriptirana);
            form.Show();
        }

        

    }
}
