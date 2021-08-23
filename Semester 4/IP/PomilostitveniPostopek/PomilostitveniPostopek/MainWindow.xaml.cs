using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;

namespace PomilostitveniPostopek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string dokument = "";
        public MainWindow()
        {
            InitializeComponent();
            RichTextBoxDokument_Sodišče.Document.PageHeight = 1000;
            AllnOne controller = new AllnOne();
            controller.IncializirajProšnje();
            posodobiSezname();
            

        }

        
        
        public void posodobiSezname()
        {
            listBoxProšnjeSodišče.ItemsSource = Context.Prošnje(AllnOne.Ustanova.Sodišče);
            listBoxProšnjeMinisterstvo.ItemsSource = Context.Prošnje(AllnOne.Ustanova.Ministerstvo);
            listBoxProšnjeTožilec.ItemsSource = Context.Prošnje(AllnOne.Ustanova.Zaključena);
        }

        

        

        private void PočistiPogled(AllnOne.Ustanova ustanova)
        {
            if (ustanova == AllnOne.Ustanova.Sodišče)
            {
                radioButtonNeSkladna.IsChecked = radioButtonSkladna.IsChecked = false;
                labelImeProšnje.Content = "";
                RichTextBoxDokument_Sodišče.Document.Blocks.Clear();
                labelStanjeProšnje.Content = "";
            }
            if (ustanova == AllnOne.Ustanova.Ministerstvo)
            {
                radioButtonNeSkladna_Min.IsChecked = radioButtonSkladna_Min.IsChecked = false;
                labelImeProšnje_Min.Content = "";
                RichTextBoxDokument_Ministerstvo.Document.Blocks.Clear();
                labelStanjeProšnje_Min.Content = "";
            }
        }
        //Click_Shranjevanje---->>
        private void buttonSodiščeShrani_Click(object sender, RoutedEventArgs e)
        {
            if(listBoxProšnjeSodišče.SelectedItem == null)
            {
                MessageBox.Show("Izberi prošnjo za obdelavo");
                return;
            }
            Prošnja prošnja = (Prošnja)listBoxProšnjeSodišče.SelectedItem;
            string dokument = new TextRange(RichTextBoxDokument_Sodišče.Document.ContentStart, RichTextBoxDokument_Sodišče.Document.ContentEnd).Text;
            if (radioButtonNeSkladna.IsChecked == false && radioButtonSkladna.IsChecked == false)
            {
                prošnja.Append(dokument);
                MessageBox.Show("Prošnja " + prošnja.Ime + " je bila shranjena");
                return;
            }
            
            
            prošnja.Append(dokument);
            PosodobiStanje(prošnja, AllnOne.Ustanova.Sodišče);
            posodobiSezname();
            PočistiPogled(AllnOne.Ustanova.Sodišče);

        }

        private void buttonMinisterstvoShrani_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxProšnjeMinisterstvo.SelectedItem == null)
            {
                MessageBox.Show("Izberi prošnjo za obdelavo");
                return;
            }
            Prošnja prošnja = (Prošnja)listBoxProšnjeMinisterstvo.SelectedItem;
            string dokument = new TextRange(RichTextBoxDokument_Ministerstvo.Document.ContentStart, RichTextBoxDokument_Ministerstvo.Document.ContentEnd).Text;
            if (radioButtonNeSkladna_Min.IsChecked == false && radioButtonSkladna_Min.IsChecked == false)
            {
                prošnja.Append(dokument);
                MessageBox.Show("Prošnja " + prošnja.Ime + " je bila shranjena");
                return;
                
            }
            prošnja.Append(dokument);// posodobi datoteko prošnje
            PosodobiStanje(prošnja, AllnOne.Ustanova.Ministerstvo);
            posodobiSezname();
            PočistiPogled(AllnOne.Ustanova.Ministerstvo);

        }
        //----<<
        private void PosodobiStanje(Prošnja prošnja, AllnOne.Ustanova krajObdelave)
        {
            if(krajObdelave == AllnOne.Ustanova.Sodišče)
            {
                prošnja.Sodišče = StanjaProšnje.vPostopku;
                //prošnja.posodobiStanje();
                if (radioButtonNeSkladna.IsChecked == true)
                    prošnja.Sodišče = StanjaProšnje.Zavrnjena;
                if (radioButtonSkladna.IsChecked == true)
                    prošnja.Sodišče = StanjaProšnje.Potrjena;
                if (radioButtonNeSkladna.IsChecked == false && radioButtonSkladna.IsChecked == false)
                    MessageBox.Show("Preden shranite preverite ali je prošnja legitimna in pravilno spisana");
                prošnja.krajObdelave = AllnOne.Ustanova.Ministerstvo;
                prošnja.posodobiStanje();
            }

            if (krajObdelave == AllnOne.Ustanova.Ministerstvo)
            {
                prošnja.Ministerstvo = StanjaProšnje.vPostopku;
                //prošnja.posodobiStanje();
                if (radioButtonNeSkladna_Min.IsChecked == true)
                    prošnja.Ministerstvo = StanjaProšnje.Zavrnjena;
                if (radioButtonSkladna_Min.IsChecked == true)
                    prošnja.Ministerstvo = StanjaProšnje.Potrjena;
                if (radioButtonNeSkladna_Min.IsChecked == false && radioButtonSkladna_Min.IsChecked == false)
                    MessageBox.Show("Preden shranite preverite ali je prošnja legitimna in pravilno spisana");
                //prošnja.posodobiStanje();
                prošnja.Ministerstvo = StanjaProšnje.Zaključena;
                prošnja.krajObdelave = AllnOne.Ustanova.Sodišče;
                prošnja.posodobiStanje();
            }



        }
        //PisanjeVdokument--->>
        
        //----<<
        private void listBoxProšnjeMinisterstvo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Prošnja prošnja = listBoxProšnjeMinisterstvo.SelectedItem as Prošnja;
            if (prošnja == null)
            {
                PočistiPogled(AllnOne.Ustanova.Ministerstvo);
                return;
            }
            labelStanjeProšnje_Min.Content = prošnja.pridobiStanje();
            RichTextBoxDokument_Ministerstvo.Document.Blocks.Clear();
            labelImeProšnje_Min.Content = prošnja.Ime;
            RichTextBoxDokument_Ministerstvo.Document.Blocks.Add(new Paragraph(new Run(File.ReadAllText(prošnja.path))));
        }

        private void listBoxProšnjeSodišče_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stackPanelZaključi.Visibility = Visibility.Hidden;
            Prošnja prošnja = listBoxProšnjeSodišče.SelectedItem as Prošnja;
            
            if (prošnja == null)
            {
                PočistiPogled(AllnOne.Ustanova.Sodišče);
                return;
            }
            if (prošnja.Ministerstvo == StanjaProšnje.Zaključena)
            {
                stackPanelZaključi.Visibility = Visibility.Visible;
            }

            labelStanjeProšnje.Content = prošnja.pridobiStanje();
            labelImeProšnje.Content = "";
            RichTextBoxDokument_Sodišče.Document.Blocks.Clear();
            labelImeProšnje.Content = prošnja.Ime;
            RichTextBoxDokument_Sodišče.Document.Blocks.Add(new Paragraph(new Run(File.ReadAllText(prošnja.path, Encoding.UTF8))));
        }

        private void buttonSodiščeZaključi_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxProšnjeSodišče.SelectedItem == null)
            {
                MessageBox.Show("Izberi prošnjo za obdelavo");
                return;
            }
            Prošnja prošnja = (Prošnja)listBoxProšnjeSodišče.SelectedItem;
            string dokument = new TextRange(RichTextBoxDokument_Sodišče.Document.ContentStart, RichTextBoxDokument_Sodišče.Document.ContentEnd).Text;
            prošnja.Append(dokument);
            prošnja.krajObdelave = AllnOne.Ustanova.Zaključena;
            posodobiSezname();
            PočistiPogled(AllnOne.Ustanova.Sodišče);
        }

        private void buttonSodiščeDodajOpombo_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxProšnjeSodišče.SelectedItem == null)
            {
                MessageBox.Show("Izberi prošnjo za obdelavo");
                return;
            }
            Prošnja prošnja = (Prošnja)listBoxProšnjeSodišče.SelectedItem;
            prošnja.dodajOpombo(AllnOne.Ustanova.Sodišče);
        }

        private void listBoxProšnjeTožilec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Prošnja prošnja = listBoxProšnjeTožilec.SelectedItem as Prošnja;

            if (prošnja == null)
            {
                PočistiPogled(AllnOne.Ustanova.Sodišče);
                return;
            }

            RichTextBoxDokument_Zaključene.Document.Blocks.Add(new Paragraph(new Run(File.ReadAllText(prošnja.path, Encoding.UTF8))));
        }

        private void tabcontrol_main_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabItem item = tabcontrol_main.SelectedItem as TabItem;
            if (item.Name == "Sodišče_tab" && Users.Sodišče_prijavljeni == null)
            {
                Prijava prijava = new Prijava(this, AllnOne.Ustanova.Sodišče);
                this.Visibility = Visibility.Hidden;
                prijava.Show();
            }
            if (item.Name == "Ministerstvo_tab" && Users.ministerstvo_prijavljeni == null)
            {
                Prijava prijava = new Prijava(this, AllnOne.Ustanova.Ministerstvo);
                this.Visibility = Visibility.Hidden;
                prijava.Show();
            }
        }
    }
}
