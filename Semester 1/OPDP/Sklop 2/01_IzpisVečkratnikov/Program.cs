using System;

namespace veckratnik
{
    class Program
    {
        static public int veckratniki(int a)
        {
            int veckratnik = a * 5;
            return veckratnik;

        }
        static void Main()
        {
            for (int a = 1; a <= 800; a++)
                Console.Write(veckratniki(a) + ", "); Console.ReadKey();

        }
    }
}
