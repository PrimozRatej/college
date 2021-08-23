using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot_Lib
{
    public class Izlet : Iprodajni
    {
        delegate void IzletEventHandler(Potnik potnik);
        event IzletEventHandler EventHandler;
        public string naziv;
        double cenaIzleta;
        string krajOdhoda;
        
        public List<Termin> termini;

        public List<Termin> _termini
        {
            get { return termini; }
            set { termini = value; }
        }

        public Izlet(string naziv, double cenaIzleta, string krajOdhoda/*, List<Termin> termini*/)
        {
            
            this.naziv = naziv;
            this.cenaIzleta = cenaIzleta;
            this.krajOdhoda = krajOdhoda;
            termini = new List<Termin>();
        }

        public void DodajTermin(Termin termin)
        {
            termini.Add(termin);
        }

        public void OdstraniTermin(Termin termin)
        {
            foreach (var x in termini)
            {
                termini.Remove(termin);
            }
        }

        public Termin VrniNajkasnejsiTermin()
        {
            DateTime a = new DateTime(0, 0, 0);
            Termin taTermin = null;
            //Termin Termin = new Termin(a, new DateTime(), new Avtobus());
            foreach (var x in termini)
            {
                if(a<=x.časOdhoda)
                {
                    a = x.časOdhoda;
                    taTermin = x;
                }
            }
            return taTermin;
            
            
        }

        public void ProdajKarto(Termin termin, Potnik potnik)
        {
            foreach (var x in termini)
            {
                
                if (x == termin)
                {   
                    x.seznamPotnikov.Add(potnik._email, potnik);
                    x.Obvestilo += (niz) => Console.WriteLine("Potnik: " + potnik._ime + " " + potnik._priimek + niz +" "+termin.časOdhoda);
                    //x.Obvestilo += this.OnVpis;
                }
            }
        }

               
        public void PrekličiKarto(Termin termin, Potnik potnik)
        {

            foreach (var x in termini)
            {
                if (x == termin)
                    x.seznamPotnikov.Remove(potnik._email);
            }
        }

        public Potnik PoiščiPotnika(string email, Termin termin)
        {
            if (termin.seznamPotnikov.ContainsKey(email))
                return null;
            else return termin.seznamPotnikov[email];
        }

        public bool MestoProsto(Termin termin)
        {
            foreach (var x in termini)
            {
                if (x == null)
                {
                    return true;
                }
            }
            return false;
        }

        public double IzračunajCeno(Potnik potnik)
        {
            if (potnik._status == Status.Študent)
                return cenaIzleta * 0.85;
            if (potnik._status == Status.Upokojenec)
                return cenaIzleta * 0.90;
            return cenaIzleta;
        }

        public void OnVpis(string niz)
        {
            Console.WriteLine(niz);
        }

        
       
    }
}
