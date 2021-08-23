using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;
using PredlogaZaPreverjanjeV2.Classes;
using PredlogaZaPreverjanjeV2.Helpers;
using System.Windows.Controls;

namespace PredlogaZaPreverjanjeV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string baseUrl = ConfigurationManager.AppSettings["serviceUrl"];
        
        public MainWindow()
        {
            InitializeComponent();

            knjigeGw.ItemsSource = RestHelper.GetListOfObjects<Knjiga>(baseUrl + "knjige");
            claniGw.ItemsSource = RestHelper.GetListOfObjects<Clan>(baseUrl + "clani");
        }

        public string idClana;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object selectedItem = knjigeGw.SelectedItem;
            string idKnjige = (knjigeGw.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;

            var uspesno = RestHelper.DeleteObject(baseUrl + "knjiga/" + idKnjige);

            if (uspesno == "true")
            {
                MessageBox.Show("Knjiga je uspešno odstranjena!", "Obvestilo");
                knjigeGw.ItemsSource = RestHelper.GetListOfObjects<Knjiga>(baseUrl + "knjige");
            }
            else
            {
                MessageBox.Show("Knjige ni bilo mogoče odstraniti!", "Napaka");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object selectedItem = claniGw.SelectedItem;
            string idClana = (claniGw.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;

            var uspesno = RestHelper.DeleteObject(baseUrl + "clan/" + idClana);

            if (uspesno == "true")
            {
                MessageBox.Show("Član je uspešno odstranjena!", "Obvestilo");
                claniGw.ItemsSource = RestHelper.GetListOfObjects<Clan>(baseUrl + "clan");
            }
            else
            {
                MessageBox.Show("Člana ni bilo mogoče odstraniti!", "Napaka");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Knjiga k = new Knjiga();

            k.Naslov = naslovTb.Text;
            k.Avtor = avtorTb.Text;
            k.StStrani = int.Parse(stStraniTb.Text);

            var uspesno = RestHelper.PostObject<Knjiga>(k, baseUrl + "knjiga");

            if (uspesno == "true")
            {

                knjigeGw.ItemsSource = RestHelper.GetListOfObjects<Knjiga>(baseUrl + "knjige");
                MessageBox.Show("Knjiga je uspešno dodana!", "Obvestilo");
            }
            else
            {
                MessageBox.Show("Knjige ni bilo mogoče dodati!", "Napaka");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Clan c = new Clan();

            c.Ime = imeTb.Text;
            c.Priimek = priimekTb.Text;

            var uspesno = RestHelper.PostObject<Clan>(c, baseUrl + "clan");

            if (uspesno == "true")
            {

                claniGw.ItemsSource = RestHelper.GetListOfObjects<Clan>(baseUrl + "clani");
                MessageBox.Show("Član je uspešno dodana!", "Obvestilo");
            }
            else
            {
                MessageBox.Show("Člana ni bilo mogoče dodati!", "Napaka");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Clan c = new Clan();

            c.Id = int.Parse(idClana);
            c.Ime = imeTb.Text;
            c.Priimek = priimekTb.Text;

            var uspesno = RestHelper.PutObject<Clan>(c, baseUrl + "clan");

            if (uspesno == "true")
            {                
                MessageBox.Show("Član je uspešno urejen!", "Obvestilo");
                claniGw.ItemsSource = RestHelper.GetListOfObjects<Clan>(baseUrl + "clani");
            }
            else
            {
                MessageBox.Show("Člana ni bilo mogoče urediti!", "Napaka");
            }
        }

        private void claniGw_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = claniGw.SelectedItem;

            try
            {
                idClana = (claniGw.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                imeTb.Text = (claniGw.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
                priimekTb.Text = (claniGw.SelectedCells[2].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
            catch
            {
 
            }
        }
    }
}
