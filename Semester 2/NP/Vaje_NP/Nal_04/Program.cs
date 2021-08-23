using System;

namespace Nal_04
{
    class Program
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

        public class Avtomobil : Vozilo
        {

            int številoSedežev;
            int številoPotnikov;

            public Avtomobil()
            {
                številoSedežev = 0;
                številoPotnikov = 0;
            }

            public Avtomobil(int številoSedežev, int številoPotnikov, Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
                : base(voznik, znamka, tip, porabaGorivaNa100km, velikostRezervarja)
            {
                this.številoPotnikov = številoPotnikov;
                this.številoSedežev = številoSedežev;
            }
            public override void Izpis()
            {
                Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}\nštevilo sedežev: {4}\nštevilo potnikov: {5}", _znamka, _tip, _porabaGorivaNa100km, _velikostRezervarja, številoSedežev, številoPotnikov);
            }

            public override double zasedenostVozila()
            {
                double procentZasedenosti = številoSedežev / številoPotnikov * 100;
                return procentZasedenosti;
            }



        }

        public class Kombi : Vozilo
        {
            double masaNaloženegaTovora;
            double maksimalnaMasaTovora;

            public Kombi()
            {
                masaNaloženegaTovora = 0;
                maksimalnaMasaTovora = 0;
            }

            public Kombi(double masaNaloženegaTovora, double maksimalnaMasaTovora, Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
                : base(voznik, znamka, tip, porabaGorivaNa100km, velikostRezervarja)
            {
                this.masaNaloženegaTovora = masaNaloženegaTovora;
                this.maksimalnaMasaTovora = maksimalnaMasaTovora;
            }

            public override void Izpis()
            {
                Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}\nmasa naloženega tovora: {4}\nmaksimalna masa tovora: {5}", _znamka, _tip, _porabaGorivaNa100km, _velikostRezervarja, masaNaloženegaTovora, maksimalnaMasaTovora);
            }

            public override double zasedenostVozila()
            {
                double procentZasedenosti = maksimalnaMasaTovora / masaNaloženegaTovora * 100;
                return procentZasedenosti;
            }
        }

        public class Avtobus : Vozilo
        {
            int skupnoŠteviloSedežev;
            int skupnoŠteviloStojišč;
            int številoPotnikovNaAvtobusu;

            public Avtobus()
            {
                skupnoŠteviloSedežev = 0;
                skupnoŠteviloStojišč = 0;
                številoPotnikovNaAvtobusu = 0;
            }

            public int _maxŠteviloPotnikov()
            {
                return skupnoŠteviloSedežev + skupnoŠteviloStojišč;
            }

            public Avtobus(int številoPotnikovNaAvtobusu)
            {
                this.številoPotnikovNaAvtobusu = številoPotnikovNaAvtobusu;
            }

            public int _skupnoŠteviloSedežev { get { return skupnoŠteviloSedežev; } set { skupnoŠteviloSedežev = value; } }
            public int _skupnoŠteviloStojišč { get { return _skupnoŠteviloStojišč; } set { skupnoŠteviloStojišč = value; } }
            public int _številoPotnikovNaAvtobusu { get { return številoPotnikovNaAvtobusu; } set { številoPotnikovNaAvtobusu = value; } }

            public Avtobus(int skupnoŠteviloSedežev, int skupnoŠteviloStojišč, int številoPotnikovNaAvtobusu, Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
                : base(voznik, znamka, tip, porabaGorivaNa100km, velikostRezervarja)
            {
                this.skupnoŠteviloSedežev = skupnoŠteviloSedežev;
                this.številoPotnikovNaAvtobusu = številoPotnikovNaAvtobusu;
                this.skupnoŠteviloStojišč = skupnoŠteviloStojišč;
            }

            public Avtobus(int skupnoŠteviloSedežev, int skupnoŠteviloStojišč, Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
                : base(voznik, znamka, tip, porabaGorivaNa100km, velikostRezervarja)
            {
                this.skupnoŠteviloSedežev = skupnoŠteviloSedežev;
                this.skupnoŠteviloStojišč = skupnoŠteviloStojišč;
            }

            public override void Izpis()
            {
                Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}\nskupno Število Sedežev: {4}\nskupno Število Stojišč: {5} \nštevilo Potnikov Na Avtobusu: {6}", _znamka, _tip, _porabaGorivaNa100km, _velikostRezervarja, skupnoŠteviloSedežev, skupnoŠteviloStojišč, številoPotnikovNaAvtobusu);
            }

            public override double zasedenostVozila()
            {
                double zasedenostVozila = (skupnoŠteviloStojišč + skupnoŠteviloSedežev) / številoPotnikovNaAvtobusu * 100;
                return zasedenostVozila;
            }
        }

        public class Oseba
        {

            Spol spol;
            string ime;
            string priimek;
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

            public Spol _spol
            {
                get { return spol; }
                set { spol = value; }
            }

            public DateTime _datumRojstva
            {
                get { return datumRojstva; }
                set { datumRojstva = value; }
            }

            public override bool Equals(Object p1)
            {
                Oseba a = p1 as Oseba;
                if ((ime == a.ime) && (priimek == a.priimek)) return true;
                return false;
            }

            public Oseba()
            {

                ime = "Ne";
                priimek = "Ne";
                spol = Spol.N_A;
                datumRojstva = new DateTime(1584, 1, 1);


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

            public virtual void Izpis()
            {
                Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3}", ime, priimek, spol, datumRojstva);

            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        public class Voznik : Oseba
        {
            DateTime datumVeljavnostiVozniškegaDovoljenja;

            public DateTime _datumVeljavnostiVozniškegaDovoljenja
            {
                get { return datumVeljavnostiVozniškegaDovoljenja; }
                set { datumVeljavnostiVozniškegaDovoljenja = value; }
            }


            public Voznik()
                : base()
            {
                datumVeljavnostiVozniškegaDovoljenja = new DateTime(1000, 1, 1);
            }

            public Voznik(string ime, string priimek, Spol spol, DateTime datumRojstva, DateTime datumVeljavnostiVozniskegaDovoljenja)
                : base(ime, priimek, spol, datumRojstva)
            {
                this.datumVeljavnostiVozniškegaDovoljenja = datumVeljavnostiVozniskegaDovoljenja;
            }

            public override void Izpis()
            {
                Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3}\nDatum veljavnosti vozniskega dovoljenja: {3}", _ime, _priimek, _spol, _datumRojstva, _datumVeljavnostiVozniškegaDovoljenja);
            }
        }

        public class Potnik : Oseba
        {
            string email;
            Status status;



            public string _email
            {
                get { return email; }
                set { email = value; }
            }

            public Status _status
            {
                get { return status; }
                set { if (email.Contains("@")) status = value; }
            }

            public Potnik()
                : base()
            {
                email = "something@something.com";
                status = Status.N_A;
            }

            public Potnik(string ime, string priimek, Spol spol, DateTime datumRojstva, string email, Status status)
                : base(ime, priimek, spol, datumRojstva)
            {
                this.email = email;
                this.status = status;
            }

            public override sealed void Izpis()
            {
                Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3}\nEmail: {3} \nStatus: {3}", _ime, _priimek, _spol, _datumRojstva, email, status);
            }
            public void SpremembaStatusa(Status status)
            {
                this.status = status;
            }




        }


        class Termin
        {
            public DateTime časOdhoda;
            DateTime časPrihoda;
            Avtobus dodeljenAvtobus;
            static int maxŠtPotnikov;
            int številoPotnikov;
            public Potnik[] seznamPotnikov;

            private Termin() { }
            public Termin(DateTime časOdhoda, DateTime časPrihoda, Avtobus dodeljenAvtobus)
            {
                this.časOdhoda = časOdhoda;
                this.časPrihoda = časPrihoda;
                this.dodeljenAvtobus = dodeljenAvtobus;
                seznamPotnikov = new Potnik[dodeljenAvtobus._maxŠteviloPotnikov()];

            }


            public int _maxŠteviloPotnikov
            {
                get { return maxŠtPotnikov; }
                set { maxŠtPotnikov = dodeljenAvtobus._skupnoŠteviloSedežev + dodeljenAvtobus._skupnoŠteviloStojišč; }

            }

            public int _stPotnikov
            {
                get { return številoPotnikov; }
                set { številoPotnikov = value; }
            }





        }


        class Izlet : Iprodajni
        {
            string naziv;
            double cenaIzleta;
            string krajOdhoda;
            Termin[] termini;

            public Termin[] _termini
            {
                get { return termini; }
                set { termini = value; }
            }

            public Izlet(string naziv, double cenaIzleta, string krajOdhoda, Termin[] termini)
            {
                this.naziv = naziv;
                this.cenaIzleta = cenaIzleta;
                this.krajOdhoda = krajOdhoda;
                this.termini = termini;
            }


            public void ProdajKarto(Termin termin, Potnik potnik)
            {
                for (int i = 0; i < termini.Length; i++)
                {
                    if (termini[i] == termin)
                    {
                        for (int j = 0; j < termini[i].seznamPotnikov.Length; j++)
                        {
                            if (termini[i].seznamPotnikov[j] == null)
                            {
                                termini[i].seznamPotnikov[j] = potnik;
                                termini[i]._stPotnikov++;
                                return;
                            }
                        }

                    }
                }
            }

            public void PrekličiKarto(Termin termin, Potnik potnik)
            {

                for (int i = 0; i < termini.Length; i++)
                {
                    if (termini[i] == termin)
                    {
                        if (termini[i]._stPotnikov == 0) break;
                        for (int j = 0; j < termini[i].seznamPotnikov.Length; j++)
                        {
                            if (termini[i].seznamPotnikov[j] == potnik)
                            {
                                termini[i].seznamPotnikov[j] = null;
                                termini[i]._stPotnikov--;
                                return;
                            }
                        }

                    }
                }
            }

            public bool MestoProsto(Termin termin)
            {
                for (int i = 0; i < termini.Length; i++)
                {
                    if (termini[i] == null)
                    {
                        return true;
                    }
                }
                return false;
            }

            public double IzračunajCeno(Potnik potnik)
            {
                if (potnik._status == Status.Študent)
                    return cenaIzleta * 0.85;
                if (potnik._status == Status.Upokojenec)
                    return cenaIzleta * 0.90;
                return cenaIzleta;
            }

        }

        interface Iprodajni
        {
            void ProdajKarto(Termin termin, Potnik potnik);//Doda potnika na seznam prijavljenih potnikov
            void PrekličiKarto(Termin termin, Potnik potnik);//ki odstrani potnika iz seznama prijavljenih izletnikov.
            bool MestoProsto(Termin termin); //preveri, če je na avtobusu še kakšno prosto mesto.
            double IzračunajCeno(Potnik potnik);// izračuna ceno izleta za posameznega potnika. Upoštevajte, da imajo pri nakupu karte upokojenci 10% popust, študenti pa 15% popust.
        }

        interface IPotnik
        {
            void SpremembaStatusa(Status status);
        }



        public static void Izpis(Vozilo vozilo, Oseba oseba)
        {
            Console.WriteLine("---------Osebni podatki voznika--------");
            oseba.Izpis();
            Console.WriteLine("-------------podatki vozila------------");
            vozilo.Izpis();

        }

        static void kolikoTerminovJeProstih(Izlet izlet)
        {
            int količinaProstora = 0;
            for (int i = 0; i < izlet._termini.Length; i++)
            {
                if (izlet._termini[i] == null) continue;
                Console.WriteLine("Za termin: {0}", izlet._termini[i].časOdhoda);
                for (int j = 0; j < izlet._termini[i].seznamPotnikov.Length; j++)
                {
                    if (izlet._termini[i].seznamPotnikov[j] == null) količinaProstora++;
                }
                Console.Write(" je na razpolago {0} prostora.", količinaProstora);
            }
        }

        static void Main(string[] args)
        {

            DateTime datumRojstva = new DateTime(1996, 9, 1);
            DateTime časOdhoda = new DateTime(2016, 4, 11);
            DateTime časPrihoda = new DateTime(2016, 4, 22);
            Voznik voznik = new Voznik("Primož", "Ratej", Spol.Moški, datumRojstva, časPrihoda);


            Avtobus avtobus0 = new Avtobus(45, 15, voznik, "MAN", "Velik avtobus", 25, 800);

            Avtobus[] seznamAvtobusov = new Avtobus[10];

            seznamAvtobusov[0] = avtobus0;

            avtobus0.Izpis();
            Potnik potnik0 = new Potnik("Primož", "Ratej", Spol.Moški, datumRojstva, "primozratej@student.um.si", Status.Študent);
            Potnik potnik1 = new Potnik("Teja", "Bincl", Spol.Ženska, datumRojstva, "tejabincl@student.um.si", Status.Otrok);
            Potnik potnik2 = new Potnik("Patrik", "Šplajt", Spol.Moški, datumRojstva, "patrikšplajt@student.um.si", Status.Upokojenec);
            Potnik potnik3 = new Potnik("Tadej", "Leva", Spol.Moški, datumRojstva, "tadejleva@student.um.si", Status.Študent);

            Termin termin1 = new Termin(časOdhoda, časPrihoda, avtobus0);

            Termin[] poljeTerminov = new Termin[3];
            poljeTerminov[0] = termin1;

            Izlet izlet1 = new Izlet("Grčija", 100, "Celje planet tuš", poljeTerminov);

            izlet1.ProdajKarto(termin1, potnik0);
            izlet1.ProdajKarto(termin1, potnik1);
            izlet1.ProdajKarto(termin1, potnik2);
            izlet1.ProdajKarto(termin1, potnik3);


            //Console.WriteLine(izlet1.MestoProsto(termin1));
            izlet1.PrekličiKarto(termin1, potnik1);
            //Console.WriteLine(izlet1.MestoProsto(termin1));



            kolikoTerminovJeProstih(izlet1);







            Console.ReadKey();
        }
    }
}
