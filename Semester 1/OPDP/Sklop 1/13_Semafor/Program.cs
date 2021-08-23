using System;

namespace semafor
{
    class Program
    {
        public static void Semafor(int dolZinaKvadrata, int barva)
        {
            Console.Clear();
            for (int sem = 1; sem <= 3; sem++)
            {
                int vrstica = 1;
                for (int a = 0; a < dolZinaKvadrata; a++)
                {
                    if (vrstica == 1)
                    {
                        Console.ForegroundColor = System.ConsoleColor.Blue;
                        for (int u = 0; u < dolZinaKvadrata; u++) { Console.Write("*"); }
                        Console.WriteLine();
                    }
                    if (vrstica != 1 && vrstica != dolZinaKvadrata)
                    {
                        Console.ForegroundColor = System.ConsoleColor.Blue;
                        Console.Write("*");
                        for (int g = 0; g < dolZinaKvadrata - 2; g++)
                        {
                            if (barva == 3 && sem == 3)
                            {
                                Console.ForegroundColor = System.ConsoleColor.Green;
                            }
                            else if (barva == 2 && sem == 2)
                            {
                                Console.ForegroundColor = System.ConsoleColor.Yellow;
                            }
                            else if (barva == 1 && sem == 1)
                            {
                                Console.ForegroundColor = System.ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = System.ConsoleColor.White;
                            }
                            Console.Write("*");
                        }
                        Console.ForegroundColor = System.ConsoleColor.Blue;
                        Console.Write("*");
                        Console.WriteLine();
                    }
                    if (vrstica == dolZinaKvadrata)
                    {
                        Console.ForegroundColor = System.ConsoleColor.Blue;
                        for (int u = 0; u < dolZinaKvadrata; u++) { Console.Write("*"); }
                        Console.WriteLine();
                    }
                    vrstica++;
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            int velikost = 0;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Vpiši velikost kvadrata, ki bo soda in bo vrednost med 4 in 20");
                velikost = int.Parse(Console.ReadLine());
                if (velikost % 2 == 0 && velikost >= 4 && velikost <= 20) { break; }
            }
            Semafor(velikost,0);
            while (true)
            {
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.WriteLine("----Možnosti semaforja----");
                Console.WriteLine("--Rdeči semafor (Rdeci)---");
                Console.WriteLine("--Zeleni semafor (Zeleni)-");
                Console.WriteLine("----Rumeni (Rumeni)-------");
                Console.WriteLine("----Utripaj (Utripaj)-------");
                Console.WriteLine("------Konec (Konec)-------");
                string vrsta = Console.ReadLine();

                if (vrsta == "Rdeci") { Semafor(velikost,1); }
                if (vrsta == "Zeleni") { Semafor(velikost, 3); }
                if (vrsta == "Rumeni") { Semafor(velikost, 2); }
                if (vrsta == "Utripaj")
                {
                    Semafor(velikost, 2);
                    for (int i = 0; i < 3; i++)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Semafor(velikost, 0);
                        System.Threading.Thread.Sleep(1000);
                        Semafor(velikost, 2);
                    }
                    Semafor(velikost, 0);
                }
                if (vrsta == "Konec") { break; }
            }          
            Console.ReadKey();
        }
    }
}