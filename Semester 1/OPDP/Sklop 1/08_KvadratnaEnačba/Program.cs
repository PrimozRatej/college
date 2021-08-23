//Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/*Izdelajte postopek, ki poišče vse realne rešitve kvadratne enačbe a*x2+b*x+c=0. Vhodni podatki so vrednosti a, b in c. 
 * Postopek naj izpiše, koliko realnih ničel ima kvadratna enačba (nobeno, eno ali dve). Nato naj rešitve izračuna in jih izpiše.
Opomba: dovoljena je uporaba Math.Sqrt(double).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga8
{
    class RatejCvahte_Primož_E1089978_naloga8_sklop1
    {
        static void Main(string[] args)
        {
            double a, b, c, diskriminanta; // Vhodni podatki a,b,c in diskriminanta
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if (a != 0) // vrednost a-ja nesme nikoli biti 0 saj lahko pride do deljenja z 0.
            {
                diskriminanta = b * b - 4 * a * c; //izračun diskriminante
                if (diskriminanta > 0) // če je diskriminanta večja od 0 pomeni da ima 2 ničli
                {

                    Console.WriteLine("Ničli sta 2 ");
                    double x1 = (-b + Math.Sqrt(diskriminanta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(diskriminanta)) / (2 * a);
                    Console.Write("to sta števili {0} in {1} na x osi.", x1, x2);

                }
                if (diskriminanta == 0) // če je diskriminanta 0 pomeni da se funkcija dotika x osi in imamo samo eno ničlo
                {
                    Console.WriteLine("Ničli sta enaki zato ima funcija samo eno realno ničlo");
                    double x1 = (-b + Math.Sqrt(diskriminanta)) / (2 * a);
                    Console.Write("in to je število {0} na x osi", x1);
                }
                if (diskriminanta < 0) // če je diskriminanta manjša od nič pomeni da je graf funkcije pomaknjen višje po y osi in se ne dotika in niti ne seka x osi
                {
                    Console.WriteLine("Ničla med realnimi števili na x osi ne obstaja.");
                }
            }
            else
            {
                Console.WriteLine("Neveljavna kvadratna enačba zaradi deljenja s številom 0.");
            }
            Console.ReadKey();
        }
    }
}
