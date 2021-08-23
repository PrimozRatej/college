//Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/*Izdelajte postopek, ki bo prebral znesek v eurih in izpisal, koliko posameznih denarnih enot je potrebnih za izplačilo tega zneska 
 * (apoenov po 500/200/100/50/20/10/5 eurov, kovancev za 2/1 euro ter kovancev za 50/20/10/5/2/1 centov). Predpostavite lahko,
 * da bo uporabnik vedno vpisal znesek, ki bo imel največ dve decimalni mesti. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga12
{
    class RatejCvahte_Primož_E1089978_naloga12_sklop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši koliko denarja bi rad raztavil na apoene.");
            
            double kolicina = double.Parse(Console.ReadLine());
            if (kolicina >= 0)
            {
                Console.WriteLine();
                int večjiDel = (int)kolicina; // odrežemo decimalni del 
                int manjšidel = Convert.ToInt32((kolicina - večjiDel) * 100); // decimalni del cente pretvorimo v celo število

                // Izračun za celi del eure
                int kolicinaApeonov = večjiDel / 500; 
                int ostanek = večjiDel % 500;
                večjiDel = ostanek;
                Console.WriteLine("500: {0}", kolicinaApeonov);

                kolicinaApeonov = večjiDel / 200;
                ostanek = večjiDel % 200;
                večjiDel = ostanek;
                Console.WriteLine("200: {0}", kolicinaApeonov);

                kolicinaApeonov = večjiDel / 100;
                ostanek = večjiDel % 100;
                večjiDel = ostanek;
                Console.WriteLine("100: {0}", kolicinaApeonov);

                kolicinaApeonov = večjiDel / 50;
                ostanek = večjiDel % 50;
                večjiDel = ostanek;
                Console.WriteLine("50: {0}", kolicinaApeonov);

                kolicinaApeonov = večjiDel / 20;
                ostanek = večjiDel % 20;
                večjiDel = ostanek;
                Console.WriteLine("20: {0}", kolicinaApeonov);

                kolicinaApeonov = večjiDel / 10;
                ostanek = večjiDel % 10;
                večjiDel = ostanek;
                Console.WriteLine("10: {0}", kolicinaApeonov);

                kolicinaApeonov = večjiDel / 5;
                ostanek = večjiDel % 5;
                večjiDel = ostanek;
                Console.WriteLine("5: {0}", kolicinaApeonov);

                kolicinaApeonov = večjiDel / 2;
                ostanek = večjiDel % 2;
                večjiDel = ostanek;
                Console.WriteLine("2: {0}", kolicinaApeonov);

                kolicinaApeonov = večjiDel / 1;
                ostanek = večjiDel % 1;
                večjiDel = ostanek;
                Console.WriteLine("1: {0}", kolicinaApeonov);

                // Izračun za decimalni del cente
                kolicinaApeonov = manjšidel / 50;
                ostanek = manjšidel % 50;
                manjšidel = ostanek;
                Console.WriteLine("0,50: {0}", kolicinaApeonov);

                kolicinaApeonov = manjšidel / 20;
                ostanek = manjšidel % 20;
                manjšidel = ostanek;
                Console.WriteLine("0,20: {0}", kolicinaApeonov);

                kolicinaApeonov = manjšidel / 10;
                ostanek = manjšidel % 10;
                manjšidel = ostanek;
                Console.WriteLine("0,10: {0}", kolicinaApeonov);

                kolicinaApeonov = manjšidel / 5;
                ostanek = manjšidel % 5;
                manjšidel = ostanek;
                Console.WriteLine("0,05: {0}", kolicinaApeonov);

                kolicinaApeonov = manjšidel / 2;
                ostanek = manjšidel % 2;
                manjšidel = ostanek;
                Console.WriteLine("0,02: {0}", kolicinaApeonov);

                kolicinaApeonov = manjšidel / 1;
                ostanek = manjšidel % 1;
                manjšidel = ostanek;
                Console.WriteLine("0,01: {0}", kolicinaApeonov);
            }
            else
                Console.WriteLine("Napaka6");
            

            
      


            Console.ReadKey();


        }
    }
}
