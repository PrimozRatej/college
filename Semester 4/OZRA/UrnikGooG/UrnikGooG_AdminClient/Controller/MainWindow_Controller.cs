using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using UrnikGooG_AdminClient.Properties;
using UrnikGooG_AdminClient;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_AdminClient.Controller
{
    public class MainWindow_Controller
    {
        
        public Zaposleni_Controller Zaposleni;
        public Bolniska_Controller Bolniska;
        public Dopust_Controller Dopust;
        public Izmena_Controller Izmena;
        public Opravilo_Controller Opravilo;
        public ProstiDnevi_Controller ProstiDan;
        public TipOpravila_Controller TipOpravila;
        public Urnik_Controller Urnik;
        
        public MainWindow_Controller(MainWindow win)
        {
            Zaposleni = new Zaposleni_Controller();
            Dopust = new Dopust_Controller(win.DataGrid_Dopust);
            Bolniska = new Bolniska_Controller();
            Izmena = new Izmena_Controller();
            Opravilo = new Opravilo_Controller();
            ProstiDan = new ProstiDnevi_Controller();
            TipOpravila = new TipOpravila_Controller();
            Urnik = new Urnik_Controller(); 
        }

        public void ObIncializaciji(MainWindow win)
        {
            this.ComboBoxs_incialize(win);
        }

        public void ComboBoxs_incialize(MainWindow win)
        {
            //Zaposleni
            win.comboBox_iščiPo.Items.Add("Id");
            win.comboBox_iščiPo.Items.Add("Ime");
            win.comboBox_iščiPo.Items.Add("Priimek");
            win.comboBox_iščiPo.Items.Add("Emšo");
            win.comboBox_iščiPo.Items.Add("Davčna številka");
            win.comboBox_iščiPo.Items.Add("Urna postavka");
            ComboBox_Osveži(win.comboBox_ZaposleniIzberi);
            ComboBox_Osveži(win.comboBox_ZaposleniZbriši);
            ComboBox_Osveži(win.comboBox_iščiPo_Dopusti);

            
        }

        public void ComboBox_Osveži(ComboBox com)
        {
            com.Items.Clear();
            foreach (var zap in RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList))
            {
                AllInOne.ComboBoxItem item = new AllInOne.ComboBoxItem();
                item.Text = "ID: " + zap.Id + ", " + zap.Ime + ", " + zap.Priimek;
                item.Value = zap;
                com.Items.Add(item);
            }
        }

        
    }
}
