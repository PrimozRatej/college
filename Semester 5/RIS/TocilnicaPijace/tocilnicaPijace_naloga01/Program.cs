using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tocilnicaPijace_naloga01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Artikel.artikliFilePath = setFilePath("artikliFile.txt");
            if (!File.Exists(Artikel.artikliFilePath))
            {
                using (var myFile = File.Create(Artikel.artikliFilePath)) ;
            }

            do
            {
                try
                {
                    Console.Write("run ");
                    string comand = Console.ReadLine();
                    if (comand == "end") return;
                    if (comand == "save")
                    {
                        Artikel artikel = vpis();
                        if (artikel.save()) Console.WriteLine("OK");
                        else Console.WriteLine("NOT_OK");

                    }
                    if (comand == "getByDobId")
                    {
                        Console.WriteLine("DobavilteljID");
                        izpisArtiklovDobavitelja(int.Parse(Console.ReadLine()));

                    }
                    if (comand == "znizaj")
                    {
                        List<Artikel> znizaniArtikli = new List<Artikel>();
                        do
                        {
                            Console.WriteLine("Artikel id");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Znižaj za % (0-100)");
                            int procenti = int.Parse(Console.ReadLine());
                            Artikel artikel = Artikel.getById(id);
                            artikel.znizaj(procenti);
                            znizaniArtikli.Add(artikel);
                            Console.WriteLine("Dodaj novo znizanje? (Yes/No)");
                        } while (Console.ReadLine() == "Yes");
                        izpisAll(znizaniArtikli);
                        Console.WriteLine("Zelite shraniti v dokument? (Yes/No)");
                        if (Console.ReadLine() == "Yes")
                        {
                            Console.WriteLine("Set file name");
                            if (!Artikel.saveInNewFile(znizaniArtikli, Console.ReadLine()))
                                Console.WriteLine("Napaka pri shranjevanju dokumenta");
                        }
                    }

                    if (comand.Contains("dobArt_where_zaloga"))
                    {
                        Console.Write("Dobavitelj id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Zaloga manjša od: ");
                        int zaloga = int.Parse(Console.ReadLine());
                        List<Artikel> artikli = Artikel.artikliDob_WhereZalogaLess(id, zaloga);
                        izpisAll(artikli);
                        Console.WriteLine("Save in file Yes/No");
                        if (Console.ReadLine() == "Yes")
                        {
                            Console.WriteLine("File name");
                            string fileName = Console.ReadLine();
                            Artikel.saveInNewFile(artikli, fileName);
                        }
                    }

                    if (comand == "readFile")
                    {
                        Console.WriteLine("File name: ");
                        string path = setFilePath(Console.ReadLine());
                        if (File.Exists(path))
                        {
                            izpisAll(Artikel.getAll(path));
                        }

                    }
                    if (comand == "getAll") izpisAll(Artikel.getAll(Artikel.artikliFilePath));
                    if (comand == "help") help();
                    if (comand == "getById")
                    {
                        Console.Write("id: ");
                        Console.WriteLine(Artikel.getById(int.Parse(Console.ReadLine())).izpis());
                    }
                    if (comand == "clearConsole") Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);
        }

        static Artikel vpis()
        {
            Artikel artikel = new Artikel();
            Console.WriteLine("id");
            artikel.id = int.Parse(Console.ReadLine());
            Console.WriteLine("naziv");
            artikel.naziv = Console.ReadLine();
            Console.WriteLine("kolicina");
            artikel.kolicina = double.Parse(Console.ReadLine());
            Console.WriteLine("zaloga");
            artikel.zaloga = int.Parse(Console.ReadLine());
            Console.WriteLine("cena");
            artikel.cena = double.Parse(Console.ReadLine());
            Console.WriteLine("valuta");
            artikel.valuta = Artikel.dolociValuto(Console.ReadLine());
            Console.WriteLine("idDobavitelja");
            artikel.idDobavitelj = int.Parse(Console.ReadLine());
            return artikel;
        }

        static void izpisAll(List<Artikel> listArtikli)
        {
            foreach (var artikel in listArtikli)
            {
                Console.WriteLine(artikel.izpis());
            }
        }

        static void izpisArtiklovDobavitelja(int id)
        {
            foreach (var artikel in Artikel.getAll(Artikel.artikliFilePath))
            {
                if (artikel.idDobavitelj != id) continue;
                else Console.WriteLine(artikel.izpis());
            }
        }

        static void help()
        {
            Console.WriteLine("Comands: end, save, help, getByDobId, getAll, clearConsole, dobArt_where_zaloga, readFile, znizaj, getById");
        }

        public static string setFilePath(string fileName)
        {
            string currentDir = Environment.CurrentDirectory;
            string fileDir = currentDir.Replace(@"bin\Debug","");
            return fileDir+""+fileName;
        }


    }
}
