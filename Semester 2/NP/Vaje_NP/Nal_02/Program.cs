using System;

namespace Nal_02
{
    class Program
    {
        public class Vozilo
        {
            Oseba voznik;
            string znamka;
            string tip;
            double porabaGorivaNa100km;
            double velikostRezervarja;

            public Oseba _voznik
            {
                get { return voznik; }
                set { voznik = value; }
            }
            public string _znamka
            {
                get { return znamka; }
                set { znamka = value; }
            }
            public string _tip
            {
                get { return tip; }
                set { tip = value; }
            }
            public double _porabaGorivaNa100km
            {
                get { return porabaGorivaNa100km; }
                set { porabaGorivaNa100km = value; }
            }
            public double _velikostRezervarja
            {
                get { return velikostRezervarja; }
                set { velikostRezervarja = value; }
            }

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
                voznik = new Oseba("Jan", "Rozman");
                this.znamka = znamka;
                this.tip = tip;
            }



            public Vozilo(Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
                : this()
            {
                this.voznik = voznik;
                this.porabaGorivaNa100km = porabaGorivaNa100km;
                this.velikostRezervarja = velikostRezervarja;
            }

            public void ZamenjajVoznika(Oseba oseba)
            {
                this.voznik = oseba;
            }

            public double kolicinaPorabljenegaGoriva(double dolzinaPoti)
            {
                double poraba = 0;
                poraba = (dolzinaPoti / 100) * porabaGorivaNa100km;
                return poraba;
            }

            public double kolicinaPorabljenegaGoriva(double časPotovanjaVurah, double povprecnaHitrost)
            {
                double dolzinaPoti = časPotovanjaVurah * povprecnaHitrost;
                return kolicinaPorabljenegaGoriva(dolzinaPoti);

            }

            public double kolicinaPorabljenegaGoriva(DateTime časPrihoda, DateTime časOdhoda, double povprecnaHitrost)
            {
                double časPotovanja = (časPrihoda - časOdhoda).Hours;
                return kolicinaPorabljenegaGoriva(časPotovanja, povprecnaHitrost);
            }

            public void Izpis()
            {
                Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}", znamka, tip, porabaGorivaNa100km, velikostRezervarja);
            }

        }

        public class Oseba
        {
            string ime;
            string priimek;
            char spol;
            DateTime datumRojstva;

            public string _ime
            {
                get { return ime; }
                set { ime = value; }
            }

            public string _priimek
            {
                get { return priimek; }
                set { priimek = value; }
            }

            public char _spol
            {
                get { return spol; }
                set { spol = value; }
            }

            public DateTime _datumRojstva
            {
                get { return datumRojstva; }
                set { datumRojstva = value; }
            }


            public Oseba()
            {

                ime = "Ne";
                priimek = "Ne";
                spol = 'X';
                datumRojstva = new DateTime(1584, 1, 1);


            }

            public Oseba(string ime, string priimek, char spol, DateTime datumRojstva)
            : this(ime, priimek)
            {
                this.spol = spol;
                this.datumRojstva = datumRojstva;

            }

            public Oseba(string ime, string priimek)
            {

                this.ime = ime;
                this.priimek = priimek;
            }

            public void Izpis()
            {
                Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3}", ime, priimek, spol, datumRojstva);

            }
        }


        public static void Izpis(Vozilo vozilo, Oseba oseba)
        {
            Console.WriteLine("---------Osebni podatki voznika--------");
            oseba.Izpis();
            Console.WriteLine("-------------podatki vozila------------");
            vozilo.Izpis();

        }


        static void Main(string[] args)
        {

            DateTime datum1 = new DateTime(1996, 9, 1);
            Oseba oseba1 = new Oseba("Primož", "Ratej Cvahte", 'M', datum1);
            Vozilo vozilo1 = new Vozilo(oseba1, "WolsVangen", "Polo", 6.7, 40.5);

            Oseba oseba2 = new Oseba();

            vozilo1.ZamenjajVoznika(oseba2);

            DateTime prihod = new DateTime(1996, 9, 1, 20, 00, 00);
            DateTime odhod = new DateTime(1996, 9, 1, 15, 00, 00);


            Izpis(vozilo1, oseba1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("prihod odhod povprecna hitrost");
            Console.WriteLine(vozilo1.kolicinaPorabljenegaGoriva(prihod, odhod, 100));
            Console.WriteLine();
            Console.WriteLine("čas potovanja v urah, povprečna hitrost");
            Console.WriteLine(vozilo1.kolicinaPorabljenegaGoriva(5, 100));
            Console.WriteLine();
            Console.WriteLine("dolžina poti");
            Console.WriteLine(vozilo1.kolicinaPorabljenegaGoriva(500));
            Console.ReadKey();
        }
    }
}
