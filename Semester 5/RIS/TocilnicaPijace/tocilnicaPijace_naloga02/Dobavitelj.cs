using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tocilnicaPijace_naloga02
{
    class Dobavitelj
    {
        public static string filePathDobavitelji = @"C:\Users\primoz.ratej\Google Drive\College Life\3. letnik\Razvoj informacijskih rešitev\Vaje\naloga_01\tocilnicaPijace_naloga01\tocilnicaPijace_naloga02\dokumenti\dobavitelji.xml";
        public static List<Dobavitelj> Dobavitelji = new List<Dobavitelj>();
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Ulica { get; set; }
        public string Stevilka { get; set; }
        public string Posta { get; set; }
        public int PostnaStevilka { get; set; }

        public Dobavitelj()
        {
            Id = int.MaxValue;
            Naziv = "NaM";
            Ime = "NaM";
            Priimek = "NaM";
            Ulica = "Nam";
            Stevilka = "Nam";
            Posta = "NaM";
            PostnaStevilka = int.MaxValue;
        }
        public Dobavitelj(int id, string naziv, string ime, string priimek, string ulica, string stevilka, string posta, int postnaStevilka)
        {
            Id = id;
            Naziv = naziv;
            Ime = ime;
            Priimek = priimek;
            Ulica = ulica;
            Stevilka = stevilka;
            Posta = posta;
            PostnaStevilka = postnaStevilka;
        }

        public override string ToString()
        {
            return string.Format("|{0,3}|{1,18}|{2,9}|{3,9}|{4,20}|{5,6}|{6,10}|{7,6}", Id, Naziv, Ime, Priimek, Ulica, Stevilka, Posta, PostnaStevilka);
        }
    }
}
