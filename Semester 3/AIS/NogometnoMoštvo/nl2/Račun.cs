using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nl2
{
    public class Račun
    {
        [Key]
        public int RačunId { get; set; }
        public Komitent lastnik { get; set; }
        public double stanje { get; set; }
        public double limit { get; set; }
        public bool blokiran { get; set; }
        public string Banka { get; set; }
        

        public Račun()
        {

        }
        public Račun(Komitent komitent, double stanje, double limit, bool blokiran, string banka)
        {
            this.lastnik = komitent;
            this.stanje = stanje;
            this.limit = limit;
            this.blokiran = blokiran;
            this.Banka = banka;
        }

        public void Izpis()
        {
            Console.WriteLine("Stanje: " + this.stanje + " $");
            Console.WriteLine("Limit: " + this.limit + " $");
            if (blokiran == true)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Račun je BLOKIRAN");
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
                Console.WriteLine("Račun ODPRT");
            Console.WriteLine("Banka: " + this.Banka);
            
        }
    }
}