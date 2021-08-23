using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_AdminClient.Controller
{
    public class Izmena_Controller
    {
        public List<Izmena> LoadDataGrid(DataGrid datagrid)
        {
            List<Izmena> tip = RestHelper.GetListOfObjects<Izmena>(povezave.izmenaList);
            datagrid.ItemsSource = tip;
            return tip;
        }
    }
}
