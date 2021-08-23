using System;
using System;
using System.Collections.Generic;

namespace Nal_03
{
    //uporabljene knjižnice
    public class Potnik
    {
        private string ime;
        private string priimek;
        private uint starost;
        private string davcnaSt; //se uporabi kot ID

        // Konstruktor
        public Potnik(string ime, string priimek, uint starost, string davcnaSt)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.starost = starost;
            this.davcnaSt = davcnaSt;
        }

        // Lastnosti
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

        public uint Starost
        {
            get { return starost; }
            set { starost = value; }
        }

        public string DavcnaSt
        {
            get { return davcnaSt; }
            set { davcnaSt = value; }
        }

    }

    public enum PotniskiRazred
    {
        EKONOMSKI,
        POSLOVNI
    }

    public class Kovcek
    {
        private int idKovcek;

        // Konstruktor
        public Kovcek(int id)
        {
            this.idKovcek = id;
        }

        // Lastnosti
        public int IDKovcek
        {
            get { return idKovcek; }
            set { idKovcek = value; }
        }

    }

    public class KartaZaVkrcavanje
    {
        private Potnik potnik;
        private PotniskiRazred razredSedeza;
        private Kovcek kovcek;

        // Konstruktor
        public KartaZaVkrcavanje(Potnik potnik, PotniskiRazred pr, Kovcek kovcek)
        {
            this.potnik = potnik;
            this.razredSedeza = pr;
            this.kovcek = kovcek;
        }
        // Lastnosti
        public Potnik Potnik
        {
            get { return potnik; }
            set { potnik = value; }
        }
        public PotniskiRazred RazredSedeza
        {
            get { return razredSedeza; }
            set { razredSedeza = value; }
        }
        public Kovcek Kovcek
        {
            get { return kovcek; }
            set { kovcek = value; }
        }
    }

    public class TovornoLetalo
    {
        private int id;	//identifikacijska stevilka letala
        public Stack<Stack<Kovcek>> prtljaznik;	//sklad skladov kovckov na letalu = prtljaga vseh potnikov
        private uint maxSteviloKovckovNaKupu;	//maksimalno stevilo kovckov na enem kupu v prtljazniku

        // Konstruktor
        public TovornoLetalo(int id, uint maxSteviloKovckovNaKupu)
        {
            this.id = id;
            prtljaznik = new Stack<Stack<Kovcek>>();
            this.maxSteviloKovckovNaKupu = maxSteviloKovckovNaKupu;
        }

        // Lastnosti 
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public uint MaxSteviloKovckovNaKupu
        {
            get { return maxSteviloKovckovNaKupu; }
            set { maxSteviloKovckovNaKupu = value; }
        }

        //ostale metode
        public void naloziKovcke(Queue<Kovcek> kovcki)
        {
            if (kovcki == null) return;
            Stack<Kovcek> vmesniSklad = new Stack<Kovcek>();
            int stevec = 0;
            int konec = 0;
            foreach (var x in kovcki)
            {
                vmesniSklad.Push(x);
                stevec++;
                konec++;
                if (stevec == maxSteviloKovckovNaKupu)
                {
                    prtljaznik.Push(vmesniSklad);
                    vmesniSklad = new Stack<Kovcek>();
                    stevec = 0;
                }
                if (konec == kovcki.Count && vmesniSklad.Count != 0)
                {
                    prtljaznik.Push(vmesniSklad);
                }

            }
            kovcki.Clear();
        }


        public Queue<Kovcek> razloziKovcke()
        {
            if (prtljaznik == null) return null;
            Queue<Kovcek> vmesnaVrsta = new Queue<Kovcek>();

            foreach (var x in prtljaznik)
            {
                foreach (var y in x)
                {
                    vmesnaVrsta.Enqueue(y);
                }
            }
            prtljaznik.Clear();
            return vmesnaVrsta;
        }
    }

    public class LetalskaDruzba
    {
        public Queue<KartaZaVkrcavanje> cakajociNaVkrcanje;	// vrsta prijavljenih potnikov, ki cakajo na vkrcanje
        public Queue<Kovcek> razlozeniKovcki;   // vrsta kovckov

        // Konstruktor
        public LetalskaDruzba()
        {
            cakajociNaVkrcanje = new Queue<KartaZaVkrcavanje>();
            razlozeniKovcki = new Queue<Kovcek>();
        }

        //ostale metode
        public void razdeli(Queue<KartaZaVkrcavanje> potniki, Queue<KartaZaVkrcavanje> sedeci_poslovni, Queue<KartaZaVkrcavanje> sedeci_ekonomski)
        {
            if (potniki.Count == 0 || potniki == null || sedeci_poslovni == null || sedeci_ekonomski == null) return;
            foreach (var potnik in potniki)
            {
                if (potnik.RazredSedeza == PotniskiRazred.EKONOMSKI)
                    sedeci_ekonomski.Enqueue(potnik);
                if (potnik.RazredSedeza == PotniskiRazred.POSLOVNI)
                    sedeci_poslovni.Enqueue(potnik);
            }
            potniki.Clear();
        }

        public Queue<KartaZaVkrcavanje> zdruzi(Queue<KartaZaVkrcavanje> sedeci_poslovni, Queue<KartaZaVkrcavanje> sedeci_ekonomski)
        {

            Queue<KartaZaVkrcavanje> a = new Queue<KartaZaVkrcavanje>();
            if (sedeci_ekonomski == null || sedeci_poslovni == null) return a;
            foreach (var x in sedeci_poslovni)
                a.Enqueue(x);
            foreach (var y in sedeci_ekonomski)
                a.Enqueue(y);

            sedeci_ekonomski.Clear();
            sedeci_poslovni.Clear();
            return a;
        }

        public Queue<KartaZaVkrcavanje> uredi(Queue<KartaZaVkrcavanje> cakalnaVrsta)
        {
            Queue<KartaZaVkrcavanje> sedeci_poslovni = new Queue<KartaZaVkrcavanje>();
            Queue<KartaZaVkrcavanje> sedeci_ekonomski = new Queue<KartaZaVkrcavanje>();

            razdeli(cakalnaVrsta,
                    sedeci_poslovni,
                    sedeci_ekonomski);

            return zdruzi(sedeci_poslovni,
                        sedeci_ekonomski);
        }


        public void opravilaPriLetu(Queue<KartaZaVkrcavanje> prijavljeniPotniki, Queue<Kovcek> prijavljeniKovcki, TovornoLetalo lt)
        {
            if (cakajociNaVkrcanje.Count != 0)
                cakajociNaVkrcanje.Clear();

            if (razlozeniKovcki.Count != 0)
                razlozeniKovcki.Clear();

            cakajociNaVkrcanje = uredi(prijavljeniPotniki);

            lt.naloziKovcke(prijavljeniKovcki);

            razlozeniKovcki = lt.razloziKovcke();
        }
    }

    public class mainClass
    {
        //proste metode v imenskem prostoru
        //prostor za lastno implementirane metode

        private static bool test_zdruzi_izkljucno_v_ekonomskem_razredu(string opis_scenarija, string ime_testirane_metode)
        {
            bool uspesno = true;

            Queue<KartaZaVkrcavanje> ekonomski = new Queue<KartaZaVkrcavanje>();
            int kovcek_id = 0;
            Potnik pt1 = new Potnik("Janez", "Kranjski", 25, "11111111");
            PotniskiRazred pr1 = PotniskiRazred.EKONOMSKI;
            Kovcek k1 = new Kovcek(kovcek_id++);
            KartaZaVkrcavanje kzv1 = new KartaZaVkrcavanje(pt1, pr1, k1);
            ekonomski.Enqueue(kzv1);

            Potnik pt2 = new Potnik("Janez", "Novak", 17, "11111112");
            PotniskiRazred pr2 = PotniskiRazred.EKONOMSKI;
            Kovcek k2 = new Kovcek(kovcek_id++);
            KartaZaVkrcavanje kzv2 = new KartaZaVkrcavanje(pt2, pr2, k2);
            ekonomski.Enqueue(kzv2);

            Potnik pt3 = new Potnik("Marija", "Testna", 18, "11111113");
            PotniskiRazred pr3 = PotniskiRazred.EKONOMSKI;
            Kovcek k3 = new Kovcek(kovcek_id++);
            KartaZaVkrcavanje kzv3 = new KartaZaVkrcavanje(pt3, pr3, k3);
            ekonomski.Enqueue(kzv3);

            Potnik pt4 = new Potnik("Marija", "Fran", 45, "11111114");
            PotniskiRazred pr4 = PotniskiRazred.EKONOMSKI;
            Kovcek k4 = new Kovcek(kovcek_id++);
            KartaZaVkrcavanje kzv4 = new KartaZaVkrcavanje(pt4, pr4, k4);
            ekonomski.Enqueue(kzv4);

            Queue<KartaZaVkrcavanje> poslovni = new Queue<KartaZaVkrcavanje>();


            Queue<KartaZaVkrcavanje> pricakovanoZdruzeni = new Queue<KartaZaVkrcavanje>(ekonomski);


            LetalskaDruzba ld = new LetalskaDruzba();
            Queue<KartaZaVkrcavanje> dejanskoZdruzeni = ld.zdruzi(poslovni, ekonomski);

            if (pricakovanoZdruzeni.Count != dejanskoZdruzeni.Count)
            {
                Console.Write("V testnem scenariju" + " \'"
                    + "{0}" + "\' "
                    + ": Metoda" + " \'"
                    + "{1}" + "\' "
                    + "ni napolnila izhodne vrste zdruzenih potnikov s pricakovanim stevilom potnikov ("
                    + "{2}" + "), pac pa jo je napolnila s/z "
                    + "{3}" + " potniki.",
                    opis_scenarija,
                    ime_testirane_metode,
                    pricakovanoZdruzeni.Count,
                    dejanskoZdruzeni.Count
                );

                uspesno = false;
            }

            while (pricakovanoZdruzeni.Count != 0 && dejanskoZdruzeni.Count != 0)
            {
                KartaZaVkrcavanje dejanska = dejanskoZdruzeni.Dequeue();
                KartaZaVkrcavanje pricakovana = pricakovanoZdruzeni.Dequeue();

                //if (pricakovana != dejanska) {
                Potnik pricakovanP = pricakovana.Potnik;
                Potnik dejanskiP = dejanska.Potnik;
                PotniskiRazred pricakovanPR = pricakovana.RazredSedeza;
                PotniskiRazred dejanskiPR = dejanska.RazredSedeza;
                Kovcek pricakovanK = pricakovana.Kovcek;
                Kovcek dejanskiK = dejanska.Kovcek;
                if (pricakovanP.DavcnaSt != dejanskiP.DavcnaSt
                    || pricakovanP.Starost != dejanskiP.Starost
                    || pricakovanP.Priimek != dejanskiP.Priimek
                    || pricakovanP.Ime != dejanskiP.Ime
                    || pricakovanPR != dejanskiPR
                    || pricakovanK.IDKovcek != dejanskiK.IDKovcek)
                {
                    string razlaga = "ni napolnila izhodne vrste zdruzenih potnikov z enakimi potniki, kot so bili podani.";
                    Console.Write("V testnem scenariju" + " \'"
                        + "{0}" + "\' " + ": Metoda" + " \'"
                        + "{1}" + "\' "
                        + "{2}",
                        opis_scenarija,
                        ime_testirane_metode,
                        razlaga
                    );
                    uspesno = false;
                    break;
                }
            }

            return uspesno;
        }

        public static void Main(string[] args)
        {
            //=== ZACETEK DEMONSTRACIJE DELOVANJA ===
            //za generiranje nakljucnih stevil
            Random rand = new Random();
            // vsak potnik v seznamu mora imeti unikatno davcno stevilko!
            Potnik pt1 = new Potnik("Janez", "Kranjski", 25, "12345678");
            Potnik pt2 = new Potnik("Tomislav", "Vizinski", 23, "87654321");
            Potnik pt3 = new Potnik("Marija", "Okrep", 24, "45278964");

            LinkedList<Potnik> seznamPotnikov = new LinkedList<Potnik>();
            seznamPotnikov.AddLast(pt1);
            seznamPotnikov.AddLast(pt2);
            seznamPotnikov.AddLast(pt3);

            Queue<Kovcek> prijavljenaPrtljaga = new Queue<Kovcek>();
            Queue<KartaZaVkrcavanje> prijavljeniPotniki = new Queue<KartaZaVkrcavanje>();

            int idKovcka = 0;
            while (seznamPotnikov.Count != 0)
            {
                Kovcek kc = new Kovcek(idKovcka++);
                prijavljenaPrtljaga.Enqueue(kc);

                PotniskiRazred pr = PotniskiRazred.EKONOMSKI;
                if (rand.Next(0, 5) == 0)
                    pr = PotniskiRazred.POSLOVNI;

                KartaZaVkrcavanje kzv = new KartaZaVkrcavanje(seznamPotnikov.First.Value, pr, kc);
                seznamPotnikov.RemoveFirst();

                prijavljeniPotniki.Enqueue(kzv);
            }

            TovornoLetalo tl = new TovornoLetalo(0, 1);
            LetalskaDruzba ld = new LetalskaDruzba();
            // vsak potnik v seznamu mora imeti unikatno davcno stevilko!
            ld.opravilaPriLetu(prijavljeniPotniki, prijavljenaPrtljaga, tl);

            //=== KONEC DEMONSTRACIJE DELOVANJA ===

            //TESTNI SCENARIJ
            Console.WriteLine("--- zacetek testiranja ---");
            bool uspesno = true;

            uspesno = test_zdruzi_izkljucno_v_ekonomskem_razredu(
                "Zdruzi vrsti s potniki izkljucno v ekonomskem razredu",
                "Queue<KartaZaVkrcavanje> zdruzi(Queue<KartaZaVkrcavanje> sedeci_poslovni, Queue<KartaZaVkrcavanje> sedeci_ekonomski)"
            );

            Console.WriteLine();
            //POVZETEK
            string uspesnost = "JE";
            if (!uspesno)
                uspesnost = "ni";
            Console.WriteLine("Povzetek: Program " + "{0}"
                + " uspesno prestal testiranje.",
                uspesnost
            );
            Console.WriteLine("--- konec testiranja ---");
        }


    }
}
