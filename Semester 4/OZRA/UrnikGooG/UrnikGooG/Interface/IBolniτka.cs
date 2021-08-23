using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace UrnikGooG.Ogrodje
{
    public interface IBolniška
    {
        Bolniška getBolniška(int id);
        List<Bolniška> getBolniške();
        void insertBolniška(Bolniška bolniska);
        void updateBolniška(int id, Bolniška bolniška);
    }
}
