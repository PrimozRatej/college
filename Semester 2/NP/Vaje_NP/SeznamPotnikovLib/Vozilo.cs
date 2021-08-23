using System;

namespace Pot_Lib
{
    public enum Status
    {
        Otrok,
        Študent,
        Upokojenec,
        N_A
    }
    public enum Spol
    {
        Moški, Ženska, N_A
    }
    public abstract class Vozilo
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

        public virtual void Izpis()
        {
            Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}", znamka, tip, porabaGorivaNa100km, velikostRezervarja);
        }

        public abstract double zasedenostVozila();


    }
}
