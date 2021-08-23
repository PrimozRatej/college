using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.servis;

namespace GUI
{
    public partial class Glavno : Form
    {
        WebServiceMoj servise;
        public Glavno()
        {
            
            InitializeComponent();
            servise = new WebServiceMoj();
            if(FormLogin.upo.aliJeAdmin)
            {
                PogledAdmin();
            }

            
 
            
        }

        private void Glavno_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBoxFunkcije.SelectedItem.ToString();
            switch (curItem)
            {
                case "Komitentje s transakcijami.":
                    dataGridGlavni.DataSource = servise.vrniKomitenteZTransakcijo();
                    break;
                
               
                case "Blokirani računi":
                    dataGridGlavni.DataSource = servise.IzpisBlokiranihRačunov();
                    break;
                case "Najvišja transakcija":
                    List<Transakcija> listNajvisja = new List<Transakcija>();
                    listNajvisja.Add(servise.NajvišjaTransakcija());
                    dataGridGlavni.DataSource = listNajvisja;
                    break;
                case "Povprečna starost komitentov":
                    MessageBox.Show("Povprečna starost komitentov je " + servise.povprecnaStarostKomitentov() + " let.");
                    break;
                case "Dodaj komitenta v sistem":
                    buttonDodajKomitenta dodaj = new buttonDodajKomitenta();
                    dodaj.Show();
                    break;
                case "Izvedi transakcijo na račun":
                    DodajTransakcijo dodajTra = new DodajTransakcijo();
                    dodajTra.Show();
                    break;
                case "Ažuriraj podatke komitenta":
                    //
                    break;
                case "Ažuriraj podatke računa komitenta":
                    //
                    break;
                case "Popravi vrednosti transakcije":
                    //
                    break;
                case "Briši podatke komitenta":
                    //
                    break;
                case "Briši podatke računa komitenta":
                    //
                    break;
                case "Briši transakcije":
                    //
                    break;
                case "Komitenti":
                    dataGridGlavni.DataSource = servise.SeznamKomitentov();
                    break;
                case "Transakcije":
                    dataGridGlavni.DataSource = servise.SeznamTransakcij();
                    break;
                case "Računi":
                    dataGridGlavni.DataSource = servise.seznamRačunov();
                    break;
                default:
                    //
                    break;
            }
        }
        public void PogledAdmin()
        {
            listBoxFunkcije.Items.Add("Komitenti");
            listBoxFunkcije.Items.Add("Transakcije");
            listBoxFunkcije.Items.Add("Računi");
            listBoxFunkcije.Items.Add("Komitentje s transakcijami.");
            listBoxFunkcije.Items.Add("Blokirani računi");
            listBoxFunkcije.Items.Add("Najvišja transakcija");
            listBoxFunkcije.Items.Add("Povprečna starost komitentov");
            listBoxFunkcije.Items.Add("Dodaj komitenta v sistem");
            listBoxFunkcije.Items.Add("Dodaj račun komitentu");
            listBoxFunkcije.Items.Add("Izvedi transakcijo na račun");
            listBoxFunkcije.Items.Add("Ažuriraj podatke komitenta");
            listBoxFunkcije.Items.Add("Ažuriraj podatke računa komitenta");
            listBoxFunkcije.Items.Add("Popravi vrednosti transakcije");
            listBoxFunkcije.Items.Add("Briši podatke komitenta");
            listBoxFunkcije.Items.Add("Briši podatke računa komitenta");
            listBoxFunkcije.Items.Add("Briši transakcije");
            

        }

        public void Išči()
        {
            
        }

        private void radioButtonKomitent_CheckedChanged(object sender, EventArgs e)
        {
            labelKajVnesti.Text = "Za iskanje po KOMITENTIH\rvnesite davcno stevilko komitenta";
        }

        private void radioButtonTransakcija_CheckedChanged(object sender, EventArgs e)
        {
            labelKajVnesti.Text = "Za iskanje po TRANSAKCIJAH\rnajprej vnesite id stevilko komitenta";
        }

        private void radioButtonRačun_CheckedChanged(object sender, EventArgs e)
        {
            labelKajVnesti.Text = "Za iskanje po RAČUNIH\r najprej vnesite davcno stevilko komitenta";
        }

        private void buttonIšči_Click(object sender, EventArgs e)
        {
            if (radioButtonKomitent.Checked)
            {
                List<Komitent> komList = new List<Komitent>();
                Komitent kom = servise.komitent(textBoxIšči.Text);
                if (kom == null)
                {
                    MessageBox.Show("Takšnega komitenta ni v sistemu");
                    dataGridGlavni.DataSource = servise.SeznamKomitentov();
                }

                else
                {
                    komList.Add(kom);
                    dataGridGlavni.DataSource = komList;

                }
            }

            if (radioButtonRačun.Checked)
            {
                List<Račun> račList = servise.RačuniKomitenta(textBoxIšči.Text).ToList();
                if(račList == null)
                {
                    MessageBox.Show("Ta komitent nima računov");
                    dataGridGlavni.DataSource = servise.SeznamKomitentov();
                }
                else
                {
                    dataGridGlavni.DataSource = račList;
                }
            }

            if (radioButtonTransakcija.Checked)
            {
                List<Transakcija> TraList = servise.TransakcijeKomitenta(textBoxIšči.Text).ToList();
                if (TraList == null)
                {
                    MessageBox.Show("Ta komitent nima transakcij");
                    dataGridGlavni.DataSource = servise.SeznamKomitentov();
                }
                else
                {
                    dataGridGlavni.DataSource = TraList;
                }
            }
        }

        
    }
}
