//Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/*Izdelajte postopek, ki bo določil drugo najvišjo osebo (uporabnik vnese velikosti štirih oseb v centimetrih).
 *Če je katera izmed vpisanih vrednosti manjša od 48, naj se izpiše opozorilo o prekoračitvi spodnje mejne vrednosti. 
 *V tem primeru se naj druge najvišje velikosti osebe ne izpiše. V kolikor sta vneseni vsaj dve velikosti, ki sta višji od 251, naj se izpiše obvestilo o napaki.
  Postopek naj na začetku prečita štiri vrednosti in na koncu izpiše ali drugo najvišjo osebo ali opozorilo ali pa obvestilo o napaki.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga6
{
    class RatejCvahte_Primož_E1089978_naloga6_sklop1
    {
        static void Main(string[] args)
        {
            
                double oseba1, oseba2, oseba3, oseba4;
                oseba1 = double.Parse(Console.ReadLine());
                oseba2 = double.Parse(Console.ReadLine());
                oseba3 = double.Parse(Console.ReadLine());
                oseba4 = double.Parse(Console.ReadLine());

                if (oseba1 >= 48 && oseba2 >= 48 && oseba3 >= 48 && oseba4 >= 48)
                {
                    if (oseba1 > 251 && oseba2 > 251 || oseba1 > 251 && oseba3 > 251 || oseba1 > 251 && oseba4 > 251 || oseba2 > 251 && oseba3 > 251 || oseba2 > 251 && oseba4 > 251 || oseba3 > 251 && oseba4 > 251)
                    {
                        Console.WriteLine("Napaka");
                    }
                    else
                    {
                        if (oseba1 < oseba2 && oseba1 > oseba3 && oseba1 > oseba4 || oseba1 > oseba2 && oseba1 < oseba3 && oseba1 > oseba4 || oseba1 > oseba2 && oseba1 > oseba3 && oseba1 < oseba4) { Console.WriteLine("Druga najvišja oseba je prva oseba meri {0}cm", oseba1); }
                        if (oseba2 < oseba1 && oseba2 > oseba3 && oseba2 > oseba4 || oseba2 > oseba1 && oseba2 < oseba3 && oseba2 > oseba4 || oseba2 > oseba1 && oseba2 > oseba3 && oseba2 < oseba4) { Console.WriteLine("Druga najvišja oseba je druga oseba meri {0}cm", oseba2); }
                        if (oseba3 < oseba2 && oseba3 > oseba1 && oseba3 > oseba4 || oseba3 > oseba2 && oseba3 < oseba1 && oseba3 > oseba4 || oseba3 > oseba2 && oseba3 > oseba1 && oseba3 < oseba4) { Console.WriteLine("Druga najvišja oseba je tretja oseba meri {0}cm", oseba3); }
                        if (oseba4 < oseba2 && oseba4 > oseba3 && oseba4 > oseba1 || oseba4 > oseba2 && oseba4 < oseba3 && oseba4 > oseba1 || oseba4 > oseba2 && oseba4 > oseba3 && oseba4 < oseba1) { Console.WriteLine("Druga Najvišja oseba je četrta oseba meri {0}cm", oseba4); }
                    }
                }
                else
                {
                    Console.WriteLine("Prekoračitev spodnje meje vrednosti");
                }


                Console.ReadKey();
            
        }
    }
}
