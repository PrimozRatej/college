using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace nl2
{
    public class Transakcija
    {
        [Key]
        public int TransakcijaId { get; set; }
        public DateTime datumTransakcije { get; set; }
        public double znesek { get; set; }
        public Račun račun { get; set; }
        


        public Transakcija()
        {

        }
        public Transakcija(DateTime datumTransakcije, double znesek, Račun Račun)
        {
            this.datumTransakcije = datumTransakcije;
            this.znesek = znesek;
            this.račun = Račun;
        }
      

        public void izpis()
        {
            Console.WriteLine("Datum transakcije: " + datumString(this.datumTransakcije));
            Console.WriteLine("Vrednost transakcije: " + znesek + "$");
        }

        public string datumString(DateTime date)
        {
            return date.Day + "." + date.Month + "." + date.Year;
        }



    }
}