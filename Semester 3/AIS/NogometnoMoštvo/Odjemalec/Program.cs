using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using Odjemalec.servis;



namespace Odjemalec
{

    class Program
    {
        public static void DodajTransakcijo(WebServiceMoj service)
        {
            Račun rač = null;
            try
            {
                Console.WriteLine("Vpiši davčno številko komitenta");
                string davcna = Console.ReadLine();
                Console.WriteLine("Vpiši ID računa tega komitenta");
                int idRač = int.Parse(Console.ReadLine());
                rač = service.RačunPridobi(service.komitent(davcna), idRač);
                if (rač == null) throw new Exception();
            }
            catch
            {
                Console.WriteLine("Napaka pri pridobitvi računa");
                return;
            }

            Console.WriteLine("Vnesi znesek transakcije: ");
            double znesek = double.Parse(Console.ReadLine());

            Console.Write("leto rojstva: ");
            int leto = int.Parse(Console.ReadLine());
            Console.Write("mesec rojstva: ");
            int mesec = int.Parse(Console.ReadLine());
            Console.Write("dan rojstva: ");
            int dan = int.Parse(Console.ReadLine());
            try
            {
                Transakcija tra = new Transakcija();
                tra.znesek = znesek;
                tra.račun = rač;
                tra.datumTransakcije = new DateTime(leto, mesec, dan);
                
                service.TransakcijaShrani(tra);
            }
            catch
            {
                Console.WriteLine("Napaka pri transakciji");
            }


        }

        public static void DodajKomitenta(WebServiceMoj service)
        {
            try
            {
            Console.Write("Ime: ");
            string ime = Console.ReadLine();
            Console.Write("Priimek: ");
            string priimek = Console.ReadLine();
            Console.Write("Davčna številka: ");
            string davčna = Console.ReadLine();
            Console.Write("leto rojstva: ");
            int leto = int.Parse(Console.ReadLine());
            Console.Write("mesec rojstva: ");
            int mesec = int.Parse(Console.ReadLine());
            Console.Write("dan rojstva: ");
            int dan = int.Parse(Console.ReadLine());
            Komitent kom = new Komitent() { Ime = ime, Priimek = priimek, DavcnaStevilka = davčna, DatumRojstva = new DateTime(leto, mesec, dan) };
            service.KomitentShrani(kom);
            }
            catch
            { Console.WriteLine("Napačen vnos"); }
            
        }

        public static void DodajRačun(WebServiceMoj service)
        {
            Console.WriteLine("Vnesi lastnika z davčno");
            string davcna = Console.ReadLine();
            Komitent komitent = service.komitent(davcna);
            if (komitent == null)
            {
                Console.WriteLine("Ni takšnega komitenta!");
                return;
            }
            Console.WriteLine("Vnesi limit");
            double limit = double.Parse(Console.ReadLine());
            Console.WriteLine("Ali je blokiran DA/NE");
            bool blokiran = false;
            if (Console.ReadLine() == "DA") blokiran = true;
            Console.WriteLine("Vnesi Banko: ");
            string banka = Console.ReadLine();

            Račun rač = new Račun() { limit = limit, stanje = 0, Banka = banka, blokiran = blokiran, lastnik = komitent };
            service.RačunShrani(rač);
            
            
            

        }
        public static string datumString(DateTime date)
        {
            return date.Day + "." + date.Month + "." + date.Year;
        }
        public static void IzpisKomitenta(Komitent kom)
        {
            Console.WriteLine();
            Console.WriteLine("Ime: " + kom.Ime);
            Console.WriteLine("Priimek: " + kom.Priimek);
            Console.WriteLine("Davčna številka: " + kom.DavcnaStevilka);
            Console.WriteLine("Datum rojstva: " + datumString(kom.DatumRojstva));
            Console.WriteLine();

        }

        
        public static void IzpisSeznamaKomitentov(List<Komitent> listKom)
        {
            foreach (var kom in listKom)
            {
                IzpisKomitenta(kom);
            }
        }

        public static void izpisTransakcija(Transakcija tra)
        {
            Console.WriteLine();
            Console.WriteLine("Znesek: " + tra.znesek);
            Console.WriteLine("Datum transakcije: " + tra.datumTransakcije.Day + "." + tra.datumTransakcije.Month + "." + tra.datumTransakcije.Year);
            Console.WriteLine();

        }

        public static void izpisSeznamaTransakcij(List<Transakcija>listTra)
        {
            foreach (var tra in listTra)
                izpisTransakcija(tra);
        }

        public static void izpisRačuna(Račun rač)
        {
            Console.WriteLine();
            Console.WriteLine("Stanje: " + rač.stanje + "$");
            Console.WriteLine("Limit: " + rač.limit + "$");
            Console.WriteLine("Blokiran: " + rač.blokiran + "$");
            Console.WriteLine("Banka: " + rač.Banka + "$");
        }

        public static void izpisSeznamaRačunov(List<Račun> listRač)
        {
            foreach (var rač in listRač)
                izpisRačuna(rač);
        }

        public static void ažuriranjeKomitentov(WebServiceMoj servis)
        {
            Komitent kom = null;
            try
            {
                Console.WriteLine("Pridobi komitenta za ažuriranje (DAVČNA)");
                string davcna = Console.ReadLine();
                kom = servis.komitent(davcna);
            }
            catch
            {
                Console.WriteLine("Napaka pri prdobivanju komitenta");
                return;
            }
            try
            {
                Console.WriteLine("Vnesi ime");
                string ime = Console.ReadLine();
                Console.WriteLine("Vnesi priimek");
                string priimek = Console.ReadLine();
                Console.WriteLine("Vnesi Davcno");
                string davcna1 = Console.ReadLine();
                Console.WriteLine("Podatki o rojstvu:");
                Console.WriteLine("Vnesi leto");
                int leto = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi mesec");
                int mesec = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi dan");
                int dan = int.Parse(Console.ReadLine());
                kom.Ime = ime;
                kom.Priimek = priimek;
                kom.DavcnaStevilka = davcna1;
                kom.DatumRojstva = new DateTime(leto, mesec, dan);
            }
            catch
            {
                Console.WriteLine("Napaka pri vnosu podatkov");
                return;
            }

            try
            { servis.KomitentAžuriraj(kom); }
            catch
            {
                Console.WriteLine("Napaka pri ažuriranju komitenta");
                return;
            }
        }

        public static void ažuriranjeRačunov(WebServiceMoj servis)
        {
            Račun rač = null;
            try
            {
                Console.WriteLine("Vnesi davčno komitenta z tem računom");
                string davčna = Console.ReadLine();
                Console.WriteLine("Vnesi ID računa tega komitenta");
                int IDrač = int.Parse(Console.ReadLine());
                rač = servis.RačunPridobi(servis.komitent(davčna), IDrač);
                izpisRačuna(rač);
            }
            catch
            {
                Console.WriteLine("Napaka pri pridobitvi RAČUNA");
                return;
            }
            try
            {
                Console.WriteLine("Vnesi stanje");
                double stanje = double.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi limit");
                double limit = double.Parse(Console.ReadLine());
                Console.WriteLine("Ali je blokiran DA/NE");
                bool blokiran = false;
                if (Console.ReadLine() == "DA") blokiran = true;
                Console.WriteLine("Vnesi Banko");
                string banka = Console.ReadLine();
                
                Console.WriteLine("Želiš zamenjati lastnika DA/NE");
                if (Console.ReadLine() == "DA")
                {
                    Console.WriteLine("Pridobi novega lastnika (DAVCNA)");
                    string davcna2 = Console.ReadLine();
                    Komitent kom = servis.komitent(davcna2);
                    rač.lastnik = kom;

                }
                rač.stanje = stanje;
                rač.limit = limit;
                rač.blokiran = blokiran;
                rač.Banka = banka;
                servis.RačunAžuriraj(rač);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Napaka pri ažuriranju računov");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }

        public static void AžuriranjeTransakcij(WebServiceMoj servis)
        {
            Transakcija tra = null;
            try
            {
                Console.WriteLine("Vnesi id transakcije");
                int idTra = int.Parse(Console.ReadLine());
                tra = servis.TransakcijaPridobi(idTra);
                if (tra == null) throw new Exception();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Napaka pri pridobitvi transakcije");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            try
            {
                Console.WriteLine("Vnesi znesek transakcije");
                double znesek = double.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi leto");
                int leto = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi mesec");
                int mesec = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi dan");
                int dan = int.Parse(Console.ReadLine());
                tra.znesek = znesek;
                tra.datumTransakcije = new DateTime(leto, mesec, dan);
                servis.TransakcijaAžuriraj(tra);
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Napaka pri ažuriranju transakcije");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }

        public static void BrisanjeKomitentov(WebServiceMoj servis)
        {
            Komitent kom = null;
            try
            {
                Console.WriteLine("Pridobi komitenta za brisanje (DAVCNA");
                string davcna = Console.ReadLine();
                kom = servis.komitent(davcna);
                if (kom == null) throw new Exception();
                
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Napaka pri pridobivanju komitenta za brisanje");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            try
            {
                servis.KomitentBriši(kom);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Napaka pri brisanju komitenta");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
        }
        
        public static void BrisanjeRačunov(WebServiceMoj servis)
        {
            Console.WriteLine("Vnesi podatke o računu za brisanje: ");
            Console.WriteLine("Davčna lastnika: ");
            string davcna = Console.ReadLine();
            Console.WriteLine("ID računa tega lastnika: ");
            int id = int.Parse(Console.ReadLine());
            Račun rač = servis.RačunPridobi(servis.komitent(davcna),id);
            servis.RačunBriši(rač);
        }

        public static void BrisanjeTransakcij(WebServiceMoj servis)
        {
            Transakcija tra = null;
            try
            {
                Console.WriteLine("Izberi transakcijo ID");
                int tranID = int.Parse(Console.ReadLine());
                tra = servis.TransakcijaPridobi(tranID);
                if (tra == null)
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Ni take transakcije");
                return;
            }
            
            servis.TransakcijaBriši(tra);
        }
        public static void pogledUporabnika()
        {

            Console.WriteLine("Izpis vseh komitentov ki so imeli kdaj kakšno transakcijo (1)");
            Console.WriteLine("Izpis vseh transakcij določenega komitenta (2)");
            Console.WriteLine("Izpis podrobnosti določenega komitenta (3)");
            Console.WriteLine("Izpis blokiranih računov (4)");
            Console.WriteLine("Izpis najvišje transakcije (5)");
            Console.WriteLine("Izpis povprečne starosti komitentov (6)");
            Console.WriteLine("Dodajanje komitentov (7)");
            Console.WriteLine("Dodajanje Računov (8)");
            Console.WriteLine("Dodajanje transakcij (9)");

            Console.WriteLine("Ažuriranje komitentov (a)");
            Console.WriteLine("Ažuriranje Računov (b)");
            Console.WriteLine("Ažuriranje transakcij (c)");


            Console.WriteLine("Brisanje komitentov (d)");
            Console.WriteLine("Brisanje Računov (e)");
            Console.WriteLine("Brisanje transakcij (f)");


        }
        public static void pogledAdministratorja()
        {
            Console.WriteLine("Izpis vseh komitentov (x)");
            Console.WriteLine("Izpis vseh transakcij (y)");

        }
         static void Main(string[] args)
         {

             var servis = new WebServiceMoj();

             UporabniskiRacun prijavljen = null;
             while (prijavljen == null)
             {
                 Console.WriteLine("Vnesi ime");
                 string ime = Console.ReadLine();
                 Console.WriteLine("Vnesi geslo");
                 string geslo = Console.ReadLine();

                
                 prijavljen = servis.prijava(ime, geslo);
                 if (prijavljen == null) Console.WriteLine("Napaka: Ni takšnega uporabniškega imena in gesla");
             }

             while (true) // se izvaja ko je navadn uporabnik
             {
                 pogledUporabnika();
                 if (prijavljen.aliJeAdmin) pogledAdministratorja();
                 Console.WriteLine("Za konec vnesite T");
                 Console.WriteLine("Vnesite izbiro...");
                 char izbira = Console.ReadKey().KeyChar;
                 Console.WriteLine();

                 switch (izbira)
                 {
                     case '1':
                        IzpisSeznamaKomitentov(servis.vrniKomitenteZTransakcijo().ToList());
                        
                         break;
                     case '2':
                        Console.WriteLine("Vnesi davčno št. komitenta");
                        string davcna = Console.ReadLine();
                        if (servis.transakcijeKomitenta(davcna) == null)
                            Console.WriteLine("Komitent z številko {0} ne obstaja", davcna);
                        else
                            izpisSeznamaTransakcij(servis.transakcijeKomitenta(davcna).ToList());
                         break;
                     case '3':
                        Console.WriteLine("Vnesi davčno št. komitenta");
                        string davcna1 = Console.ReadLine();
                        if (servis.komitent(davcna1) == null)
                            Console.WriteLine("Komitent z številko {0} ne obstaja", davcna1);
                        else
                            IzpisKomitenta(servis.komitent(davcna1));
                        break;


                    case '4':
                         Console.WriteLine("Blokirani računi so:");
                         izpisSeznamaRačunov(servis.IzpisBlokiranihRačunov().ToList());
                         break;

                     case '5':
                         Console.WriteLine("Najvišja transakcija:");
                         IzpisKomitenta(servis.NajvišjaTransakcija().račun.lastnik);
                         izpisTransakcija(servis.NajvišjaTransakcija());
                         Console.WriteLine();
                         break;

                     case '6':
                         Console.WriteLine("Povprečna starost komitentov: " + servis.povprecnaStarostKomitentov());
                         Console.WriteLine();
                         break;
                    case '7':
                        DodajKomitenta(servis);
                        break;

                    case '8':
                         DodajRačun(servis);
                         break;

                     case '9':
                        DodajTransakcijo(servis);
                         break;
                    case 'a':
                        ažuriranjeKomitentov(servis);
                        break;
                    case 'b':
                        ažuriranjeRačunov(servis);
                        break;
                    case 'c':
                        AžuriranjeTransakcij(servis);
                        break;
                    case 'd':
                        BrisanjeKomitentov(servis);
                        break;
                    case 'e':
                        BrisanjeRačunov(servis);
                        break;
                    case 'f':
                        BrisanjeTransakcij(servis);
                        break;

                    case 'x':
                        if (prijavljen.aliJeAdmin)
                            IzpisSeznamaKomitentov(servis.SeznamKomitentov().ToList());
                        else
                            Console.WriteLine("You shall not pass");
                        break;

                    case 'y':
                        if (prijavljen.aliJeAdmin)
                            izpisSeznamaTransakcij(servis.vrniTransakcije().ToList());
                        else
                            Console.WriteLine("You shall not pass");
                        break;
                    case 'T':
                         return;
                     default:
                         Console.WriteLine("Pa ka ti ni jasno sam od 1-8 pa T maš butl");
                         break;


                 }

             }
         }

        




    }
}

