//Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/*Izdelajte postopek, ki bo izračunal obseg pravokotnika. Vhodna parametra sta dolžini obeh stranic (a ter b). 
Postopek naj preveri, ali sta vhodna podatka veljavna (večja od nič). 
V primeru vpisa napačnih vhodnih vrednosti naj namesto rezultata izpiše opozorilo o napaki.*/

using System;

namespace PloscinaPravokotnika_Vaja1_OPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dolzina prve stranice a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Dolzina druge stranice b");
            double b = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Dolžine stranic so neveljavne");
            }
            else
            {
                double obsegPravokotnika = 2*a + 2*b;
                Console.WriteLine("Obseg pravokotnika je {0} ", obsegPravokotnika);
                
            }
            Console.ReadKey();
        }
    }
}
