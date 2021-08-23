using System.Collections.Generic;
using System.Windows.Controls;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_AdminClient.Controller
{
    public class Opravilo_Controller
    {

        public List<Opravilo> LoadDataGrid(DataGrid datagrid)
        {
            List<Opravilo> tip = RestHelper.GetListOfObjects<Opravilo>(povezave.opraviloList);
            datagrid.ItemsSource = tip;
            return tip;
        }
    }
}