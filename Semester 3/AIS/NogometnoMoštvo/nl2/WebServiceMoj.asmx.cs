using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services;





namespace nl2
{
    /// <summary>
    /// Summary description for WebServiceMoj
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMoj : System.Web.Services.WebService 
    {
        Mehanizem meh;
        
        public WebServiceMoj()
        {
            this.meh = new Mehanizem();
        }

        [WebMethod]
        public UporabniskiRacun prijava(string ime, string geslo)
        {
            return meh.prijava(ime,geslo);
        }
        [WebMethod]
        public List<Račun> RačuniKomitenta(string davcna)
        {
            return meh.RačuniKomitenta(davcna);
        }
        [WebMethod]
        public List<Transakcija> TransakcijeKomitenta(string davcna)
        {
            return meh.transakcijeKomitenta(davcna);
        }
        [WebMethod]
        public List<Transakcija> SeznamTransakcij()
        {
            return meh.SeznamTransakcij();

        }
        [WebMethod]
        public List<Račun> seznamRačunov()
        {
            return meh.seznamRačunov();
        }

        [WebMethod]
        public List<Komitent> SeznamKomitentov()
        {
            return meh.SeznamKomitentov();
        }

        [WebMethod]
        public List<Transakcija> vrniTransakcije()
        {
            return meh.vrniTransakcije();
        }

        [WebMethod]
        public List<Komitent> vrniKomitenteZTransakcijo()
        {
            return meh.vrniKomitenteZTransakcijo();
        }

        [WebMethod]
        public List<Transakcija> transakcijeKomitenta(string davcna)
        {
            return meh.transakcijeKomitenta(davcna);
        }

        [WebMethod]
        public Komitent komitent(string davcna)
        {
            return meh.komitent(davcna);
        }

        [WebMethod]
        public List<Račun> IzpisBlokiranihRačunov()
        {
            return meh.IzpisBlokiranihRačunov();
        }

        [WebMethod]
        public Transakcija NajvišjaTransakcija()
        {
            return meh.NajvišjaTransakcija();
        }

        [WebMethod]
        public double povprecnaStarostKomitentov()
        {
            return meh.povprecnaStarostKomitentov();
        }

        [WebMethod]
        public Račun RačunPridobi(Komitent kom, int idRač)
        {
            return meh.RačunPridobi(kom,idRač);
        }

        [WebMethod]
        public void KomitentShrani(Komitent kom)
        {
            meh.KomitentShrani(kom);
        }

        [WebMethod]
        public void KomitentBriši(Komitent kom)
        {
            meh.KomitentBriši(kom);
        }

        [WebMethod]
        public void KomitentAžuriraj(Komitent kom)
        {
            meh.KomitentAžuriraj(kom);
        }

        [WebMethod]
        public Komitent KomitentPridobi(int idKomitenta)
        {
            return meh.KomitentPridobi(idKomitenta);
        }

        [WebMethod]
        public void RačunShrani(Račun rač)
        {
            meh.RačunShrani(rač);
        }

        [WebMethod]
        public void RačunBriši(Račun rač)
        {
            meh.RačunBriši(rač);
        }

        [WebMethod]
        public void RačunAžuriraj(Račun rač)
        {
            meh.RačunAžuriraj(rač);
        }

        [WebMethod]
        public void TransakcijaShrani(Transakcija tra)
        {
            meh.TransakcijaShrani(tra);
        }

        [WebMethod]
        public void TransakcijaBriši(Transakcija tra)
        {
            meh.TransakcijaBriši(tra);
        }

        [WebMethod]
        public void TransakcijaAžuriraj(Transakcija tra)
        {
            meh.TransakcijaAžuriraj(tra);
        }

        [WebMethod]
        public Transakcija TransakcijaPridobi(int transakcijaId )
        {
           return meh.TransakcijaPridobi(transakcijaId);
        }

        [WebMethod]
        public void UporabniškiRačunShrani(UporabniskiRacun upoRac)
        {
            meh.UporabniškiRačunShrani(upoRac);
        }

        [WebMethod]
        public void UporabniškiRačunBriši(UporabniskiRacun upoRac)
        {
            meh.UporabniškiRačunBriši(upoRac);
        }

        [WebMethod]
        public void UporabniškiRačunAžuriraj(UporabniskiRacun upoRac)
        {
            meh.UporabniškiRačunAžuriraj(upoRac);
        }

        [WebMethod]
        public UporabniskiRacun UporabniškiRačunPridobi(int uporacID)
        {
            return meh.UporabniškiRačunPridobi(uporacID);
        }

    }
}
