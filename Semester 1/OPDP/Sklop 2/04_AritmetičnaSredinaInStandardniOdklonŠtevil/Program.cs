using System;

namespace ConsoleApp1
{
    class Program
    {
        public static double Povprečje(double vsota, int številoŠtevil)
        {
            double povprečje = vsota / številoŠtevil;
            return povprečje;
        }

        public static double StandardiOdklon(double vsota, int številoŠtevil, double[] stevila)
        {
            double povprecje = Povprečje(vsota, številoŠtevil);
            double mnozenje = 0;
            for (int a = 0; a <= stevila.Length - 1; a++)
            {
                if (stevila[a] == 0) { break; }
                mnozenje = mnozenje + (povprecje - stevila[a]) * (povprecje - stevila[a]);

            }
            double standardiOdklon = Math.Sqrt(mnozenje / številoŠtevil);
            return standardiOdklon;
        }

        static void Main(string[] args)
        {
            double vsota = 0;
            int številoŠtevil = 0;
            double[] stevila = new double[10];
            Console.WriteLine("Vnesi 10 števil");
            for (int a = 0; a <= 9; a++)
            {
                stevila[a] = double.Parse(Console.ReadLine());
                if (stevila[a] == 0) break;
                številoŠtevil++;
                vsota = vsota + stevila[a];
            }
            if (stevila[0] != 0)
            {
                Console.WriteLine("Povprečje števil je: " + Povprečje(vsota, številoŠtevil));
                Console.WriteLine("Standardni odklon števil je: " + StandardiOdklon(vsota, številoŠtevil, stevila));
            }
            else Console.WriteLine("Program ne more izračunati povprečja in odklona števil če nima števil s katerimi bi operiral.");
            Console.ReadKey();

        }
    }
}
