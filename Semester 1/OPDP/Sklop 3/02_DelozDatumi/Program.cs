using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelozDatumi
{
    public struct datum
    {
        public static int dan;
        public static int mesec;
        public static int leto;

        public static void Vpis()
        {
            Console.WriteLine("Vpiši dan:");
            int tempDan = int.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši mesec:");
            int tempMesec = int.Parse(Console.ReadLine());
            Console.WriteLine("Vpiši leto:");
            int templeto = int.Parse(Console.ReadLine());
            if (Program.pravilnostDatumaNaIntervalu(tempDan, tempMesec, templeto) == true)
            {
                dan = tempDan;
                mesec = tempMesec;
                leto = templeto;
            }
            else Console.WriteLine("Napaka pri vpisu.");
        }

        
    }

    
    class Program
    {
        public static bool pravilnostDatumaNaIntervalu(int dan, int mesec, int leto)
        {
            bool pravilnost = true;
            if (dan < 1 && dan > 31) pravilnost = false;
            if (mesec < 1 && mesec > 12) pravilnost = false;
            if (leto < 1584) pravilnost = false;
            return pravilnost;
        }

        static void Main(string[] args)
        {
            datum.Vpis();
            Console.WriteLine(datum.dan + "." + datum.mesec + "." + datum.leto);
            Console.ReadKey();
        }
    }
}
