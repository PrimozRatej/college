using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnikGooG.Ogrodje;

namespace UrnikGooG.Interface
{
    interface IDopust
    {
        Dopust getDopust(int id);
        List<Bolniška> getDopuste();
        List<Bolniška> getDopuste(Zaposleni zaposlen);
        void insertDopust(Dopust bolniska);
        void updateDopust(int id, Bolniška bolniška);
    }
}
