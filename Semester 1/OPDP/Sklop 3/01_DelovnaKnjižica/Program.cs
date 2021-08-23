using System;

namespace Delovna_knjižica
{
    public struct Zaposlen
    {
        public string DelovnaŠtevilka;
        public string Ime;
        public string Priimek;
        public int DelovnaDoba;
        public int starost;
        public int ID1;
        public int ID2;
        public int ID3;


        public static void VpisZaposlenih(Zaposlen[] poljeZaposlenih)
        {
            for (int i = 0; i < poljeZaposlenih.Length; ) // možen vpis 10 zaposlenih
            {
                Console.WriteLine("Vpisi ime zaposlenega");
                string ime = Console.ReadLine();
                Console.WriteLine("Vpiši priimek zaposlenega");
                string priimek = Console.ReadLine();
                Console.WriteLine("Vnesi starost");
                int starost = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi spol ali moški-(M) ali ženski-(Ž)");
                string spol = Console.ReadLine();
                Console.WriteLine("Vnesi ID1");
                int ID1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi ID2");
                int ID2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi ID3");
                int ID3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Vpiši delovno dobo");
                int delovnaDoba = int.Parse(Console.ReadLine());

                int najvišjaMožnaDelovnaDoba = starost - 18;
                // Samo če je vpis podatkov pravilen se podatki vpišejo v strukturo in se števec za vpis v naslednjo mesto v strukturi poveča.
                if ((starost >= 18 && starost <= 80) && (spol == "M" || spol == "Ž") && (ID1 >= 0 && ID1 <= 9) && (ID2 >= 0 && ID2 <= 9) && (ID3 >= 0 && ID3 <= 9) && (delovnaDoba <= najvišjaMožnaDelovnaDoba) && (Program.BesedaSlovenskeAbecede(ime) == true && Program.BesedaSlovenskeAbecede(priimek) == true))
                {
                    poljeZaposlenih[i].Ime = ime;
                    poljeZaposlenih[i].Priimek = priimek;
                    poljeZaposlenih[i].DelovnaDoba = delovnaDoba;
                    poljeZaposlenih[i].starost = starost;
                    poljeZaposlenih[i].ID1 = ID1;
                    poljeZaposlenih[i].ID2 = ID2;
                    poljeZaposlenih[i].ID3 = ID3;
                    poljeZaposlenih[i].DelovnaŠtevilka = spol + starost + ID1 + ID2 + ID3;
                    i++; // tukaj preverjamo koliko je bilo pravilnih vpisov in povečujemo kazalec
                }
                // Drugače se nepravilen vpis ne upošteva in ima uporabnik možnost nadaljevanja tam kjer se je zmotil.
                else //Izpis napake pri vpisu
                {
                    Console.WriteLine("Napaka pri vpisu");
                    continue;
                }
                                
                Console.WriteLine("Za zaključek vpisovanja vpiši KONEC drugače enter");
                string odlocitev = Console.ReadLine();
                if (odlocitev == "KONEC") break;
            }

        }

        public static void IzpisNajstarejšegaZaposlenega(Zaposlen[] zaposleni)
        {
                
                int najstarejšVrednost = zaposleni[0].starost;
                for (int i = 0; i < zaposleni.Length - 1; i++) //V tej zanki išče najmanjšo vrednost
                {
                    if (najstarejšVrednost < zaposleni[i].starost) // Pogoj za najmanjšo vrednost
                    {
                        najstarejšVrednost = zaposleni[i].starost;
                    }
                }

                for (int i = 0; i < zaposleni.Length; i++) // Z zanko gremo čez celo polje
                {
                    if (zaposleni[i].starost == najstarejšVrednost) // In izpišemo vse zaposlene ki si delijo najstarejšo vrednost
                        Console.WriteLine(zaposleni[i].DelovnaŠtevilka + " " + zaposleni[i].Ime + " " + zaposleni[i].Priimek+" "+zaposleni[i].starost+" "+zaposleni[i].DelovnaDoba);
                }
        }
          
        public static void NajmanjšaDelovnaDoba(Zaposlen[]zaposleni)
        {
            int najmanjšaVrednostDelovneDobe = zaposleni[0].DelovnaDoba; // ničto delovno dobo nastavimo kot najmanjšo

            for (int i = 0; i < zaposleni.Length - 1; i++) // iščemo najmanjšo delovno dobo
            {
                if ((najmanjšaVrednostDelovneDobe > zaposleni[i].DelovnaDoba)&&(zaposleni[i].Ime != null))
                {
                    najmanjšaVrednostDelovneDobe = zaposleni[i].DelovnaDoba;
                }
            }
            int števecMINdelovnaDoba = 0;
            for (int i = 0; i < zaposleni.Length; i++) // Preverimo koliko je zaposlenih z isto delovno dobo
            {
                if (zaposleni[i].DelovnaDoba == najmanjšaVrednostDelovneDobe)
                {
                    števecMINdelovnaDoba++;
                }
            }
            if (števecMINdelovnaDoba == 1) // če je samo en tak tega izpišemo
            {
                for (int j = 0; j < zaposleni.Length - 1; j++)
                {
                    if ((zaposleni[j].DelovnaDoba == najmanjšaVrednostDelovneDobe)&&(zaposleni[j].Ime != null))
                    {
                        Console.WriteLine(zaposleni[j].DelovnaŠtevilka + " " + zaposleni[j].Ime + " " + zaposleni[j].Priimek + " " +zaposleni[j].starost+ " "+ zaposleni[j].DelovnaDoba);
                    }
                }
            }

            if (števecMINdelovnaDoba > 1) // če je več zaposlenih z isto delovno dobo se držimo pravila iz navodil
            {
                for (int j = 0; j < zaposleni.Length - 1; j++)
                {
                    if ((zaposleni[j].DelovnaDoba == najmanjšaVrednostDelovneDobe) && (zaposleni[j].ID1 < 7 && zaposleni[j].ID2 < 7 && zaposleni[j].ID3 < 7)&&(zaposleni[j].Ime != null))
                    {
                        Console.WriteLine(zaposleni[j].DelovnaŠtevilka + " " + zaposleni[j].Ime + " " + zaposleni[j].Priimek + " " + zaposleni[j].starost + " " + +zaposleni[j].DelovnaDoba);
                    }
                }
            }
        }

        static public Zaposlen[] Sortiranje(Zaposlen[]poljeZaposlenih)
        {
            for (int i = 0; i < poljeZaposlenih.Length - 1; i++) //bubble sort za urejanje
            {
                for (int j = i+1; j < poljeZaposlenih.Length-1; j++)
                {
                    if (poljeZaposlenih[j].Ime == null) break; // prekini ko ni več zaposlenih
                    else if(Program.OsebaNajprejPoAbecedi(poljeZaposlenih[i].Ime,poljeZaposlenih[j].Ime,poljeZaposlenih[i].Priimek,poljeZaposlenih[j].Priimek) == 2)
                    {
                        // če je zamenjava potrebna zamenjaj
                       Zaposlen temp = poljeZaposlenih[i];
                       poljeZaposlenih[i] = poljeZaposlenih[j];
                       poljeZaposlenih[j] = temp;
                    }
                } 
            }
            return poljeZaposlenih;
        }

        static public void IzpisvsehZaposlenih(Zaposlen[]poljeZaposlenih)
        {
            for (int i = 0; i < poljeZaposlenih.Length; i++) // izpis v zanki
            {
                if (poljeZaposlenih[i].Ime == null) break; // ko pride do nevpisane vrednosti prekini
                Console.WriteLine(poljeZaposlenih[i].DelovnaŠtevilka + " " + poljeZaposlenih[i].Ime + " " + poljeZaposlenih[i].Priimek + " " + poljeZaposlenih[i].starost + " " + +poljeZaposlenih[i].DelovnaDoba);
            }
        }

        
    }
    class Program
    {
        static public int OsebaNajprejPoAbecedi(string ime1, string ime2, string priimek1, string priimek2)
        {
            int večjaBeseda = 0;
            // povečamo besedo, ki je manjša in za toliko kot je manjša dodamo na koncu a-je
            if (ime1.Length > ime2.Length)
            {
                for (int i = 0; i < ime1.Length - ime2.Length; i++)
                {
                    ime2 = ime2 + "a";
                }
            }
            else if (ime1.Length < ime2.Length)
            {
                for (int i = 0; i < ime2.Length - ime1.Length; i++)
                {
                    ime1 = ime1 + "a";
                }
            }
            // isto kot z imeni naredimo z priimki
            if (priimek1.Length > priimek2.Length)
            {
                for (int i = 0; i < priimek1.Length - priimek2.Length; i++)
                {
                    ime2 = ime2 + "a";
                }
            }
            else if (priimek1.Length < priimek2.Length)
            {
                for (int i = 0; i < priimek2.Length - priimek1.Length; i++)
                {
                    priimek1 = priimek1 + "a";
                }
            }
            // zlepimo imena in priimke
            string imePriimek1 = ToLower(ime1 + priimek1);
            string imePriimek2 = ToLower(ime2 + priimek2);
            // preverjali bomo po indexis v tem nizu abeceda
            string abeceda = "abcčdefghijklmnoprsštuvzž";

            for (int i = 0; i < imePriimek1.Length; i++)
            {
                int vrednostbesede1 = 0;
                int vrednostbesede2 = 0;
                for (int j = 0; j < abeceda.Length; j++) // preverjamo niz po abecedi
                {
                    if (imePriimek1[i] == abeceda[j])
                    {
                        vrednostbesede1 = j; // dobimo index od mesta v abecedi
                    }
                }
                // isto naredimo za drugo osebo
                for (int j = 0; j < abeceda.Length; j++)
                {
                    if (imePriimek2[i] == abeceda[j])
                    {
                        vrednostbesede2 = j;
                    }
                }
                // če je vrednostbesede1 večji od vrednostbesede2 vrnemo 1
                if (vrednostbesede1 < vrednostbesede2)
                {
                    večjaBeseda = 1;
                    break;
                }
                // drugače vrnemo 2
                else if (vrednostbesede1 > vrednostbesede2)
                {
                    večjaBeseda = 2;
                    break;
                }
            }
            /*Če je 1. oseba po abecedi večja ne glede po čem program gleda ime,priimek funkcija vrne 1, 
             * če je po abecedi večja oseba 2 funkcija vrne 2 če pa sta enaki pa vrne 0*/
            //oseba1>osebe2 = 1
            //oseba2>osebe1 = 2
            //oseba1=osebi2 = 0
            return večjaBeseda;
        }

        static public string ToLower(string beseda)
        {
            string malaBeseda = null;

            for (int i = 0; i < beseda.Length; i++) // v zanki preverjamo kakšna črka je
            {
                char besedaodI = beseda[i];

                if (beseda[i] >= 'A' && beseda[i] <= 'Z') // če je beseda med A in Z jo nadomesstimo z isto malo črko
                {
                    char malacrka = beseda[i];
                    int vrednostCrke = (int)malacrka;
                    vrednostCrke = vrednostCrke + 32;
                    malacrka = (char)vrednostCrke;
                    malaBeseda = malaBeseda + malacrka;
                }
                else if (beseda[i] == 'Č' || beseda[i] == 'Š' || beseda[i] == 'Ž') // če je beseda Č,Ž,Š jo nadomestimo z isto malo črko
                {
                    switch (beseda[i])
                    {
                        case 'Ž':
                            malaBeseda = malaBeseda + 'ž';
                            break;
                        case 'Š':
                            malaBeseda = malaBeseda + 'š';
                            break;
                        case 'Č':
                            malaBeseda = malaBeseda + 'č';
                            break;
                    }
                }
                else // če črka ni velika jo samo prepišemo
                {
                    malaBeseda = malaBeseda + beseda[i];
                }
            }
            return malaBeseda;
        }

        static public bool BesedaSlovenskeAbecede(string beseda)
        {
            bool pravilnost = false;
            beseda = ToLower(beseda);
            string abc = "abcčdefghijklmnoprsštuvzž";
            for (int i = 0; i < beseda.Length; i++) 
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    pravilnost = false; // če znak ni slovenske abecede nastavimo FALSE
                    if (beseda[i] == abc[j])
                    {
                        pravilnost = true; // če je znak slovenske abecede nastavimo TRUE
                        break;
                    }

                }
                if (pravilnost == false) // tukaj skočimo iz druge zanke v primeru da znak ni slovenske abecede
                {
                    pravilnost = false;
                    break;
                }

            }



            return pravilnost;
        }
        
        static void Main(string[] args)
        {

            Zaposlen[] poljeZaposlenih = new Zaposlen[10];
            Zaposlen.VpisZaposlenih(poljeZaposlenih);
            Console.Clear();
            Console.WriteLine("Sortiran izpis zaposlenih po abecedi:");
            Zaposlen.Sortiranje(poljeZaposlenih);
            Zaposlen.IzpisvsehZaposlenih(poljeZaposlenih);
            Console.WriteLine();

            Console.WriteLine("Izpis najstarejše oseb/e:");
            Zaposlen.IzpisNajstarejšegaZaposlenega(poljeZaposlenih);
            Console.WriteLine();
            Console.WriteLine("Izpis oseb/e z najmanjšo delovno dobo:");
            Zaposlen.NajmanjšaDelovnaDoba(poljeZaposlenih);
            Console.ReadKey();


            Console.WriteLine(ToLower("345678fWWWWWWWWghjkcvb;:;$%&/()nEZFGHJ"));
            Console.ReadKey();
                                       
        }
    }
}
