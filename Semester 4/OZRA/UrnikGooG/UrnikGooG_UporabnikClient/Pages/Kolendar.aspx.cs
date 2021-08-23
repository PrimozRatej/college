using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrnikGooG_UporabnikClient.Models;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_UporabnikClient.Pages
{
    public partial class Kolendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Zaposleni zap = Uporabnik.getzaposleni(User.Identity.Name);
            GridView_urniki.DataSource = Uporabnik.Urniki_zap(zap);
            GridView_urniki.DataBind();
        }
    }
}