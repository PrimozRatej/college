//Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/*Izdelajte postopek, ki izračuna dolžino hipotenuze pravokotnega trikotnika (uporabite Pitagorov izrek). 
Vhodni podatki so dolžine vseh treh stranic (a, b in c). Postopek naj preveri, 
ali so vhodni podatki veljavni (večji od nič) ter če vpisane dolžine stranic res tvorijo trikotnik s pravim kotom. 
V primeru napačnih vrednosti vhodnih podatkov ali pa da stranice ne tvorijo pravokotnega trikotnika naj se namesto rezultata izpiše opozorilo o napaki.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UporabaPitagorovegaIzreka
{
    class RatejCvahte_Primož_E1089978_naloga7_sklop1
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Vpiši dolžino katete a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši dolžino katete b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši dolžino hipotenuze c: ");
            c = double.Parse(Console.ReadLine());
            double hipotenuza = 0;
             if (a>0 && b>0 && c>0)
             {
                 hipotenuza = Math.Sqrt(a * a + b * b);
                 if (hipotenuza == c)
                 {
                     Console.WriteLine("Dolžina hipotenuze je {0}", hipotenuza);
                 }
                 else Console.WriteLine("Nepravilne dolžine stranic!");

             }
             else Console.WriteLine("Nepravilne dolžine stranic!");

            Console.ReadKey();

        }
    }
}
