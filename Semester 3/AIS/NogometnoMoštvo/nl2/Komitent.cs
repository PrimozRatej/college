using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nl2
{
    public class Komitent
    {
        [Key]
        public int KomitentId { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string DavcnaStevilka { get; set; }
        public DateTime DatumRojstva { get; set; }
        
        public Komitent()
        {

        }
        
        public Komitent(string ime, string priimek,string davcnaStevilka, DateTime datumRojstva)
        {
            this.Ime = ime;
            this.Priimek = priimek;
            this.DavcnaStevilka = davcnaStevilka;
            this.DatumRojstva = datumRojstva;
        }

        public void Izpis()
        {
            Console.WriteLine("Ime: " + this.Ime);
            
        }
        public string datumString(DateTime date)
        {
            return date.Day + "." + date.Month + "." + date.Year;
        }

        public string[] poljeIzpis()
        {
            string[] poljeZapis = new string[3];
            poljeZapis[0] = "Ime: " + this.Ime;
            poljeZapis[1] = "Priimek " + this.Priimek;
            poljeZapis[2] = "Davčna številka: " + this.DavcnaStevilka;
            poljeZapis[3] = "Datum rojstva: " + datumString(this.DatumRojstva);
            return poljeZapis;
        }

    }
}