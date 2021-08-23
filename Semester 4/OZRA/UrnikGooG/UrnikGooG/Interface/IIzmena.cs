using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnikGooG.Ogrodje;

namespace UrnikGooG.Interface
{
    interface IIzmena
    {
        Izmena getIzmena(int id);
        List<Izmena> getIzmene();
        List<Izmena> getIzmene(Zaposleni zaposlen);
        void insertIzmena(Izmena izmena);
        void updateIzmena(int id, Izmena izmena);
    }
}
