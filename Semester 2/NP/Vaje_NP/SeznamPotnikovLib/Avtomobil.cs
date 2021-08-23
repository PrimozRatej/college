using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot_Lib
{
    public class Avtomobil : Vozilo
    {

        int številoSedežev;
        int številoPotnikov;

        public Avtomobil()
        {
            številoSedežev = 0;
            številoPotnikov = 0;
        }

        public Avtomobil(int številoSedežev, int številoPotnikov, Oseba voznik, string znamka, string tip, double porabaGorivaNa100km, double velikostRezervarja)
            : base(voznik, znamka, tip, porabaGorivaNa100km, velikostRezervarja)
        {
            this.številoPotnikov = številoPotnikov;
            this.številoSedežev = številoSedežev;
        }
        public override void Izpis()
        {
            Console.WriteLine("Znamka:{0} \nTip:{1}\nPoraba goriva na 100 km:{2}\nvelikost rezervarja: {3}\nštevilo sedežev: {4}\nštevilo potnikov: {5}", _znamka, _tip, _porabaGorivaNa100km, _velikostRezervarja, številoSedežev, številoPotnikov);
        }

        public override double zasedenostVozila()
        {
            double procentZasedenosti = številoSedežev / številoPotnikov * 100;
            return procentZasedenosti;
        }

    }
}
