//Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/*Izdelajte postopek, ki izračuna površino in volumen pokončnega krožnega stožca.
 *Vhodna podatka sta premer (d) osnovne ploskve stožca ter njegova višina (v). 
 *Postopek naj preveri, ali sta vhodna podatka veljavna (večja od nič). 
 *V primeru vpisa napačnih vhodnih vrednosti naj namesto rezultata izpiše opozorilo o napaki. 
 *Za PI morate uporabiti uporabniško definirano konstanto (na 6 decimalk natančno).*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valj2
{
    class RatejCvahte_Primož_E1089978_naloga2_sklop1
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine()); //premer osnovne ploskve
            double v = double.Parse(Console.ReadLine()); //višina valja
            double r = d/2; //polmer 
            const double pi = 3.141592;

            if(d>0)
            {
                double površinaValja;
                površinaValja = (2*r*pi)*v+(pi*r*r*2);// površina valja
                Console.WriteLine("Površina valja je {0}cm^2", površinaValja);
                double volumenValja;
                volumenValja = r * r * pi * v;// volumen valja
                Console.WriteLine("Volumen valja je {0}cm^2", volumenValja);
            }
            else { Console.WriteLine("Napačno vnešena dolžina"); } // če je število manjše ali enako 0 se izpiše napaka.

            Console.ReadKey();  
            
        }
    }
}
