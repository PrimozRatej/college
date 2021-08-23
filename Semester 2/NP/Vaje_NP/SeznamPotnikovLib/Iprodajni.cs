using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot_Lib
{
    interface Iprodajni
    {
        void ProdajKarto(Termin termin, Potnik potnik);//Doda potnika na seznam prijavljenih potnikov
        void PrekličiKarto(Termin termin, Potnik potnik);//ki odstrani potnika iz seznama prijavljenih izletnikov.
        bool MestoProsto(Termin termin); //preveri, če je na avtobusu še kakšno prosto mesto.
        double IzračunajCeno(Potnik potnik);// izračuna ceno izleta za posameznega potnika. Upoštevajte, da imajo pri nakupu karte upokojenci 10% popust, študenti pa 15% popust.
    }
}
