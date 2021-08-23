using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot_Lib
{
    public class Kombi : Vozilo
    {
        double masaNaloženegaTovora;
        double maksimalnaMasaTovora;

        public Kombi()
        {
            masaNaloženegaTovora = 0;
            maksimalnaMasaTovora = 0;
        }

        public Kombi(double masaNaloženegaTovora, double maksimalnaMasaTovora, Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
            : base(voznik, znamka, tip, porabaGorivaNa100km, velikostRezervarja)
        {
            this.masaNaloženegaTovora = masaNaloženegaTovora;
            this.maksimalnaMasaTovora = maksimalnaMasaTovora;
        }

        public override void Izpis()
        {
            Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}\nmasa naloženega tovora: {4}\nmaksimalna masa tovora: {5}", _znamka, _tip, _porabaGorivaNa100km, _velikostRezervarja, masaNaloženegaTovora, maksimalnaMasaTovora);
        }

        public override double zasedenostVozila()
        {
            double procentZasedenosti = maksimalnaMasaTovora / masaNaloženegaTovora * 100;
            return procentZasedenosti;
        }
    }
}
