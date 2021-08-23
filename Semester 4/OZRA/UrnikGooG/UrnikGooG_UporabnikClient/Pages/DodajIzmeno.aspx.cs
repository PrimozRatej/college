using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrnikGooG.Ogrodje;
using UrnikGooG_UporabnikClient.Models;
using UrnikGooG_AdminClient;
using UrnikGooG_AdminClient.AllInOne;

namespace UrnikGooG_UporabnikClient.Pages
{
    public partial class DodajIzmeno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack ==false)
            {
                ComboBox_določiUre();
                combobox_določiUrnik();
            }
        }

        public void ComboBox_določiUre()
        {
            for (int i = 1; i < 25; i++)
            {
                DropDownList_ZačetekUre.Items.Add(i.ToString());
                DropDownList_KonecUre.Items.Add(i.ToString());
            }

            for (int i = 1; i < 61; i++)
            {
                DropDownList_ZačetekMinute.Items.Add(i.ToString());
                DropDownList_KonecMinute.Items.Add(i.ToString());
            }

        }

        public void combobox_določiUrnik()
        {
            Zaposleni zap = Uporabnik.getzaposleni(User.Identity.Name);
            List<Urnik> urniki = Uporabnik.Urniki_zap(zap);
            foreach (var urnik in urniki)
            {
                string text = "ID: " + urnik.Id + ", za mesec " + urnik.Mesec;
                DropDownList_Urnik.Items.Add(new ListItem(text, urnik.Id.ToString()));
            }
        }

        protected void Button_DodajIzmeno_Click(object sender, EventArgs e)
        {
            int Leto = Calendar1.SelectedDate.Year;
            int Mesec = Calendar1.SelectedDate.Month;
            int Dan = Calendar1.SelectedDate.Day;
            int ZUra = int.Parse(DropDownList_ZačetekUre.SelectedValue);
            int ZMin = int.Parse(DropDownList_ZačetekMinute.SelectedValue);
            int KUra = int.Parse(DropDownList_KonecUre.SelectedValue);
            int KMin = int.Parse(DropDownList_KonecMinute.SelectedValue);
            DateTime začetek = new DateTime(Leto, Mesec, Dan, ZUra, ZMin,0);
            DateTime konec = new DateTime(Leto, Mesec, Dan, KUra, KMin, 0);
            int idUrnik = int.Parse(DropDownList_Urnik.SelectedValue);
            Urnik urnik = RestHelper.GetListOfObjects<Urnik>(povezave.urnikiList).FirstOrDefault(t => t.Id == idUrnik);

            Izmena izm = new Izmena();
            izm.Id = DoločiId_Izmene();
            izm.DatumZačetka = začetek;
            izm.DatumKonca = konec;
            izm.urnik = urnik;

            RestHelper.PostObject(izm, povezave.izmenaList);

            Server.Transfer("~/Pages/Izmene.aspx", true);

        }

        public int DoločiId_Izmene()
        {
            List<Izmena> izm = RestHelper.GetListOfObjects<Izmena>(povezave.izmenaList);
            int MAX_id = izm.Max(t => t.Id);
            return ++MAX_id;
            
        }
    }
}