using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tocilnicaPijace_naloga01
{
    enum tipValute{
        EURO,USD,HRK,NotValid
    }
    class Artikel
    {
        public static string artikliFilePath;

        

        public int id { get; set; }
        public string naziv { get; set; }
        public double kolicina { get; set; }
        public int zaloga { get; set; }
        public double cena { get; set; }
        public tipValute valuta { get; set; }
        public int idDobavitelj { get; set; }

        public Artikel() { }
        

        public Artikel(int id, string naziv, double kolicina, int zaloga, double cena, tipValute valuta, int idDobavitelj)
        {
            this.id = id;
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.zaloga = zaloga;
            this.cena = cena;
            this.valuta = valuta;
            this.idDobavitelj = idDobavitelj;
        }
        public string izpis() => id + ", " + naziv + ", " + kolicina.ToString() + ", " + zaloga + ", " + cena.ToString() + ", " + valuta + ", " + idDobavitelj;
        public string nizFormat() => id + "," + naziv + "," + kolicina.ToString() + "," + zaloga + "," + cena.ToString() + "," + valuta + "," + idDobavitelj+";";
        public bool save()
        {
            try
            {
                if (getAll(artikliFilePath).Exists(t => t.id == this.id))
                    return false;
                using (StreamWriter writer = new StreamWriter(artikliFilePath, true))
                {
                    writer.WriteLine(this.nizFormat());
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public void znizaj(int procent)
        {
            if (getAll(artikliFilePath).Exists(t => t.id == this.id))
            {
                this.cena = cena * (100-procent) / 100;
            }
        }

        public static Artikel getById(int id)
        {
            Artikel artikel = new Artikel();
            using (StreamReader reader = new StreamReader(artikliFilePath))
            {
                string line = null;
                while (null != (line = reader.ReadLine()))
                {
                    line = line.Replace(";", "");
                    string[] values = line.Split(',');
                    if (id != int.Parse(values[0])) continue;
                    artikel.id = int.Parse(values[0]);
                    artikel.naziv = values[1];
                    artikel.kolicina = double.Parse(values[2]);
                    artikel.zaloga = int.Parse(values[3]);
                    artikel.cena = double.Parse(values[4]);
                    artikel.valuta = dolociValuto(values[5]);
                    artikel.idDobavitelj = int.Parse(values[6]);
                    
                }
            }
            return artikel;
        }
        public static List<Artikel> getAll(string path)
        {
            List<Artikel> listArtikli = new List<Artikel>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line = null;
                while (null != (line = reader.ReadLine()))
                {
                    line = line.Replace(";", "");
                    Artikel artikel = new Artikel();
                    string[] values = line.Split(',');
                    artikel.id = int.Parse(values[0]);
                    artikel.naziv = values[1];
                    artikel.kolicina = Convert.ToDouble(values[2], new CultureInfo("en-US"));
                    artikel.zaloga = int.Parse(values[3]);
                    artikel.cena = Convert.ToDouble(values[4], new CultureInfo("en-US"));
                    artikel.valuta = dolociValuto(values[5]);
                    artikel.idDobavitelj = int.Parse(values[6]);

                    listArtikli.Add(artikel);
                }
            }
            return listArtikli;
        }

        

        public static tipValute dolociValuto(string niz)
        {
            if (niz == "EURO") return tipValute.EURO;
            if (niz == "HRK") return tipValute.HRK;
            if (niz == "USD") return tipValute.USD;
            else return tipValute.NotValid;
        }

        public static bool saveInNewFile(List<Artikel> list, string fileName)
        {
            try
            {
                string path = Program.setFilePath(fileName);
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    foreach (var artikel in list)
                    {
                        writer.WriteLine(artikel.nizFormat());
                    }
                }
            }
            catch { return false; }
            return true;
        }
           

        public static List<Artikel> artikliDob_WhereZalogaLess(int idDob, int zalogaManj)=> getAll(artikliFilePath).Where(t => t.idDobavitelj == idDob && t.zaloga < zalogaManj).ToList();
       
       

        
    }
}
