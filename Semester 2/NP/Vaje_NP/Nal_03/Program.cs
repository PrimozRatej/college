using System;

namespace Nal_03
{
    public enum Spol { Moški, Ženska };
    public enum Status { student, otrok, upokojenec };
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
            : this(znamka, tip)
        {
            this.voznik = voznik;
            this.porabaGorivaNa100km = porabaGorivaNa100km;
            this.velikostRezervarja = velikostRezervarja;
        }

        public double kolicinaPorabljenegaGoriva(double dolzinaPoti)
        {
            double poraba = 0;
            poraba = (dolzinaPoti / 100) * porabaGorivaNa100km;
            return poraba;
        }

        public double kolicinaPorabljenegaGoriva(double časPotovanja, double povprecnaHitrost)
        {
            double dolzinaPoti = časPotovanja * povprecnaHitrost;
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

    public class Voznik : Oseba
    {
        DateTime datumVeljavnostiVozniškegaDovoljenja;

        public DateTime DatumVeljavnostiVozniškegaDovoljenja
        {
            get { return datumVeljavnostiVozniškegaDovoljenja; }
            set { datumVeljavnostiVozniškegaDovoljenja = value; }
        }
        public Voznik()
            : base()
        {
            this.DatumVeljavnostiVozniškegaDovoljenja = new DateTime();
        }


    }

    public class Potnik : Oseba
    {
        string email;
        Status status;

        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        public Potnik()
            : base()
        {
            email = "someone@provider.domain";
            status = Status.student;

        }

        public new void Izpis()
        {
            base.Izpis();
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Status: " + status);
        }

    }

    public class Oseba
    {
        string ime;
        string priimek;
        DateTime datumRojstva;
        Spol spol;


        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Priimek
        {
            get { return priimek; }
            set { priimek = value; }
        }

        public Spol Spol
        {
            get { return spol; }
            set { spol = value; }
        }

        public DateTime DatumRojstva
        {
            get { return datumRojstva; }
            set { datumRojstva = value; }
        }


        public Oseba()
        {

            ime = "Ne";
            priimek = "Ne";
            datumRojstva = new DateTime(1584, 1, 1);
            spol = Spol.Moški;
        }

        public Oseba(string ime, string priimek, Spol spol, DateTime datumRojstva)
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
            Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3}", ime, priimek, Spol, datumRojstva);

        }
    }



    class Program
    {

        static void Main(string[] args)
        {

            DateTime datum1 = new DateTime(1996, 9, 1);
            Potnik oseba1 = new Potnik();
            oseba1.Ime = "Primož";
            oseba1.Priimek = "Ratej Cvahte";
            oseba1.Spol = Spol.Moški;
            oseba1.Status = Status.student;
            oseba1.DatumRojstva = datum1;
            oseba1.Email = "primoz.ratej@student.um.si";

            Vozilo vozilo1 = new Vozilo(oseba1, "WolsVangen", "Polo", 6.7, 40.5);

            DateTime prihod = new DateTime(1996, 9, 1, 18, 00, 00);
            DateTime odhod = new DateTime(1996, 9, 1, 15, 00, 00);

            oseba1.Izpis();

            Console.ReadKey();

        }
    }
}
