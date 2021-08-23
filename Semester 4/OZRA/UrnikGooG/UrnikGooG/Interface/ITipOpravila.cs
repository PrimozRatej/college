using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnikGooG.Ogrodje;

namespace UrnikGooG.Interface
{
    interface ITipOpravila
    {
        TipOpravila getTipOpravila(int id);
        List<TipOpravila> getTipeOpravil();
        void insertTipOpravila(TipOpravila tipOpravila);
        void updateTipOpravila(int id, TipOpravila tipOpravila);
    }
}
