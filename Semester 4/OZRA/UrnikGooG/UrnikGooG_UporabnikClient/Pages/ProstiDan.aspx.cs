using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrnikGooG.Ogrodje;
using UrnikGooG_UporabnikClient.Models;

namespace UrnikGooG_UporabnikClient.Pages
{
    public partial class ProstiDan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Zaposleni zap = Uporabnik.getzaposleni(User.Identity.Name);
            GridView_ProstiDan.DataSource = Uporabnik.ProstiDneviZaposlenega(zap);
            GridView_ProstiDan.DataBind();
        }
    }
}