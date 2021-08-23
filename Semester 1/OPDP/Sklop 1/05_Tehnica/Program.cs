////Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/*Izdelajte postopek, ki bo izračunal skupno in povprečno težo sedmih sadežev. 
Če je kateri od sadežev lažji od 85 gramov ali težji od 177 gramov, se takšen sadež izloči in se v izračunih ne upošteva. 
Postopek naj na začetku prečita sedem vrednosti in na koncu izpiše rezultata računanja (v kolikor je to seveda mogoče).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sadezi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vnos sedmih sadežev 
            Console.WriteLine("Vnos 1. sadeža");
            double sadež1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnos 2. sadeža");
            double sadež2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnos 3. sadeža");
            double sadež3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnos 4. sadeža");
            double sadež4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnos 5. sadeža");
            double sadež5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnos 6. sadeža");
            double sadež6 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnos 7. sadeža");
            double sadež7 = double.Parse(Console.ReadLine());

            double sestevek = 0;
            double povprecnaTeza = 0;
            int steviloPravilnihVnosov = 0;
            // če je kateri izmed sadežev manjši od od 85 in večji od 177 ga v izračun ne upoštevamo
            // če vnos ustreza izračun povprečne teže in skupne teže za vse sadeže.
            if (sadež1 >= 85 && sadež1 <= 177) { sestevek = sestevek + sadež1; steviloPravilnihVnosov++; povprecnaTeza = sestevek / steviloPravilnihVnosov; }
            if (sadež2 >= 85 && sadež2 <= 177) { sestevek = sestevek + sadež2; steviloPravilnihVnosov++; povprecnaTeza = sestevek / steviloPravilnihVnosov; }
            if (sadež3 >= 85 && sadež3 <= 177) { sestevek = sestevek + sadež3; steviloPravilnihVnosov++; povprecnaTeza = sestevek / steviloPravilnihVnosov; }
            if (sadež4 >= 85 && sadež4 <= 177) { sestevek = sestevek + sadež4; steviloPravilnihVnosov++; povprecnaTeza = sestevek / steviloPravilnihVnosov; }
            if (sadež5 >= 85 && sadež5 <= 177) { sestevek = sestevek + sadež5; steviloPravilnihVnosov++; povprecnaTeza = sestevek / steviloPravilnihVnosov; }
            if (sadež6 >= 85 && sadež6 <= 177) { sestevek = sestevek + sadež6; steviloPravilnihVnosov++; povprecnaTeza = sestevek / steviloPravilnihVnosov; }
            if (sadež7 >= 85 && sadež7 <= 177) { sestevek = sestevek + sadež7; steviloPravilnihVnosov++; povprecnaTeza = sestevek / steviloPravilnihVnosov; }
            // Izpis skupne in povprečne teže za dovoljene sadeže.    
            Console.WriteLine("Skupna teža vseh veljavnih sadežev je {0}g", sestevek);
            Console.WriteLine("Povprečna teža vseh veljavnih sadežev je {0}g",povprecnaTeza);

                
            

            Console.ReadKey();



        }
    }
}
