using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_AdminClient.Controller
{
    public class Bolniska_Controller
    {
        public List<Bolniška> LoadDataGrid(DataGrid datagrid)
        {
            List<Bolniška> tip = RestHelper.GetListOfObjects<Bolniška>(povezave.bolniskeList);
            datagrid.ItemsSource = tip;
            return tip;
        }
    }
}
