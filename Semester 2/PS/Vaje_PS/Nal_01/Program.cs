using System;

namespace Nal_01
{
    public class Program
    {
        //a predstavlja polje (celostevilskih) elementov, ki ga urejamo
        public static int[] urediSPrameni(int[] a)
        {
            // polja med katerimi bomo premetavali vrednosti
            // vsa polja morajo biti iste dolžine kot vhodno polje
            int[] poljePrenesenihVrednosti = new int[a.Length]; // katere vrednosti smo prenesli po indexih
            int[] koncnoPolje = new int[a.Length];
            int[] razultat_delno = new int[a.Length];

            int dolzinaReza = 0;
            int i_pe = 0;


            int pr2;
            int rez2_dol;

            int dolzinaPolja = a.Length;
            while (dolzinaPolja > 0)
            {
                int[] pramen = new int[a.Length];
                int pr = 0;
                while (poljePrenesenihVrednosti[i_pe] == 1) i_pe++; // gleda prenesene vrednosti

                int pe = a[i_pe];
                poljePrenesenihVrednosti[i_pe] = 1;
                dolzinaPolja--;
                pramen[pr] = pe;
                pr++;

                for (int i = i_pe; i < a.Length; i++)
                {
                    if ((poljePrenesenihVrednosti[i] == 0) && (a[i] <= pe)) // samo če polje še ni bilo vpisano in vrdnost a[i] je manjša ali enaka
                    {
                        pramen[pr] = a[i];
                        pr++;
                        dolzinaPolja--;
                        poljePrenesenihVrednosti[i] = 1;
                        pe = a[i];
                    }
                }

                razultat_delno = new int[a.Length];
                pr2 = 0;
                rez2_dol = 0;
                int k = 0;

                while ((rez2_dol < dolzinaReza) && (pr2 < pr))
                {
                    if (koncnoPolje[rez2_dol] >= pramen[pr2])
                    {
                        razultat_delno[k] = koncnoPolje[rez2_dol];
                        k++;
                        rez2_dol++;
                    }
                    else
                    {
                        razultat_delno[k] = pramen[pr2];
                        k++;
                        pr2++;
                    }
                }
                while (pr2 < pr)
                {
                    razultat_delno[k] = pramen[pr2];
                    k++;
                    pr2++;
                }
                while (rez2_dol < dolzinaReza)
                {
                    razultat_delno[k] = koncnoPolje[rez2_dol];
                    k++;
                    rez2_dol++;
                }
                dolzinaReza = k;
                koncnoPolje = razultat_delno;
            }

            return koncnoPolje;


        }

        //el predstavlja element, ki ga iscemo, a predstavlja polje
        public static int poisci(int el, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                if (el == a[i]) return i;
            return -1;
        }

        //el predstavlja element, ki ga iscemo, a predstavlja polje
        public static int poisciZBisekcijo(int el, int[] a)
        {

            if (a.Length < 1) return -1;

            int nictiIndex = 0;
            int zadnjeIndex = a.Length - 1;
            int srednjiIndex = (nictiIndex + zadnjeIndex) / 2;
            int konec = 0;

            while (konec <= a.Length)
            {
                if (el > a[srednjiIndex])
                {
                    nictiIndex = srednjiIndex;
                    srednjiIndex = (nictiIndex + zadnjeIndex) / 2;

                }
                if (el < a[srednjiIndex])
                {
                    zadnjeIndex = srednjiIndex;
                    srednjiIndex = (nictiIndex + zadnjeIndex) / 2;
                }
                if ((el == a[nictiIndex])) return nictiIndex;
                if (el == a[srednjiIndex])
                {
                    if (el != a[srednjiIndex - 1]) return srednjiIndex;
                    else srednjiIndex--;
                }


                konec++;
            }

            return -1;

        }

        public static bool jePadajoce(int[] a)
        {
            if (a == null)
                return false;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] < a[i + 1])
                    return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            //zastavica uspesnosti testiranja
            bool uspesno = true;

            //POSAMEZNI TESTNI SCENARIJI

            //testni scenarij "Uredi polje narascajocih elementov padajoce"
            string opis_scenarija = "Uredi polje narascajocih elementov padajoce";
            string ime_metode = "int[] urediSPrameni(int[])";

            //priprava
            int[] vhod = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 8 };
            int[] pricakovan_izhod = { 10, 8, 6, 4, 2, 0, -2, -4, -6, -8, -10 };

            //klic testirane metode
            int[] dobljen_izhod = urediSPrameni(vhod);

            //preverjanje

            //ko je dobljen_izhod == NULL
            if (dobljen_izhod == null)
            {
                Console.WriteLine("V testnem scenariju \"{0}\": Metoda \"{1}\" ni vrnila polja, pac pa null.", opis_scenarija, ime_metode);
                uspesno = false;
                //ko dolzina dobljenega polja ni ustrezne dolzine 
            }
            else if (dobljen_izhod.Length != pricakovan_izhod.Length)
            {
                Console.WriteLine("V testnem scenariju \"{0}\": Metoda \"{1}\" ni vrnila polja ustrezne dolzine.", opis_scenarija, ime_metode);
                uspesno = false;
            }
            else /*if (dobljen_izhod.Length == pricakovan_izhod.Length)*/
            {
                //ko se kateri element iz dobljen_izhod ne sklada z elementom v pricakovan_izhod => napaka v algoritmu
                //drugače - test v algoritmu ni zaznal napake
                for (int i = 0; i < pricakovan_izhod.Length; i++)
                {
                    if (pricakovan_izhod[i] != dobljen_izhod[i])
                    {
                        Console.WriteLine("V testnem scenariju \"{0}\": Metoda \"{1}\" ni vrnila pravilno urejenega polja.", opis_scenarija, ime_metode);
                        uspesno = false;
                        break;
                    }
                }
            }


            // TUKAJ VSTAVI SVOJE PRIMERE
            // Npr. ce poisci in poisciZBisekcijo res vrneta indeks elementa, 
            // ki je skrajno levo v polju (torej prvo pojavljanje).
            // Ce poisci in poisciZBisekcijo pri praznem polju res vrne -1.
            // Ce urediSPrameni res padajoce uredi polje in ce so se pri tem vsi elementi ohranili.
            // Ce poisci in poisciZBisekcijo vracata pravilni indeks iskanega elementa v polju.
            // Ce se poisciZBisekcijo pri vecjem stevilu elementov res hitreje izvede kot poisci. 
            // Ce poisci in poisciZBisekcijo med iskanjem ne spreminja polja.
            // ...


            //po vseh testnih scenarijih
            Console.Write("Povzetek: Program ");
            if (uspesno)
            {
                Console.Write("JE ");
            }
            else
            {
                Console.Write("ni ");
            }
            Console.WriteLine("uspesno prestal testiranja.");


            int[] polje = { 109, 114, 84, 71, 51, 106, 51, 79, 64, 42 };

            DateTime start = DateTime.Now;
            int[] urejenoPolje = urediSPrameni(polje);
            DateTime stop = DateTime.Now;

            double interval = (stop - start).TotalMilliseconds;
            Console.WriteLine("Cas izvajanja urejanja s prameni: {0} milisekund.", interval);
            int[] polje3 = new int[10] { 1, 2, 2, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < vhod.Length; i++)
            {
                Console.WriteLine(vhod[i]);
            }
            Console.WriteLine();
            Console.WriteLine(poisciZBisekcijo(5, vhod));


            Console.ReadKey();

        }
    }
}
