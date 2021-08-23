using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnikGooG.Ogrodje;

namespace UrnikGooG.Interface
{
    interface IZaposleni
    {
        //static Zaposleni getZaposlen(int id);
        //List<Zaposleni> getZaposlene();
        void insertZaposlen(Zaposleni zaposlen);
        void updateZaposleni(int id, Zaposleni zaposlen);
    }
}
