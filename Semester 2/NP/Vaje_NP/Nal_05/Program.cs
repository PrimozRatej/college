using System;
using System.Collections.Generic;
using System.IO;
using Pot_Lib;

namespace Nal_05
{
    public class Program
    {


        static void infoIzlet(Izlet izlet)
        {
            string[] poljeNizov = new string[izlet.termini.Count];
            int stevec = 0;
            string path = @"C:\Users\Primož\Dropbox\College Life\2\NP\VAJE\Vaja6\Vaja6\SeznamPotnikovIzhod.csv";
            foreach (var termin in izlet.termini)
                poljeNizov[stevec++] = "Termin: " + termin.časOdhoda + " ima že " + termin.seznamPotnikov.Count + " potnikov.";

            File.WriteAllLines(path, poljeNizov);
        }
        public static Potnik Find(List<Potnik> seznam, string niz)
        {
            foreach (var potnik in seznam)
            {
                string cevNiz = potnik._priimek + potnik._email;
                if (cevNiz.Contains(niz)) return potnik;
            }
            return null;
        }
        public static Potnik NajstarejsiPotnik(List<Potnik> seznam)
        {
            DateTime min = DateTime.MaxValue;
            Potnik najstarejsiPotnik = new Potnik();
            foreach (var potnik in seznam)
            {
                if (potnik._datumRojstva < min)
                {
                    min = potnik._datumRojstva;
                    najstarejsiPotnik = potnik;
                }
            }
            return najstarejsiPotnik;
        }
        public static List<Potnik> parsajIzDatoteke()
        {


            List<Potnik> seznamPotnikov = new List<Potnik>();
            string path = @"C:\Users\Primož\Dropbox\College Life\2\NP\VAJE\Vaja6\Vaja6\SeznamPotnikov.csv";
            string[] lines = File.ReadAllLines(path);

            string output = "";
            for (int i = 1; i < lines.Length; i++)
            {
                string ime, priimek, spol, status, mail, datumr;
                string input = lines[i];
                string konec = lines[i];
                for (int j = 0; j < 5; j++)
                {
                    output = input.Substring(input.IndexOf(';') + 1);
                    input = output;
                }
                datumr = output;
                konec = konec.Replace(";" + datumr, "");
                input = konec;

                for (int j = 0; j < 4; j++)
                {
                    output = input.Substring(input.IndexOf(';') + 1);
                    input = output;
                }
                mail = output;
                konec = konec.Replace(";" + mail, "");
                input = konec;

                for (int j = 0; j < 3; j++)
                {
                    output = input.Substring(input.IndexOf(';') + 1);
                    input = output;
                }
                status = output;
                konec = konec.Replace(";" + status, "");
                input = konec;

                for (int j = 0; j < 2; j++)
                {
                    output = input.Substring(input.IndexOf(';') + 1);
                    input = output;
                }
                spol = output;
                konec = konec.Replace(";" + spol, "");
                input = konec;

                for (int j = 0; j < 1; j++)
                {
                    output = input.Substring(input.IndexOf(';') + 1);
                    input = output;
                }
                priimek = output;
                konec = konec.Replace(";" + priimek, "");
                input = konec;
                ime = konec;

                Potnik potnik = new Potnik();
                potnik._ime = ime;
                potnik._priimek = priimek;
                potnik._datumRojstva = parsajDatum(datumr);
                potnik._email = mail;
                if (spol == "M") potnik._spol = Spol.Moški;
                if (spol == "Z") potnik._spol = Spol.Ženska;
                if (status == "Student") potnik._status = Status.Študent;
                if (status == "Upokojenec") potnik._status = Status.Upokojenec;
                if (status == "Otrok") potnik._status = Status.Otrok;
                seznamPotnikov.Add(potnik);
            }
            return seznamPotnikov;

        }
        public static DateTime parsajDatum(string datum_niz)
        {

            string dan_niz = "";
            string mesec_niz = "";
            string leto_niz = "";
            int stevec = 0;
            for (int i = 0; i < datum_niz.Length; i++)
            {
                if (datum_niz[i] != '.')
                {
                    if (stevec == 0)
                    {
                        dan_niz += datum_niz[i];
                    }
                    if (stevec == 1)
                    {
                        mesec_niz += datum_niz[i];
                    }
                    if (stevec == 2)
                    {
                        leto_niz += datum_niz[i];
                    }

                }
                if (datum_niz[i] == '.') stevec++;
            }

            DateTime datum = new DateTime(int.Parse(leto_niz), int.Parse(mesec_niz), int.Parse(dan_niz));
            return datum;
        }

        static void Main(string[] args)
        {

            DateTime datumRojstva = new DateTime(1996, 9, 1);
            DateTime časOdhoda = new DateTime(2016, 4, 11);
            DateTime časPrihoda = new DateTime(2016, 4, 22);
            Voznik voznik = new Voznik("Primož", "Ratej", Spol.Moški, datumRojstva, časPrihoda);


            Avtobus avtobus0 = new Avtobus(45, 15, voznik, "MAN", "Velik avtobus", 25, 800);

            Avtobus[] seznamAvtobusov = new Avtobus[10];

            seznamAvtobusov[0] = avtobus0;

            //avtobus0.Izpis();
            //Študenti
            Potnik potnik_Š_0 = new Potnik("Primož", "Ratej", Spol.Moški, datumRojstva, "primozratej@student.um.si", Status.Študent);
            Potnik potnik_Š_1 = new Potnik("Teja", "Bincl", Spol.Ženska, datumRojstva, "tejabincl@student.um.si", Status.Študent);
            Potnik potnik_Š_2 = new Potnik("Patrik", "Šplajt", Spol.Moški, datumRojstva, "patrikšplajt@student.um.si", Status.Študent);
            Potnik potnik_Š_3 = new Potnik("Tadej", "Leva", Spol.Moški, datumRojstva, "tadejleva@student.um.si", Status.Študent);
            //Otroci
            Potnik potnik_O_0 = new Potnik("Primož", "Ratej", Spol.Moški, datumRojstva, "primozratej@student.um.si", Status.Otrok);
            Potnik potnik_O_1 = new Potnik("Teja", "Bincl", Spol.Ženska, datumRojstva, "tejabincl@student.um.si", Status.Otrok);
            Potnik potnik_O_2 = new Potnik("Patrik", "Šplajt", Spol.Moški, datumRojstva, "patrikšplajt@student.um.si", Status.Otrok);
            Potnik potnik_O_3 = new Potnik("Tadej", "Leva", Spol.Moški, datumRojstva, "tadejleva@student.um.si", Status.Otrok);
            //Upokojenci
            Potnik potnik_U_0 = new Potnik("Primož", "Ratej", Spol.Moški, datumRojstva, "primozratej@student.um.si", Status.Otrok);
            Potnik potnik_U_1 = new Potnik("Teja", "Bincl", Spol.Ženska, datumRojstva, "tejabincl@student.um.si", Status.Otrok);
            Potnik potnik_U_2 = new Potnik("Patrik", "Šplajt", Spol.Moški, datumRojstva, "patrikšplajt@student.um.si", Status.Otrok);
            Potnik potnik_U_3 = new Potnik("Tadej", "Leva", Spol.Moški, datumRojstva, "tadejleva@student.um.si", Status.Otrok);


            Termin termin1 = new Termin(časOdhoda, časPrihoda, avtobus0);
            Termin termin2 = new Termin(časOdhoda, časPrihoda, avtobus0);
            Termin termin3 = new Termin(časOdhoda, časPrihoda, avtobus0);

            Izlet izlet1 = new Izlet("Grčija", 100, "Celje planet tuš");
            Program program = new Program();

            izlet1.DodajTermin(termin1);

            izlet1.ProdajKarto(termin1, potnik_O_0);
            izlet1.ProdajKarto(termin1, potnik_O_1);
            izlet1.ProdajKarto(termin1, potnik_O_2);

            termin1.ObvestiPotnike();


            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
