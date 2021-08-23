using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnikGooG.Ogrodje;

namespace UrnikGooG.Interface
{
    interface IUrnik
    {
        Urnik getUrnik(int id);
        List<Urnik> getUrnike();
        List<Urnik> getUrnike(Zaposleni zaposlen);
        Urnik getUrnik(int mesec, int leto);
        void insertUrnik(Urnik urnik);
        void updateUrnik(int id, Urnik urnik);
    }
}
