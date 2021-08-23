using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using dsr_vaja1.Models.Uporabnik;
namespace dsr_vaja1.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
           
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("UporabnikContext", "Uporabnik", "Id", "ime", autoCreateTables: true);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection Form)
        {
            bool Authenticated = WebSecurity.Login(Form["UserName"], Form["Password"], false);

            if (Authenticated)
            {
                string Return_Url = Request.QueryString["ReturnUrl"];
                if (Return_Url == null)
                {
                    return Redirect("~/Igras/Index");
                }
                else
                {
                    Response.Redirect(Return_Url);
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("UporabnikContext", "Uporabnik", "Id", "ime", autoCreateTables: true);
            }

            return View(new Uporabnik());
        }

        [HttpPost]
        public ActionResult Register(FormCollection Form, Uporabnik uporabnik)
        {
            if(ModelState.IsValid)
            {
                WebSecurity.CreateUserAndAccount(Form["ime"], Form["geslo"], new
                {
                    ime = Form["ime"],
                    priimek = Form["priimek"],
                    rojstni_datum = Form["rojstni_datum"],
                    Kraji = Form["kraji"],
                    emso = Form["emso"],
                    Starost = Form["Starost"],
                    naslov = Form["naslov"],
                    email = Form["email"],
                    posta = Form["posta"],
                    drzava = Form["drzava"],
                    postna_stevilka = Form["postna_stevilka"]
                });
                return Redirect("~/Igras/Index");
            }
        
            return View(uporabnik);
        }

        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return Redirect("~/Igras/Index");
        }
    }
}