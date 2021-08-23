using System.Collections.Generic;
using System.Windows.Controls;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_AdminClient.Controller
{
    public class TipOpravila_Controller
    {
       
        public List<TipOpravila> LoadDataGrid(DataGrid datagrid)
        {
            List<TipOpravila> tip = RestHelper.GetListOfObjects<TipOpravila>(povezave.tipOpravilaList);
            datagrid.ItemsSource = tip;
            return tip;
        }
    }
}