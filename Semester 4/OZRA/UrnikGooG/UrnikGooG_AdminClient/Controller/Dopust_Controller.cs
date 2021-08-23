using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_AdminClient.Controller
{
    public class Dopust_Controller
    {
        DataGrid datagrid;
        public Dopust_Controller(DataGrid datagrid)
        {
            this.datagrid = datagrid;
        }
        public List<Dopust> LoadDataGrid()
        {
            List<Dopust> dop = RestHelper.GetListOfObjects<Dopust>(povezave.DopustList);
            datagrid.ItemsSource = dop;
            return dop;
        }

        public List<Dopust> LoadDataGrid_DopustiZaposlenega(Zaposleni zap)
        {
            List<Urnik> urniki = RestHelper.GetListOfObjects<Urnik>(povezave.urnikiList);//Vsi urniki zaposlenega
            urniki = urniki.FindAll(t => t.Zaposleni.Id == zap.Id);
            List<Dopust> dopus = RestHelper.GetListOfObjects<Dopust>(povezave.DopustList);
            List<Dopust> doppList = new List<Dopust>();
            foreach (var dop in dopus)
            {
                if (urniki.Exists(t => t.Id == dop.Id))
                    doppList.Add(dop);
            }
            datagrid.ItemsSource = doppList;
            return doppList;

            
        }
    }
}
