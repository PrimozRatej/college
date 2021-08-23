using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomilostitveniPostopek
{
    static class Context
    {
        public static List<Prošnja> prošnje = new List<Prošnja>();

       

        public static List<Prošnja>Prošnje(AllnOne.Ustanova ustanova)
        {
            if(ustanova == AllnOne.Ustanova.Sodišče)
            {
                return prošnje.FindAll(t => t.krajObdelave == AllnOne.Ustanova.Sodišče);
                
            }
            if (ustanova == AllnOne.Ustanova.Ministerstvo)
            {
                return prošnje.FindAll(t => t.krajObdelave == AllnOne.Ustanova.Ministerstvo);
            }
            if (ustanova == AllnOne.Ustanova.Tožilec)
            {
                return prošnje.FindAll(t => t.krajObdelave == AllnOne.Ustanova.Tožilec);
            }
            if (ustanova == AllnOne.Ustanova.Zaključena)
            {
                return prošnje.FindAll(t => t.krajObdelave == AllnOne.Ustanova.Zaključena);
            }
            return null;
        }



    }
}
