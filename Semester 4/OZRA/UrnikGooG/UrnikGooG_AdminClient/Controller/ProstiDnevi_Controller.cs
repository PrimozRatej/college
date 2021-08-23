using System.Collections.Generic;
using System.Windows.Controls;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_AdminClient.Controller
{
    public class ProstiDnevi_Controller
    {
        public List<ProstiDan> LoadDataGrid(DataGrid datagrid)
        {
            List<ProstiDan> tip = RestHelper.GetListOfObjects<ProstiDan>(povezave.prostiDneviList);
            datagrid.ItemsSource = tip;
            return tip;
        }
    }
}
