using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga10
{
    class Program
    {
        static void Main(string[] args)
        {
            int vrednost1, vrednost2, vrednost3, vrednost4;
            Console.WriteLine("1. vrednost: 0 - sodo, 1 - liho, 2 - ni bilo stave");
            vrednost1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. vrednost: 0 - nizko, 1 - visoko, 2 - ni bilo stave");
            vrednost2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3. vrednost: 0 - rdeče, 1 - črno, 2 - ni bilo stave");
            vrednost3 = int.Parse(Console.ReadLine());
            Console.WriteLine("4. vrednost: 0 - zeleno, 2 - ni bilo stave.");
            vrednost4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število");
            int dobitek = 0;
            int steviloStavljenihZetonov = 0;
            int stevilo = int.Parse(Console.ReadLine());
            if (stevilo >= 0 && stevilo <= 36)
            {
                if (stevilo != 0)
                {
                    if (stevilo % 2 == 0 && vrednost1 == 0) { dobitek = dobitek + 2; steviloStavljenihZetonov++; }
                    if (stevilo % 2 == 0 && vrednost1 == 1) { dobitek = dobitek - 1; steviloStavljenihZetonov++; }

                    if (stevilo % 2 == 1 && vrednost1 == 1) { dobitek = dobitek + 2; steviloStavljenihZetonov++; }
                    if (stevilo % 2 == 1 && vrednost1 == 0) { dobitek = dobitek - 1; steviloStavljenihZetonov++; }


                    if (stevilo <= 18 && vrednost2 == 0) { dobitek = dobitek + 2; steviloStavljenihZetonov++; }
                    if (stevilo <= 18 && vrednost2 == 1) { dobitek = dobitek - 1; steviloStavljenihZetonov++; }

                    if (stevilo >= 19 && vrednost2 == 1) { dobitek = dobitek + 2; steviloStavljenihZetonov++; }
                    if (stevilo >= 19 && vrednost2 == 0) { dobitek = dobitek - 1; steviloStavljenihZetonov++; }


                    // je rdeče 
                    if (stevilo == 1 || stevilo == 3 || stevilo == 5 || stevilo == 7 || stevilo == 9 || stevilo == 12 || stevilo == 14 || stevilo == 16 || stevilo == 18 || stevilo == 21 || stevilo == 23 || stevilo == 25 || stevilo == 27 || stevilo == 28 || stevilo == 30 || stevilo == 32 || stevilo == 34 || stevilo == 36)
                    {
                        if (vrednost3 == 0) { dobitek = dobitek + 2; steviloStavljenihZetonov++; }
                    }
                    if (stevilo == 1 || stevilo == 3 || stevilo == 5 || stevilo == 7 || stevilo == 9 || stevilo == 12 || stevilo == 14 || stevilo == 16 || stevilo == 18 || stevilo == 21 || stevilo == 23 || stevilo == 25 || stevilo == 27 || stevilo == 28 || stevilo == 30 || stevilo == 32 || stevilo == 34 || stevilo == 36)
                    {
                        if (vrednost3 == 1) { dobitek = dobitek - 1; steviloStavljenihZetonov++; }
                    }

                    // je črno
                    if (stevilo == 2 || stevilo == 4 || stevilo == 6 || stevilo == 8 || stevilo == 10 || stevilo == 11 || stevilo == 13 || stevilo == 15 || stevilo == 17 || stevilo == 19 || stevilo == 20 || stevilo == 22 || stevilo == 24 || stevilo == 26 || stevilo == 29 || stevilo == 31 || stevilo == 33 || stevilo == 35)
                    {
                        if (vrednost3 == 1) { dobitek = dobitek + 2; steviloStavljenihZetonov++; }
                    }

                    if (stevilo == 2 || stevilo == 4 || stevilo == 6 || stevilo == 8 || stevilo == 10 || stevilo == 11 || stevilo == 13 || stevilo == 15 || stevilo == 17 || stevilo == 19 || stevilo == 20 || stevilo == 22 || stevilo == 24 || stevilo == 26 || stevilo == 29 || stevilo == 31 || stevilo == 33 || stevilo == 35)
                    {
                        if (vrednost3 == 0) { dobitek = dobitek - 1; steviloStavljenihZetonov++; }
                    }

                }

                if(stevilo == 0 && vrednost4 == 0)
                {
                    dobitek = dobitek + 35; steviloStavljenihZetonov++;
                }
                
                if (stevilo == 0 && vrednost1 == 0) { dobitek = dobitek - 1; }
                if (stevilo == 0 && vrednost2 == 0) { dobitek = dobitek - 1; }
                if (stevilo == 0 && vrednost3 == 0) { dobitek = dobitek - 1; }

                if(dobitek <= 0)
                {
                    dobitek = 0;
                }
                Console.WriteLine("Število stavljenih žetonov je {0} število vrnejnih žetonov je {1}",steviloStavljenihZetonov, dobitek);
                Console.ReadKey();

            }
        }
    }
}
                