using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;

namespace tocilnicaPijace_naloga01
{
    public enum tipValute{
        EURO,USD,HRK,NotValid
    }
    class Artikel
    {
        public static string filePathArtikli = @"C:\Users\primoz.ratej\Google Drive\College Life\3. letnik\Razvoj informacijskih rešitev\Vaje\naloga_01\tocilnicaPijace_naloga01\tocilnicaPijace_naloga02\dokumenti\artikli.xml";
        public int id { get; set; }
        public string naziv { get; set; }
        public double kolicina { get; set; }
        public int zaloga { get; set; }
        public double znesek { get; set; }
        public tipValute valuta { get; set; }
        public DateTime datumZadnjeNabave { get; set; }
        public int dobaviteljId { get; set; }

        public Artikel() { }
        

        public Artikel(int id, string naziv, double kolicina, int zaloga, double znesek, tipValute valuta, DateTime datumZadnjeNabave, int dobaviteljId)
        {
            this.id = id;
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.zaloga = zaloga;
            this.znesek = znesek;
            this.valuta = valuta;
            this.datumZadnjeNabave = datumZadnjeNabave;
            this.dobaviteljId = dobaviteljId;
        }

        

        public static tipValute GetTip(string niz)
        {
            if (niz == "EURO") return tipValute.EURO;
            if (niz == "USD") return tipValute.USD;
            if (niz == "HRK") return tipValute.HRK;
            return tipValute.NotValid;
        }

        public override string ToString()
        {
            return string.Format("|{0,3}|{1,8}|{2,5}|{3,5}|{4,5}|{5,3}|{6,10}|{7,3}", id, naziv, kolicina, znesek, valuta, zaloga, datumZadnjeNabave.ToShortDateString(), dobaviteljId);
        }




    }
}
