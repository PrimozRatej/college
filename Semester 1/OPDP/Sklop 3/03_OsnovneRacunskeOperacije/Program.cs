using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static double sestevanje (double a, double b)
        {
            double sestevek;
            sestevek = a + b;
            return sestevek;
        }
        public static double mnozenje (double a, double b)
        {
            double zmnozek;
            zmnozek = a * b;
            return zmnozek;
        }

        public static double deljenje (double a, double b)
        {
            double kolicnik;
            kolicnik = a/b;
            return kolicnik;
        }

        public static double odstevanje(double a, double b)
        {
            double razlika;
            razlika = a - b;
            return razlika;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sestevanje(mnozenje(5, 5), 5));
            Console.ReadKey();
        }
    }
}

