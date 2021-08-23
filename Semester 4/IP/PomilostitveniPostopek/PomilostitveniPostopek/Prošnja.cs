using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Documents;

namespace PomilostitveniPostopek
{
    public enum StanjaProšnje { ČakaPostopek = 1, vPostopku = 2, Zavrnjena = 3, Potrjena = 4, Zaključena = 5  };
    public class Prošnja
    {
        int id;
        string path_;
        string ime;
        public List<string> stanja;

        public StanjaProšnje Sodišče { get; set; }
        public StanjaProšnje Ministerstvo { get; set; }
        public AllnOne.Ustanova krajObdelave { get; set; }

        
        public string Ime { get { return ime; } set { this.ime = value; } }
        public string path { get { return path_; } set { this.path_ = value; } }
        public Prošnja(string path)
        {
            Sodišče = StanjaProšnje.ČakaPostopek;
            Ministerstvo = StanjaProšnje.ČakaPostopek;    
            id = dodeliID();
            krajObdelave = AllnOne.Ustanova.Sodišče;
            this.path = path;
            stanja = new List<string>();

        }

        public static List<Prošnja> GetAll()
        {
            return Context.prošnje;
        }

        public string Vsebina()
        {
            using (FileStream file = new FileStream(path, FileMode.Open))
            using (StreamReader reader = new StreamReader(file))
            {
                return reader.ReadToEnd();
            }
            
        }

        private static int dodeliID()
        {
            int maxId = 1;
            if (Context.prošnje.Count != 0)
            {
                maxId = Context.prošnje.Max(t => t.id);
                maxId++;
            }
            return maxId;
        }

        public string pridobiIme()
        {
            return path.Substring(path.Length - 15, path.Length);
        }

        public void posodobiStanje()
        {
            
                if (Sodišče == StanjaProšnje.ČakaPostopek)
                    stanja.Add("[" + DateTime.Today + "]" + "Prošnja prispe na sodišče v obdelavo \n");
                if (Sodišče == StanjaProšnje.vPostopku)
                    stanja.Add("[" + DateTime.Today + "]" + "Prošnja je v obdelavi na strani sodišča. \n");
                if (Sodišče == StanjaProšnje.Potrjena)
                    stanja.Add("[" + DateTime.Today + "]" + "Sodišče potrdi prošnjo in ugotovi, da je prošnja ustrezna.\n");
                if (Sodišče == StanjaProšnje.Zavrnjena)
                    stanja.Add("[" + DateTime.Today + "]" + "Sodišče zavrne prošnjo in ugotovi ,da je prošnja neustrezna.\n");
                if (Sodišče == StanjaProšnje.Zaključena)
                    stanja.Add("[" + DateTime.Today + "]" + "Sodišče Zaključi postopek prošnje.\n");
            
            
                if (Ministerstvo == StanjaProšnje.vPostopku)
                    stanja.Add("[" + DateTime.Today + "]" + "Prošnja pride v obdelavo na Ministerstvo.\n");
                if (Ministerstvo == StanjaProšnje.Potrjena)
                    stanja.Add("[" + DateTime.Today + "]" + "Ministerstvo potrdi prošnjo.\n");
                if (Ministerstvo == StanjaProšnje.Zavrnjena)
                    stanja.Add("[" + DateTime.Today + "]" + "Ministerstvo zavrne prošnjo.\n");

        }

        public string pridobiStanje()
        {
            string niz = "";
            foreach (var stanje in stanja)
            {
                niz += stanje;
            }
            return niz;
        }

        public void dodajOpombo(AllnOne.Ustanova ustanova)
        {
            string ustanovaNiz = "";
            if (ustanova == AllnOne.Ustanova.Ministerstvo) ustanovaNiz = "Ministerstvo";
            if (ustanova == AllnOne.Ustanova.Sodišče) ustanovaNiz = "Sodišče";
            if (ustanova == AllnOne.Ustanova.Tožilec) ustanovaNiz = "Tožilec";

            using (Stream stream = new FileStream(this.path,FileMode.Open))
            using (StreamWriter writer = File.AppendText(this.path))
            {


                writer.WriteLine("[" + ustanovaNiz + "]");
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("[*" + ustanovaNiz + "]");
            }
        }

        public void Append(string dokumentRichTxtBox)
        {
            string dokument = dokumentRichTxtBox;
            using (File.Create(this.path)) { }
            File.WriteAllLines(this.path, dokument.Split('\n'), Encoding.UTF8);      
        }

    }
}
