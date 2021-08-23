//Primož Ratej Cvahte, ITK 1 - VS, Št.indexa: E1089978
/* Potrebno je implementirati:

podprogram za pretvorbo iz naravnega v osmiško število,
podprogram za pretvorbo iz osmiškega v naravno število,
podprogram za izračun vsote dveh osmiških števil.
Prvi podprogram prejme naravno število in ga pretvori v osmiško število ter ga vrne [v obliki niza znakov].
Drugi podprogram prejme osmiško število [v obliki niza znakov], ga pretvori v naravno število ter ga vrne.
Tretji podprogram prejme dve osmiški števki [dva niza znakov] ter izračuna in vrne vsoto teh dveh osmiških števil [v obliki niza znakov].

V glavnem programu boste uporabniku ponudili izbiro podprograma, ki naj se izvrši. Poskrbite, da bo uporabnik pri posamezni izbiri vpisal samo tisto, kar izbrani podprogram zahteva (v primeru, da je zahtevan vpis osmiškega števila in uporabnik vpiše kakšen znak, ki mu ne pripada, naj se izpiše napaka). Rezultat, ki ga vrne podprogram, v glavnem programu nato izpišite uporabniku.

Opomba: pri 3. podprogramu, si lahko pomagate z uporabo 1. in 2. podprograma.
Opomba 2: metod, ki samodejno pretvarjajo števila med posameznimi številskimi osnovami, ni dovoljeno uporabiti (npr. Convert.ToInt32()). Lahko jih uporabite samo v primeru, če jih implementirate sami. */
using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static string Iz10v8(int število)
        {
            string osmiškoŠtevilo = null;
            int ostanek = 0;
            int celoštevilo = število;
            if (celoštevilo != 0)
            {
                while (celoštevilo != 0) // računanje ostankov števila ter leplenje nizov skupaj
                {
                    ostanek = celoštevilo % 8;
                    celoštevilo = celoštevilo / 8;
                    osmiškoŠtevilo = osmiškoŠtevilo + ostanek;
                }
                string obrnjenoŠtevilo = null;
                for (int i = osmiškoŠtevilo.Length - 1; i >= 0; i--) //Vendar je zapis v obratnem vrstnem redu zato jih zapišemo od zadaj naprej (obrnemo niz)
                {
                    obrnjenoŠtevilo = obrnjenoŠtevilo + osmiškoŠtevilo[i];
                }
                osmiškoŠtevilo = obrnjenoŠtevilo;
            }
            else osmiškoŠtevilo = "0";
            return osmiškoŠtevilo;
        }
        public static int Iz8v10(string število8)
        {
            int število10 = 0;
            string obrnjenoŠtevilo = null;
            for (int i = število8.Length - 1; i >= 0; i--) // najprej število obrnemo da bomo lahko zračunali desetiško po utežeh
            {
                obrnjenoŠtevilo = obrnjenoŠtevilo + število8[i];
            }

            int[] polje8števil = števila(obrnjenoŠtevilo); // z funkcijo pretvorimo števila v posamezne števke
            for (int i = 0; i < obrnjenoŠtevilo.Length; i++)
            {
                število10 = število10 + (polje8števil[i] * Pow(8, i)); // nato izračunamo vsoto polinoma ki nastane po utežeh, ki so določene
            }

            return število10;

        }

        public static int[] števila(string število)
        {
            //Ta funkcija se uporablja da niz znakov premenimo v polje števil za pretvorbo
            int[] polještevilo = new int[število.Length];

            for (int i = 0; i < število.Length; i++)
            {
                polještevilo[i] = int.Parse("0"+število[i]); // da shranimo niz znakov ne pa int uporabimo trik
            }

            return polještevilo;
        }
        public static int Pow(int osnova, int stopnja) 
        {
            // funkcija za izračun potence nekega števila vrne pa celo število
            int rezultat = 1; // začnemo z 1 zaradi množenja ne sme biti 0, ter če pride do potence 0 vrnemo 1 kar je pravilno
            for (int i = 1; i <= stopnja; i++)
			{
			    rezultat = rezultat*osnova;
			}
            return rezultat;
        }
        public static bool SoŠtevila(string število)
        {
            // funkcija ki nam pove če so vsa števila v nizu res števila 10-tiškega sistema 1-9
            bool pravilnost = true;
            for (int i = 0; i < število.Length; i++)
            {
                if(število[i]<'0'||število[i]>'9')
                {
                    pravilnost = false;
                    break;
                }
            }
            return pravilnost;
        }
        static void Main(string[] args)
        {
            // izris menija in njegove možnosti
            Console.WriteLine("-----PRETVORNIK MED ŠTEVILSKIMI SESTAVI (decimal-octal)-----");
            Console.WriteLine("-----Iz desetiškega v osmiški ukaz: 10in8              -----");
            Console.WriteLine("-----Iz osmiškega v desetiški ukaz: 8in10              -----");
            Console.WriteLine("-----Za izracun vsote dveh osmiških števil: sestevanje8in8--");
            Console.WriteLine("-----Za zaključitev programa ukaz: KONEC               -----");
            Console.WriteLine("------------------------------------------------------------");
            string ukaz = null;
            while (ukaz != "KONEC") // ob ukazu KONEC se delovanje programa konča
            {
                ukaz = Console.ReadLine();
                // delovanje programa je logično za naprej Za vsako funcijo posebej preverjamo če so števila v nizu res števila
                switch (ukaz)
                {
                    case "10in8":
                        Console.WriteLine("Vpiši desetiško število: ");
                        string število10 = Console.ReadLine();
                        if (SoŠtevila(število10) == false) Console.WriteLine("Napaka");
                        else
                        {
                            int število10Int = int.Parse(število10);
                            Console.WriteLine("Desetiško število je " + število10 + " njegovo osmiško število je " + Iz10v8(število10Int));
                        }
                        break;

                    case "8in10":
                        Console.WriteLine("Vpiši osmiško število: ");
                        string število8 = Console.ReadLine();
                        if (SoŠtevila(število8) == false) Console.WriteLine("Napaka");
                        else
                        {
                            Console.WriteLine("Osmiško število je " + število8 + " njegovo desetiško število je " + Iz8v10(število8));
                        }
                        break;
                        // pri seštevanju dveh osmiških števil si pomagamo s pretvorbo v desetiško in nazaj v osmiško.
                    case "sestevanje8in8":
                        Console.WriteLine("Vnesi prvo osmiško število: ");
                        string oct1 = Console.ReadLine();
                        Console.WriteLine("Vnesi drugo osmiško število: ");
                        string oct2 = Console.ReadLine();
                        string tempoc12 = oct1 + oct2;
                        if (SoŠtevila(tempoc12) == false) Console.WriteLine("Napaka");
                        else
                        {
                            int prvo10 = Iz8v10(oct1);
                            int drugo10 = Iz8v10(oct2);
                            int rezulta = prvo10 + drugo10;
                            Console.WriteLine("Seštevek osmiških števil " + oct1 + " in " + oct2 + " je " + Iz10v8(rezulta));
                        }

                        break;

                }
            }

        }
    }
}
