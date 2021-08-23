using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spotyfly.Models;
using System.Diagnostics;

namespace Spotyfly.Controllers
{
    public class RegistracijaController : Controller
    {
        public ActionResult Index()
        {
            if(TempData["opozorilo"] != null)
               ViewBag.opozorilo = TempData["opozorilo"];
            
            return View("vpisOsnovnihPodatkov");
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(Uporabnik upo)
        {
            
            Uporabnik uporabnik = new Uporabnik();
            uporabnik.ime = upo.ime;
            uporabnik.priimek = upo.priimek;
            uporabnik.datumRojstva = upo.datumRojstva;
            uporabnik.emšo = upo.emšo;
            uporabnik.starost = upo.starost;

            if (uporabnik.uporabnikPravilen_korak01() == false)
            {
                TempData["opozorilo"] = "Podatki niso bili vnešeni pravilno";
                return RedirectToAction("Index");
            }
            TempData["uporabnik"] = uporabnik;
            return RedirectToAction("vpisNaslovaPoste");
        }


        public ActionResult vpisNaslovaPoste()
        {
            if (TempData["opozorilo"] != null)
                ViewBag.opozorilo = TempData["opozorilo"];
            return View("vpisNaslovaPoste");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult vpisNaslovaPoste(Uporabnik upo)
        {
            Uporabnik uporabnik = (Uporabnik)TempData["uporabnik"];
            uporabnik.naslov = upo.naslov;
            uporabnik.poštnaŠtevilka = upo.poštnaŠtevilka;
            uporabnik.država = upo.država;
            uporabnik.pošta = upo.pošta;
            if (uporabnik.uporabnikPravilen_korak02() == false)
            {
                TempData["opozorilo"] = "Podatki niso bili vnešeni pravilno";
                return RedirectToAction("vpisNaslovaPoste");
            }
            TempData["uporabnik"] = uporabnik;
            return RedirectToAction("vpisGesla");
        }

        public ActionResult vpisGesla()
        {
            if (TempData["opozorilo"] != null)
                ViewBag.opozorilo = TempData["opozorilo"];
            return View("vpisGesla");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult vpisGesla(string eNaslov, string gesloPrvic, string gesloDrugic)
        {
            Uporabnik uporabnik = (Uporabnik)TempData["uporabnik"];
            if (!gesloPravilno(gesloPrvic, gesloDrugic))
            {
                TempData["opozorilo"] = "Gesla se ne ujemata.";
                return RedirectToAction("vpisGesla");
            }
            if(eNaslov == "")
            {
                TempData["opozorilo"] = "Napačen vnos";
                return RedirectToAction("vpisGesla");
            }

            uporabnik.eNaslov = eNaslov;
            uporabnik.geslo = gesloPrvic;
            TempData["uporabnik"] = uporabnik;
            return RedirectToAction("izpisPodatkov");
        }

        public ActionResult izpisPodatkov()
        {
            Uporabnik uporabnik = (Uporabnik)TempData["uporabnik"];
            ViewBag.uporabnik = uporabnik;
            return View("izpisPodatkov");
        }

        private bool gesloPravilno(string gesloPrvic, string gesloDrugic)
        {
            if (gesloPrvic != gesloDrugic || gesloPrvic == "" || gesloDrugic == "")
                return false;
            else return true;
        }

        private DateTime toDate(string yymmddFormat)
        {

            DateTime datum = DateTime.ParseExact(yymmddFormat, "yyyy/mm/dd", null);//sparsalo ni vredi iz string v dateformat!!!
            return datum;
            

        }



    }
}