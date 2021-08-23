//Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/*Izdelajte program, ki bo prebral od 2 do 10 števil in izpisal drugo najmanjše med njimi. 
 * Vnos podatkov lahko predhodno zaključimo z vnosom vrednosti 0 
 * (vrednost 0 pomeni prekinitev nadaljnjega vnašanja podatkov in se ne upošteva pri določanju drugega najmanjšega števila).
V primeru, da drugega najmanjšega števila ni mogoče določiti, naj se izpiše opozorilo o napaki.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugonajvecjeStevilo
{
    class Program
    {
        // funkcija za izračun najmanjšega števila
        static public int MIN(int[] polje)
        {
            int najmanjseStevilo = polje[0];
            for (int i = 0; i < polje.Length - 1; i++)
            {

                if (polje[i] == 0) break;
                if (najmanjseStevilo > polje[i]) { najmanjseStevilo = polje[i]; }
            }
            return najmanjseStevilo;
        }

        // funkcija za izračun najvecjega števila
        static public int MAX(int[] polje)
        {
            int najvecjeStevilo = polje[0];
            for (int i = 0; i < polje.Length - 1; i++)
            {
                if (polje[i] == 0) break;
                if (najvecjeStevilo < polje[i]) najvecjeStevilo = polje[i];
            }
            return najvecjeStevilo;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši 10 števil");
            int[] polje = new int[10];
            for (int a = 0; a <= 9; a++) //vpis števila po število
            {
                
                polje[a] = int.Parse(Console.ReadLine());
                if (polje[a] == 0) break;

            }
            //KLICANJE FUNKCIJ
            int drugoNajmanjseStevilo = MAX(polje); // drugo najmanjše število nastavimo na začetku na največje
            int najmanjseStevilo = MIN(polje);
            
            // Izračun drugega najmanjšega števila
            for (int a = 0; a <= polje.Length - 1; a++)
            {
                if (polje[a] == 0) break;
                else if (polje[a] == najmanjseStevilo) continue;
                else if (drugoNajmanjseStevilo > polje[a]) { drugoNajmanjseStevilo = polje[a]; }
            }
            // če je drugo najmanjše število v tem delu največje število obenem 0 ali pa enako najmanjšemu pomeni da ali je uporabnik vpisal samo 0 ali pa samo enake vrednosti.
            if (drugoNajmanjseStevilo == 0 || najmanjseStevilo == drugoNajmanjseStevilo) { Console.WriteLine("Napaka"); } // javi napako
            else
            {
                Console.WriteLine("------");
                
                Console.WriteLine("Drugo najmanjše število je: "+drugoNajmanjseStevilo); // Izpis drugega najmanjšega števila če so vnosi pravilni
            }
            Console.ReadKey();

        }
    }
}
