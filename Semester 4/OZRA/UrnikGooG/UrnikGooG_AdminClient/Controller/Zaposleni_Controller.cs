using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnikGooG.Ogrodje;
using UrnikGooG_AdminClient;
using System.Windows.Controls;

namespace UrnikGooG_AdminClient.Controller
{
    public class Zaposleni_Controller
    {
        public List<Zaposleni> LoadDataGrid_AllZaposleni(DataGrid datagrid)
        {
            List<Zaposleni> zap = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList);
            datagrid.ItemsSource = zap;
            return zap;
        }

        public List<Zaposleni> LoadDataGrid_ZaposleniPoImenu(DataGrid datagrid, string ime)
        {
            List<Zaposleni> zap = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList);
            zap = zap.FindAll(t => t.Ime == ime);
            datagrid.ItemsSource = zap;
            return zap;
        }

        public List<Zaposleni> LoadDataGrid_ZaposleniPoId(DataGrid datagrid, int Id)
        {
            List<Zaposleni> zap = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList);
            zap = zap.FindAll(t => t.Id == Id);
            datagrid.ItemsSource = zap;
            return zap;
        }

        public List<Zaposleni> LoadDataGrid_ZaposleniPoPriimku(DataGrid datagrid, string Priimek)
        {
            List<Zaposleni> zap = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList);
            zap = zap.FindAll(t => t.Priimek == Priimek);
            datagrid.ItemsSource = zap;
            return zap;
        }

        public List<Zaposleni> LoadDataGrid_ZaposleniPoEmšo(DataGrid datagrid, string Emšo)
        {
            List<Zaposleni> zap = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList);
            zap = zap.FindAll(t => t.Priimek == Emšo);
            datagrid.ItemsSource = zap;
            return zap;
        }

        public List<Zaposleni> LoadDataGrid_ZaposleniPoDavčna(DataGrid datagrid, int DavčnaŠtevilka)
        {
            List<Zaposleni> zap = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList);
            zap = zap.FindAll(t => t.DatvčnaŠtevilka == DavčnaŠtevilka);
            datagrid.ItemsSource = zap;
            return zap;
        }

        public List<Zaposleni> LoadDataGrid_ZaposleniPoPostavka(DataGrid datagrid, double urnaPostavka)
        {
            List<Zaposleni> zap = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList);
            zap = zap.FindAll(t => t.UrnaPostavka == urnaPostavka);
            datagrid.ItemsSource = zap;
            return zap;
        }

        public bool safe(Zaposleni zap)
        {
            try
            {
                RestHelper.PostObject<Zaposleni>(zap, povezave.zaposleniPOST_PUT);
            }
            catch { return false; }
            return true;
        }

        public bool update(Zaposleni zap)
        {
            try
            {
                RestHelper.PutObject<Zaposleni>(zap, povezave.zaposleniPOST_PUT);
            }
            catch { return false; }
            return true;
        }

        public bool delete(Zaposleni zap)
        {
            try
            {
                RestHelper.DeleteObject(povezave.zaposleniDelete(zap));
            }
            catch { return false; }
            return true;
        }
       

        public int DodeliId()
        {
            int max = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList).Max(t => t.Id);
            return ++max;
        }

        public bool PreveriVnos(string ime, string priimek, string emšo, string davčna, string Urnapostavka)
        {
            if (ime.Length > 50) return false;
            if (priimek.Length > 50) return false;
            if (emšo.Length > 50) return false;
            int num;
            if (int.TryParse(emšo, out num) == false) return false;
            if (int.TryParse(davčna, out num) == false) return false;
            double money;
            if (double.TryParse(Urnapostavka,out money) == false) return false;
            return true;
            
        }
    }
}
