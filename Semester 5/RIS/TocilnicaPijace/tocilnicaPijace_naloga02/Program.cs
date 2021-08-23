using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using tocilnicaPijace_naloga01;

namespace tocilnicaPijace_naloga02
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            string comand = "";
            do
            {
                try
                {
                    Console.Write(@"run\");
                    comand = Console.ReadLine();
                    if (comand == "get artikli") getArtikli();
                    if (comand.Contains("get artikel where id=")) getArtikelById(comand);
                    if (comand.Contains("get artikel where naziv=")) getArtikelByNaziv(comand);
                    if (comand == "get dobavitelji") getDobavitelji();
                    if (comand.Contains("get dobavitelj where id=")) getDobaviteljById(comand);
                    if (comand.Contains("remove dobavitelj where id=")) removeDobaviteljById(comand);
                    if (comand.Contains("remove artikel where id=")) removeArtikelById(comand);
                    if (comand == "add artikel") addArtikel();
                    if (comand == "add dobavitelj") addDobavitelj();
                    if (comand == "clear") Console.Clear();
                    if (comand == "help") help();
                    
                }
                catch(Exception ex) { Console.WriteLine(ex.Message); }
            }
            while (comand != "end");
        }

        private static void removeArtikelById(string comand)
        {
            int id = 0;
            if (!int.TryParse(comand.Replace("remove artikel where id=", ""), out id)) throw new Exception("Unvalid command");
            XmlParser parser = new XmlParser();
            if (!parser.Artikli(Artikel.filePathArtikli).Exists(t => t.id == id)) throw new Exception(string.Format("Artikel with id {0} don't exists", id));
            parser.removeArtikel(parser.Artikli(Artikel.filePathArtikli).Where(t => t.id == id).First(), Artikel.filePathArtikli);
        }

        private static void removeDobaviteljById(string comand)
        {
            int id = 0;
            if (!int.TryParse(comand.Replace("remove dobavitelj where id=", ""), out id)) throw new Exception("Unvalid command");
            XmlParser parser = new XmlParser();
            if (!parser.Dobavitelji(Dobavitelj.filePathDobavitelji).Exists(t => t.Id == id)) throw new Exception(string.Format("Dobavitelj with id {0} don't exists", id));
            parser.removeDobavitelj(parser.Dobavitelji(Dobavitelj.filePathDobavitelji).Where(t => t.Id == id).First(),Dobavitelj.filePathDobavitelji);
        }

        private static void getDobaviteljById(string comand)
        {
            XmlParser parser = new XmlParser();
            int id = 0;
            if (!int.TryParse(comand.Replace("get dobavitelj where id=", ""), out id)) throw new Exception("Unvalid command");
            if (!parser.Dobavitelji(Dobavitelj.filePathDobavitelji).Exists(t=>t.Id == id)) throw new Exception(string.Format("Dobavitelj with id {0} don't exists", id));
            Dobavitelj dob = parser.Dobavitelji(Dobavitelj.filePathDobavitelji).Where(t => t.Id == id).First();
            if (dob == null) throw new Exception("No such artikel exist");
            Console.WriteLine(dob.ToString());
        }

        private static void getArtikelById(string comand)
        {
            XmlParser parser = new XmlParser();
            int id = 0;
            if (!int.TryParse(comand.Replace("get artikel where id=", ""),out id)) throw new Exception("Unvalid command");
            if (!parser.Artikli(Artikel.filePathArtikli).Exists(t => t.id == id)) throw new Exception(string.Format("Artikel with id {0} don't exists",id));
            Artikel art = parser.Artikli(Artikel.filePathArtikli).Where(t => t.id == id).First();
            if (art == null) throw new Exception("No such artikel exist");
            Console.WriteLine(art.ToString());

        }

        private static void getArtikelByNaziv(string comand)
        {
            XmlParser parser = new XmlParser();
            string naziv = "";
            try { naziv = comand.Replace("get artikel where naziv=", ""); } catch { throw new Exception("Unvalid command"); }
            Artikel art = parser.Artikli(Artikel.filePathArtikli).Where(t => t.naziv == naziv).First();
            if (art == null) throw new Exception("No such artikel exist");
            Console.WriteLine(art.ToString());
        }

        private static void getDobavitelji()
        {
            XmlParser parser = new XmlParser();
            foreach (var dob in parser.Dobavitelji(Dobavitelj.filePathDobavitelji))
            {
                Console.WriteLine(dob.ToString());
            }
        }

        private static void getArtikli()
        {
            XmlParser parser = new XmlParser();
            foreach (var art in parser.Artikli(Artikel.filePathArtikli))
            {
                Console.WriteLine(art.ToString());
            }
        }

        private static void addArtikel()
        {
            
            XmlParser parser = new XmlParser();
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            if (parser.Artikli(Artikel.filePathArtikli).Exists(t => t.id == id)) throw new Exception(string.Format("There is already Artikel with id {0}",id));
            Console.Write("Naziv: ");
            string naziv = Console.ReadLine();
            Console.Write("Kolicina: ");
            double kolicina = double.Parse(Console.ReadLine());
            Console.Write("Cena: ");
            double cena = double.Parse(Console.ReadLine());
            Console.Write("Valuta: ");
            tipValute val = Artikel.GetTip(Console.ReadLine());
            if (val == tipValute.NotValid) throw new Exception("value tipe in unvalid");
            Console.Write("Zaloga:");
            int zaloga = int.Parse(Console.ReadLine());
            Console.Write("Datum:");
            DateTime datumZadnjeNabave = new DateTime();
            DateTime.TryParse(Console.ReadLine(), CultureInfo.CurrentUICulture, DateTimeStyles.None, out datumZadnjeNabave);
            if (datumZadnjeNabave > DateTime.Now) throw new Exception("Date must be lower than today date");
            Console.Write("Dobavitelj id:");
            int dobId = int.Parse(Console.ReadLine());
            Artikel art = new Artikel(id, naziv, kolicina, zaloga, cena, val, datumZadnjeNabave, dobId);
                
            if (!parser.Dobavitelji(Dobavitelj.filePathDobavitelji).Exists(t => t.Id == dobId)) throw new Exception(string.Format("Dobavitelj with id {0} don't exists.",id));
            parser.AddArtikel(art, Artikel.filePathArtikli);
        }

        private static void addDobavitelj()
        {
            XmlParser parser = new XmlParser();
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            if (parser.Dobavitelji(Dobavitelj.filePathDobavitelji).Exists(t => t.Id == id)) throw new Exception(string.Format("Dobavitelj with id {0} already exist", id));
            Console.Write("Naziv: ");
            string naziv = Console.ReadLine();
            Console.Write("Ime: ");
            string ime = Console.ReadLine();
            Console.Write("Priimek: ");
            string priimek = Console.ReadLine();
            Console.Write("Ulica: ");
            string ulica = Console.ReadLine();
            Console.Write("Stevilka:");
            string stevilka = Console.ReadLine();
            Console.Write("Kraj:");
            string kraj = Console.ReadLine();
            Console.Write("p_stevilka:");
            int p_stevilka = int.Parse(Console.ReadLine());
                
            Dobavitelj dob = new Dobavitelj(id, naziv, ime, priimek, ulica, stevilka, kraj, p_stevilka);
            parser.addDobavitelj(dob, Dobavitelj.filePathDobavitelji);
        }

        public static void help()
        {
            Console.WriteLine("get artikli");
            Console.WriteLine("- Get all from artikli");
            Console.WriteLine();
            Console.WriteLine("get dobavitelji");
            Console.WriteLine("- Get all from dobavitelji");
            Console.WriteLine();
            Console.WriteLine("get artikel where id={int}");
            Console.WriteLine("- get particular artikel by id");
            Console.WriteLine();
            Console.WriteLine("get dobavitelj where id={int}");
            Console.WriteLine("- get particular dobavitelj by id");

        }






    }
}
