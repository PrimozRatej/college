using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using UrnikGooG_AdminClient.Controller;
using UrnikGooG.Ogrodje;


namespace UrnikGooG_AdminClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindow_Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new MainWindow_Controller(this);
            controller.ObIncializaciji(this);
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string serviceURLzap1 = "http://localhost:57982/Storitev/Service1.svc/Zaposleni/30";
            

            Zaposleni zap = RestHelper.GetObject<Zaposleni>(serviceURLzap1); //GetOne
            //List<Zaposleni> zapList = RestHelper.GetListOfObjects<Zaposleni>(serviceURLzapList);
            zap.Priimek += 12345; 
            //List<Zaposleni> zapList = RestHelper.GetListOfObjects<Zaposleni>(serviceURLzapList); GetAll
            //RestHelper.PutObject<Zaposleni>(zap, serviceURLzapList);
            MessageBox.Show(zap.Ime);
        }

        //Ko se naloži določen tab se grid za ta tab izpolni izpolni
        private void TabControlMaster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int num = TabControlMaster.SelectedIndex;
            if(num == 0)//Mesečni urnik
            {
                //
            }
            if (num == 1)//Zaposleni
            {
                controller.Zaposleni.LoadDataGrid_AllZaposleni(DataGrid_Zaposleni);
            }
            if (num == 2)//Dopust
            {
                List<Dopust> listDop = controller.Dopust.LoadDataGrid();
            }
            if (num == 3)//Bolniška
            {
                List<Bolniška> list = controller.Bolniska.LoadDataGrid(DataGrid_Bolniska);
            }
            if (num == 4)//Izmena
            {
                controller.Izmena.LoadDataGrid(DataGrid_Izmena);
            }
            if (num == 5)//Opravilo
            {
                controller.Opravilo.LoadDataGrid(DataGrid_Opravilo);
            }
            if (num == 6)//ProstiDan
            {
                controller.ProstiDan.LoadDataGrid(DataGrid_ProstiDan);
            }
        }

        private void button_Zaposleni_IzberiVse_Click(object sender, RoutedEventArgs e)
        {
            controller.Zaposleni.LoadDataGrid_AllZaposleni(DataGrid_Zaposleni);
        }

        private void button_Zaposleni_IščiPoImenu_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox_iščiPo.SelectedItem == null)
            {
                MessageBox.Show("Izberi atribut");
                return;
            }
            string niz = textBox_Zaposleni_IščiPoImenu.Text;
            if(comboBox_iščiPo.SelectedItem.ToString() == "Id")
            {
                int št;
                bool jeŠtevilo = int.TryParse(niz, out št);
                if (jeŠtevilo)
                    controller.Zaposleni.LoadDataGrid_ZaposleniPoId(DataGrid_Zaposleni, št);
                else MessageBox.Show("Vnesite Število");
            }
            if (comboBox_iščiPo.SelectedItem.ToString() == "Ime")
            {
                controller.Zaposleni.LoadDataGrid_ZaposleniPoImenu(DataGrid_Zaposleni, niz);
            }
            if (comboBox_iščiPo.SelectedItem.ToString() == "Priimek")
            {
                controller.Zaposleni.LoadDataGrid_ZaposleniPoPriimku(DataGrid_Zaposleni, niz);
            }
            if (comboBox_iščiPo.SelectedItem.ToString() == "Davčna številka")
            {
                int št;
                bool jeŠtevilo = int.TryParse(niz, out št);
                if (jeŠtevilo)
                    controller.Zaposleni.LoadDataGrid_ZaposleniPoDavčna(DataGrid_Zaposleni, št);
                else MessageBox.Show("Vnesite Število");
            }
            if (comboBox_iščiPo.SelectedItem.ToString() == "Urna postavka")
            {
                double št;
                bool jeŠtevilo = double.TryParse(niz, out št);
                if (jeŠtevilo)
                    controller.Zaposleni.LoadDataGrid_ZaposleniPoPostavka(DataGrid_Zaposleni, št);
                else MessageBox.Show("Vnesite Število");
            }
            if (comboBox_iščiPo.SelectedItem.ToString() == "Emšo")
            {
                controller.Zaposleni.LoadDataGrid_ZaposleniPoEmšo(DataGrid_Zaposleni, niz);
            }
        }

        private void button_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            string ime = textBox_Ime.Text;
            string priimek = textBox_Priimek.Text;
            string emšo = textBox_Emšo.Text;
            string Davčna = textBox_DavčnaŠtevilka.Text;
            string UrnaPost = textBox_UrnaPostavka.Text;
            if (controller.Zaposleni.PreveriVnos(ime, priimek, emšo, Davčna, UrnaPost))
            {
                Zaposleni zap = new Zaposleni();
                zap.Id = controller.Zaposleni.DodeliId();
                zap.Ime = ime;
                zap.Priimek = priimek;
                zap.Emšo = emšo;
                zap.DatvčnaŠtevilka = int.Parse(Davčna);
                zap.UrnaPostavka = double.Parse(UrnaPost);
                if (controller.Zaposleni.safe(zap)) MessageBox.Show("Zaposleni uspešno shranjen");
                else MessageBox.Show("Napaka pri shranjevanju");
            }
            else MessageBox.Show("Nepravilen vnos");
            controller.Zaposleni.LoadDataGrid_AllZaposleni(DataGrid_Zaposleni);
                
        }

        private void buttonOsveži_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Zaposleni zapCombo = (comboBox_ZaposleniIzberi.SelectedItem as AllInOne.ComboBoxItem).Value as Zaposleni;
            if(zapCombo == null) { MessageBox.Show("Izberi uporabnika za osveževanje"); return; }
            string ime = textBoxOsveži_Ime.Text;
            string priimek = textBoxOsveži_Priimek.Text;
            string emšo = textBoxOsveži_Emšo.Text;
            string Davčna = textBoxOsveži_DavčnaŠtevilka.Text;
            string UrnaPost = textBoxOsveži_UrnaPostavka.Text;
            if (controller.Zaposleni.PreveriVnos(ime, priimek, emšo, Davčna, UrnaPost))
            {
                Zaposleni zap = new Zaposleni();
                zap.Id = zapCombo.Id;
                zap.Ime = ime;
                zap.Priimek = priimek;
                zap.Emšo = emšo;
                zap.DatvčnaŠtevilka = int.Parse(Davčna);
                zap.UrnaPostavka = double.Parse(UrnaPost);
                if (controller.Zaposleni.update(zap)) MessageBox.Show("Zaposleni uspešno shranjen");
                else MessageBox.Show("Napaka pri shranjevanju");
            }
            else MessageBox.Show("Nepravilen vnos");
            controller.Zaposleni.LoadDataGrid_AllZaposleni(DataGrid_Zaposleni);
            controller.ComboBox_Osveži(comboBox_ZaposleniIzberi);
        }

        private void comboBox_ZaposleniIzberi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (comboBox_ZaposleniIzberi.SelectedValue != null)
            {
                Zaposleni zap = (comboBox_ZaposleniIzberi.SelectedItem as AllInOne.ComboBoxItem).Value as Zaposleni;
                textBoxOsveži_Ime.Text = zap.Ime;
                textBoxOsveži_Priimek.Text = zap.Priimek;
                textBoxOsveži_Emšo.Text = zap.Emšo;
                textBoxOsveži_DavčnaŠtevilka.Text = zap.DatvčnaŠtevilka.ToString();
                textBoxOsveži_UrnaPostavka.Text = zap.UrnaPostavka.ToString();
            }
            
        }

        private void comboBox_ZaposleniZbriši_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (comboBox_ZaposleniZbriši.SelectedValue != null)
            {
                Zaposleni zap = (comboBox_ZaposleniZbriši.SelectedItem as AllInOne.ComboBoxItem).Value as Zaposleni;
                label_ZaposleniIzbriši_Info.Content += "\n " + zap.Id + "\n" + zap.Ime + "\n" + zap.Priimek + "\n" + zap.Emšo;
            }
        }

        private void buttonZaposleni_Zbriši_Click(object sender, RoutedEventArgs e)
        {
            
            if (comboBox_ZaposleniZbriši.SelectedValue != null)
            {
                Zaposleni zap = (comboBox_ZaposleniZbriši.SelectedItem as AllInOne.ComboBoxItem).Value as Zaposleni;
                if (controller.Zaposleni.delete(zap)) MessageBox.Show("Brisanje uspešno");
                else MessageBox.Show("Pri brisanju je prišlo do napake");
                controller.Zaposleni.LoadDataGrid_AllZaposleni(DataGrid_Zaposleni);
                controller.ComboBox_Osveži(comboBox_ZaposleniZbriši);
                label_ZaposleniIzbriši_Info.Content = "Zaposleni:";
            }
            else MessageBox.Show("Izberite zaposlenega za brisanje");
            
        }

        private void button_Dopusti_IščiPoImenu_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox_iščiPo_Dopusti.SelectedValue != null)
            {
                Zaposleni zap = (comboBox_iščiPo_Dopusti.SelectedItem as AllInOne.ComboBoxItem).Value as Zaposleni;
                //Noče povozit starih vrednosti
                DataGrid_Dopust.ItemsSource = controller.Dopust.LoadDataGrid_DopustiZaposlenega(zap);
                controller.ComboBox_Osveži(comboBox_iščiPo_Dopusti);
            }
            else MessageBox.Show("Izberite zaposlenega za brisanje");
        }

        private void comboBox_iščiPo_Dopusti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
