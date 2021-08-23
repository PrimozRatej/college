using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot_Lib
{
    public class Avtobus : Vozilo
    {
        int skupnoŠteviloSedežev;
        int skupnoŠteviloStojišč;
        int številoPotnikovNaAvtobusu;

        public Avtobus()
        {
            skupnoŠteviloSedežev = 0;
            skupnoŠteviloStojišč = 0;
            številoPotnikovNaAvtobusu = 0;
        }

        public int _maxŠteviloPotnikov()
        {
            return skupnoŠteviloSedežev + skupnoŠteviloStojišč;
        }

        public Avtobus(int številoPotnikovNaAvtobusu)
        {
            this.številoPotnikovNaAvtobusu = številoPotnikovNaAvtobusu;
        }

        public int _skupnoŠteviloSedežev { get { return skupnoŠteviloSedežev; } set { skupnoŠteviloSedežev = value; } }
        public int _skupnoŠteviloStojišč { get { return _skupnoŠteviloStojišč; } set { skupnoŠteviloStojišč = value; } }
        public int _številoPotnikovNaAvtobusu { get { return številoPotnikovNaAvtobusu; } set { številoPotnikovNaAvtobusu = value; } }

        public Avtobus(int skupnoŠteviloSedežev, int skupnoŠteviloStojišč, int številoPotnikovNaAvtobusu, Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
            : base(voznik, znamka, tip, porabaGorivaNa100km, velikostRezervarja)
        {
            this.skupnoŠteviloSedežev = skupnoŠteviloSedežev;
            this.številoPotnikovNaAvtobusu = številoPotnikovNaAvtobusu;
            this.skupnoŠteviloStojišč = skupnoŠteviloStojišč;
        }

        public Avtobus(int skupnoŠteviloSedežev, int skupnoŠteviloStojišč, Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
            : base(voznik, znamka, tip, porabaGorivaNa100km, velikostRezervarja)
        {
            this.skupnoŠteviloSedežev = skupnoŠteviloSedežev;
            this.skupnoŠteviloStojišč = skupnoŠteviloStojišč;
        }

        public override void Izpis()
        {
            Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}\nskupno Število Sedežev: {4}\nskupno Število Stojišč: {5} \nštevilo Potnikov Na Avtobusu: {6}", _znamka, _tip, _porabaGorivaNa100km, _velikostRezervarja, skupnoŠteviloSedežev, skupnoŠteviloStojišč, številoPotnikovNaAvtobusu);
        }

        public override double zasedenostVozila()
        {
            double zasedenostVozila = (skupnoŠteviloStojišč + skupnoŠteviloSedežev) / številoPotnikovNaAvtobusu * 100;
            return zasedenostVozila;
        }
    }
}
