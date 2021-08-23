using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stevilocrk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši niz znakov");
            string nizZnakov = Console.ReadLine();
            int stevecStevil = 0;
            string slovenskaAbecedaMALE = "abcčdefghijklmnoprsštuvzž";
            string slovenskaAbecedaVELIKE = slovenskaAbecedaMALE.ToUpper();
            int[] steviloMalihCrk = new int [25];
            int[] steviloVelikihCrk = new int[25];
            int[] steviloStevil = new int[9];
            for (int a = 0; a < slovenskaAbecedaMALE.Length; a++)
            {
                for(int b = 0; b< nizZnakov.Length; b++)
                {
                    if (slovenskaAbecedaMALE[a] == nizZnakov[b]) { steviloMalihCrk[a]++; }
                    if (slovenskaAbecedaVELIKE[a] == nizZnakov[b]) { steviloVelikihCrk[a]++; }
                    if (a == 0 && nizZnakov[b] >= '0' && nizZnakov[b] <= '9') { stevecStevil++; }
                }
            }

            for (int v = 0; v <= 24; v++)
            {
                Console.WriteLine(slovenskaAbecedaMALE[v] + ": " + steviloMalihCrk[v]+"  "+slovenskaAbecedaVELIKE[v]+": "+steviloVelikihCrk[v]);
            }
            Console.WriteLine("Število števil, ki se pojavljajo v nizu je: " + stevecStevil);

                Console.ReadKey();


        }
    }
}
