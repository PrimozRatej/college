using System;
using System.Collections.Generic;
using System.Text;

namespace Nal_04
{

    public class Testi
    {
        static float min_element(float[] zaporedje)
        {
            if (zaporedje.Length == 0)
                return float.NaN;
            else if (zaporedje.Length == 1)
                return zaporedje[0];
            float najmanjsi = zaporedje[0];

            foreach (float vrednost in zaporedje)
                if (vrednost < najmanjsi)
                    najmanjsi = vrednost;
            return najmanjsi;
        }


        static float max_element(float[] zaporedje)
        {
            if (zaporedje.Length == 0)
                return float.NaN;
            else if (zaporedje.Length == 1)
                return zaporedje[0];
            float najvecji = zaporedje[0];

            foreach (float vrednost in zaporedje)
                if (vrednost > najvecji)
                    najvecji = vrednost;
            return najvecji;
        }

        static bool polja_enaka<T>(T[] a, T[] b) where T : IComparable<T>
        {
            if (a.Length != b.Length) return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].CompareTo(b[i]) != 0) return false;
            }

            return true;
        }

        static bool test_najmanjsi_element()
        {
            string opis_scenarija = "Vrni najmanjsi element v iskalnem drevesu.";
            string ime_metode = "float IskalnoDrevo.najmanjsiElement()";
            try
            {
                //stevila
                float[] zaporedje = { 1.1f, -9.9f, 16.16f, -25.25f, -1.1f, 4.4f, 36.36f, -16.16f, -4.4f, .0f, 9.9f, 25.25f, 49.49f };
                //priprava IskalnoDrevo
                IskalnoDrevo id = new IskalnoDrevo();
                for (int i = 0; i < zaporedje.Length; i++)
                    id.vstavi(zaporedje[i]);

                //kontrola
                float pricakovana_vrednost = min_element(zaporedje);

                //testing
                if (id.najmanjsiElement() != pricakovana_vrednost)
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilnega najmanjsega elementa. ", opis_scenarija, ime_metode);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' je prozila izjemo. Opis izjeme: \'{2}\'", opis_scenarija, ime_metode, e.Message);
                return false;
            }

            //vse vredu
            return true;
        }

        static bool test_najvecji_element()
        {
            string opis_scenarija = "Vrni najvecji element v iskalnem drevesu.";
            string ime_metode = "float IskalnoDrevo.najvecjiElement()";
            try
            {
                //stevila
                float[] zaporedje = { 1.1f, -9.9f, 16.16f, -25.25f, -1.1f, 4.4f, 36.36f, -16.16f, -4.4f, .0f, 9.9f, 25.25f, 49.49f };
                //priprava IskalnoDrevo
                IskalnoDrevo id = new IskalnoDrevo();
                for (int i = 0; i < zaporedje.Length; i++)
                    id.vstavi(zaporedje[i]);

                //kontrola
                float pricakovana_vrednost = max_element(zaporedje);

                //testing
                if (id.najvecjiElement() != pricakovana_vrednost)
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilnega najvecjega elementa. ", opis_scenarija, ime_metode);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' je prozila izjemo. Opis izjeme: \'{2}\'", opis_scenarija, ime_metode, e.Message);
                return false;
            }

            //vse vredu
            return true;
        }

        static bool test_size()
        {
            string opis_scenarija = "Vrni stevilo vozlisc v iskalnem drevesu.";
            string ime_metode = "int IskalnoDrevo.size()";

            try
            {
                float[] zaporedje = new float[] { 2, 3, 1 };
                IskalnoDrevo id = new IskalnoDrevo();
                for (int i = 0; i < zaporedje.Length; i++)
                    id.vstavi(zaporedje[i]);

                //kontrola
                int pricakovana_vrednost = 3;

                //testing
                if (id.size() != pricakovana_vrednost)
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilnega stevila vozlisc. ", opis_scenarija, ime_metode);
                    return false;
                }

                id.vstavi(4);
                if (id.size() != pricakovana_vrednost + 1)
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilnega stevila vozlisc po dodajanju vozlisca. ", opis_scenarija, ime_metode);
                    return false;
                }

                //vecji primer
                float[] primer2 = { 25, 12, 30, 7, 18, 26, 32, 5, 9, 15, 28, 27 };
                IskalnoDrevo id2 = new IskalnoDrevo();
                for (int i = 0; i < primer2.Length; i++)
                    id2.vstavi(primer2[i]);

                if (id2.size() != primer2.Length)
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilnega stevila vozlisc za vecji primer. ", opis_scenarija, ime_metode);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' je prozila izjemo. Opis izjeme: \'{2}\'", opis_scenarija, ime_metode, e.Message);
                return false;
            }

            //vse vredu
            return true;
        }

        static bool test_narascajoca_vrsta()
        {
            string opis_scenarija = "Vrni narascajoco vrsto elementov v iskalnem drevesu.";
            string ime_metode = "Queue<float> IskalnoDrevo.narascajocaVrsta()";

            try
            {
                float[] zaporedje = new float[] { 2, 3, 1 };
                IskalnoDrevo id = new IskalnoDrevo();
                for (int i = 0; i < zaporedje.Length; i++)
                    id.vstavi(zaporedje[i]);

                //kontrola
                float[] pricakovana_vrsta = new float[] { 1, 2, 3 };

                //testing
                float[] rezultat = id.narascajocaVrsta().ToArray();
                float[] infix = id.infixQueue().ToArray();
                if (!polja_enaka(pricakovana_vrsta, rezultat) || !polja_enaka(pricakovana_vrsta, infix))
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilne narascajoce vrste. ", opis_scenarija, ime_metode);
                    return false;
                }

                //vecji primer
                float[] primer2 = { 25, 12, 30, 7, 18, 26, 32, 5, 9, 15, 28, 27 };
                float[] primer2_sortiran = new float[primer2.Length];
                Array.Copy(primer2, primer2_sortiran, primer2.Length);
                Array.Sort(primer2_sortiran);
                IskalnoDrevo id2 = new IskalnoDrevo();
                for (int i = 0; i < primer2.Length; i++)
                    id2.vstavi(primer2[i]);

                float[] primer2_rezultat = id2.narascajocaVrsta().ToArray();
                float[] primer2_rezultat_infix = id2.infixQueue().ToArray();
                if (!polja_enaka(primer2_sortiran, primer2_rezultat) || !polja_enaka(primer2_sortiran, primer2_rezultat_infix))
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilne narascajoce vrste za vecji primer. ", opis_scenarija, ime_metode);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' je prozila izjemo. Opis izjeme: \'{2}\'", opis_scenarija, ime_metode, e.Message);
                return false;
            }

            //vse vredu
            return true;
        }

        static bool test_padajoca_vrsta()
        {
            string opis_scenarija = "Vrni padajoco vrsto elementov v iskalnem drevesu.";
            string ime_metode = "Queue<float> IskalnoDrevo.padajocaVrsta()";

            try
            {
                float[] zaporedje = new float[] { 2, 3, 1 };
                IskalnoDrevo id = new IskalnoDrevo();
                for (int i = 0; i < zaporedje.Length; i++)
                    id.vstavi(zaporedje[i]);

                //kontrola
                float[] pricakovana_vrsta = new float[] { 3, 2, 1 };

                //testing
                float[] rezultat = id.padajocaVrsta().ToArray();
                if (!polja_enaka(pricakovana_vrsta, rezultat))
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilne padajoce vrste. ", opis_scenarija, ime_metode);
                    return false;
                }

                //vecji primer
                float[] primer2 = { 25, 12, 30, 7, 18, 26, 32, 5, 9, 15, 28, 27 };
                float[] primer2_sortiran = new float[primer2.Length];
                Array.Copy(primer2, primer2_sortiran, primer2.Length);
                Array.Sort(primer2_sortiran);
                Array.Reverse(primer2_sortiran);
                IskalnoDrevo id2 = new IskalnoDrevo();
                for (int i = 0; i < primer2.Length; i++)
                    id2.vstavi(primer2[i]);

                float[] primer2_rezultat = id2.padajocaVrsta().ToArray();
                if (!polja_enaka(primer2_sortiran, primer2_rezultat))
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilne padajoce vrste za vecji primer. ", opis_scenarija, ime_metode);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' je prozila izjemo. Opis izjeme: \'{2}\'", opis_scenarija, ime_metode, e.Message);
                return false;
            }

            //vse vredu
            return true;
        }

        static bool test_prefiksna_vrsta()
        {
            string opis_scenarija = "Vrni prefiksno vrsto elementov v iskalnem drevesu.";
            string ime_metode = "Queue<float> IskalnoDrevo.prefixQueue()";

            try
            {
                float[] zaporedje = new float[] { 2, 3, 1 };
                IskalnoDrevo id = new IskalnoDrevo();
                for (int i = 0; i < zaporedje.Length; i++)
                    id.vstavi(zaporedje[i]);

                //kontrola
                float[] pricakovana_vrsta = new float[] { 2, 1, 3 };

                //testing
                float[] rezultat = id.prefixQueue().ToArray();
                if (!polja_enaka(pricakovana_vrsta, rezultat))
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilne prefiksne vrste. ", opis_scenarija, ime_metode);
                    return false;
                }

                //vecji primer
                float[] primer2 = { 25, 12, 30, 7, 18, 26, 32, 5, 9, 15, 28, 27 };
                float[] primer2_pricakovana = { 25, 12, 7, 5, 9, 18, 15, 30, 26, 28, 27, 32 };
                IskalnoDrevo id2 = new IskalnoDrevo();
                for (int i = 0; i < primer2.Length; i++)
                    id2.vstavi(primer2[i]);

                float[] primer2_rezultat = id2.prefixQueue().ToArray();
                if (!polja_enaka(primer2_pricakovana, primer2_rezultat))
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilne prefiksne vrste za vecji primer. ", opis_scenarija, ime_metode);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' je prozila izjemo. Opis izjeme: \'{2}\'", opis_scenarija, ime_metode, e.Message);
                return false;
            }

            //vse vredu
            return true;
        }

        static bool test_postfiksna_vrsta()
        {
            string opis_scenarija = "Vrni postfiksno vrsto elementov v iskalnem drevesu.";
            string ime_metode = "Queue<float> IskalnoDrevo.postfixQueue()";

            try
            {
                float[] zaporedje = new float[] { 2, 3, 1 };
                IskalnoDrevo id = new IskalnoDrevo();
                for (int i = 0; i < zaporedje.Length; i++)
                    id.vstavi(zaporedje[i]);

                //kontrola
                float[] pricakovana_vrsta = new float[] { 1, 3, 2 };

                //testing
                float[] rezultat = id.postfixQueue().ToArray();
                if (!polja_enaka(pricakovana_vrsta, rezultat))
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilne postfiksne vrste. ", opis_scenarija, ime_metode);
                    return false;
                }

                //vecji primer
                float[] primer2 = { 25, 12, 30, 7, 18, 26, 32, 5, 9, 15, 28, 27 };
                float[] primer2_pricakovana = { 5, 9, 7, 15, 18, 12, 27, 28, 26, 32, 30, 25 };
                IskalnoDrevo id2 = new IskalnoDrevo();
                for (int i = 0; i < primer2.Length; i++)
                    id2.vstavi(primer2[i]);

                float[] primer2_rezultat = id2.postfixQueue().ToArray();
                if (!polja_enaka(primer2_pricakovana, primer2_rezultat))
                {
                    Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilne postfiksne vrste za vecji primer. ", opis_scenarija, ime_metode);
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' je prozila izjemo. Opis izjeme: \'{2}\'", opis_scenarija, ime_metode, e.Message);
                return false;
            }

            //vse vredu
            return true;
        }

        //glavna metoda
        static void Main(string[] args)
        {
            bool uspesni = true;
            Console.WriteLine("--- zacetek testiranja ---");
            //izvajanje testov
            if (!test_najmanjsi_element())
                uspesni = false;
            // TODO: Tukaj dodajte svoje teste, ki bodo ustrezno preverili, da vasa
            //       implementacija deluje pravilno.
            if (!test_najvecji_element()
                || !test_size()
                || !test_narascajoca_vrsta() /* testira tudi infixQueue */
                || !test_padajoca_vrsta()
                || !test_prefiksna_vrsta()
                || !test_postfiksna_vrsta())
                uspesni = false;

            //povzetek
            if (uspesni)
                Console.Write("Povzetek: Program JE");
            else
                Console.Write("Povzetek: Program ni");
            Console.WriteLine(" uspesno prestal testiranje.");
            Console.WriteLine("--- konec testiranja ---");
            Console.WriteLine();
        }
    }
}
