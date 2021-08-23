using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnikGooG.Ogrodje;

namespace UrnikGooG.Interface
{
    interface IOpravilo
    {
        Opravilo getOpravilo(int id);
        List<Opravilo> getOpravila();
        List<Opravilo> getOpravila(Zaposleni zaposlen);
        void insertOpravila(Opravilo opravilo);
        void updateOpravilo(int id, Opravilo opravilo);
    }
}
