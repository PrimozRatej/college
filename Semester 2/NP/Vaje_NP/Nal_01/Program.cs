using System;

namespace Vaje_NP
{
    class Program
    {
        public class Vozilo
        {
            public Oseba voznik;
            public string znamka;
            public string tip;
            public double porabaGorivaNa100km;
            public double velikostRezervarja;

            public Vozilo()
            {
                voznik = new Oseba();
                znamka = "Ne";
                tip = "Ne";
                porabaGorivaNa100km = 0;
                velikostRezervarja = 0;
            }

            public Vozilo(string znamka, string tip)
            {
                voznik = new Oseba("Jan", "lol");
                this.znamka = znamka;
                this.tip = tip;
            }

            public void Izpis()
            {
                voznik.Izpis();
                Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}", znamka, tip, porabaGorivaNa100km, velikostRezervarja);
            }



        }

        public class Oseba
        {
            public Naslov naslov;
            public string ime;
            public string priimek;
            public char spol;
            public DateTime datumRojstva;


            public Oseba()
            {
                ime = "Ne";
                priimek = "Ne";
                spol = 'X';
                datumRojstva = new DateTime(1000, 1, 1);

            }

            public Oseba(string ime, string priimek)
            {
                this.ime = ime;
                this.priimek = priimek;

            }


            public void Izpis()
            {
                Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3} \n", ime, priimek, spol, datumRojstva);
            }


        }
        public class Naslov
        {
            string Ulica;
            string hisnaStevilka;
            int Postnastevilka;

            public Naslov()
            {

            }
            public Naslov(string Ulica, string hisnaStevilka, int PostnaStevilka)
            {
                this.Ulica = Ulica;
                this.hisnaStevilka = hisnaStevilka;
                this.Postnastevilka = PostnaStevilka;
            }
        }

        static void Main(string[] args)
        {
            Oseba Oseba1 = new Oseba();
            Oseba Oseba2 = new Oseba("Primož", "Ratej");
            Oseba Oseba3 = new Oseba("Jan", "Polok");

            Vozilo vozilo1 = new Vozilo();
            Vozilo vozilo2 = new Vozilo("Ford", "Karavan");
            Vozilo vozilo3 = new Vozilo("Ferrari", "Limuzina");

            vozilo1.voznik = Oseba1;
            vozilo2.voznik = Oseba2;
            vozilo3.voznik = Oseba3;






            Oseba1.ime = "Janez";
            Oseba1.priimek = "Novak";

            vozilo2.znamka = "Nissan";
            vozilo2.tip = "Sport";

            Oseba oseba4 = new Oseba("Jan", "Horvat");
            vozilo3.voznik = oseba4;

            vozilo3.Izpis();
            //vozilo2.Izpis();


            Console.ReadKey();

        }
    }
}
