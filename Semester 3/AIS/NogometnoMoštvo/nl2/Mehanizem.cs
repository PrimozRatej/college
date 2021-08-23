using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Services;



namespace nl2
{
    public class Mehanizem
    {
       
        public UporabniskiRacun prijava(string ime, string geslo)
        {
            using (var ctx = new Baza())
            {
                //return ctx.UporabniškiRačuni.SqlQuery("SELECT * FROM UporabniskiRacuns upoRač WHERE upoRač.ime = '"+ime+"' AND upoRač.geslo = '"+geslo+"'").First();
                return ctx.UporabniškiRačuni.FirstOrDefault(t => t.ime == ime && t.geslo == geslo);

            }
        }

        public List<Račun> RačuniKomitenta(string davcna)
        {
            using (var ctx = new Baza())
            {
                return ctx.Računi.Where(t => t.lastnik.DavcnaStevilka == davcna).ToList();

            }
        }

        public List<Transakcija> TransakcijeKomitenta(string davcna)
        {
            using (var ctx = new Baza())
            {
                return ctx.Transakcije.Where(t => t.račun.lastnik.DavcnaStevilka == davcna).ToList();

            }
        }


        public List<Komitent> SeznamKomitentov()
        {
            using (var ctx = new Baza())
            {

                //return ctx.Komitenti.SqlQuery("SELECT * FROM Komitents").ToList();
                return ctx.Komitenti.ToList();

            }
        }

        
        public List<Transakcija> vrniTransakcije()
        {
            using (var ctx = new Baza())
            {
                return ctx.Transakcije.Include(t => t.račun).Include(t => t.račun.lastnik).ToList();

            }

        }
        
        public List<Komitent> vrniKomitenteZTransakcijo()
        {
            using (var ctx = new Baza())
            {
                //return ctx.Komitenti.SqlQuery(Poizvedbe.sqlVsiKomitentiZtransakcijo).ToList();
                List<Komitent> komitenti = new List<Komitent>();
                foreach (var transakcija in ctx.Transakcije.Include(t => t.račun).Include(t => t.račun.lastnik).ToList())
                {
                    komitenti.Add(transakcija.račun.lastnik);
                }
                List<Komitent> vrni = komitenti.Distinct().ToList();
                return vrni;
            }
        }
       
        public List<Transakcija> transakcijeKomitenta(string davcnastevilka)
        {
            using (var ctx = new Baza())
            {
                List<Transakcija> transakcije = new List<Transakcija>();
                foreach (var transakcija in ctx.Transakcije.Include(t => t.račun).Include(t => t.račun.lastnik).ToList())
                {
                    if (transakcija.račun.lastnik.DavcnaStevilka == davcnastevilka)
                        transakcije.Add(transakcija);
                }
                return transakcije;
            }
        }
        
        public Komitent komitent(string davcnastevilka)
        {
            using (var ctx = new Baza())
            {
                foreach (var item in ctx.Komitenti.ToList())
                {
                    if (item.DavcnaStevilka == davcnastevilka)
                        return item;
                }
                return null;
            }
        }
       
        public List<Račun> IzpisBlokiranihRačunov()
        {
            List<Račun> blokirani = new List<Račun>();
            using (var ctx = new Baza())
            {

                foreach (var racun in ctx.Računi.Include(t => t.lastnik).ToList())
                {
                    if (racun.blokiran == true)
                        blokirani.Add(racun);
                }
                blokirani = blokirani.Distinct().ToList();

            }
            return blokirani;
        }
      
        public Transakcija NajvišjaTransakcija()
        {
            Transakcija najvisjaTra = null;
            List<Transakcija> transakcije = null;
            using (var ctx = new Baza())
            {
                transakcije = ctx.Transakcije.Include(t => t.račun).Include(t => t.račun.lastnik).ToList();
            }
            double min = 0;
            foreach (var transakcija in transakcije)
            {
                if (transakcija.znesek > min)
                {
                    najvisjaTra = transakcija;
                    min = transakcija.znesek;
                }

            }
            return najvisjaTra;

        }

        public List<Transakcija> SeznamTransakcij()
        {
            using (var ctx = new Baza())
            {
                return ctx.Transakcije.ToList();
            }
            
        }

        public List<Račun> seznamRačunov()
        {
            using (var ctx = new Baza())
            {
                return ctx.Računi.ToList();
            }

        }

        public double povprecnaStarostKomitentov()
        {
            int skupajLet = 0;
            int stevecKomitentov = 0;
            using (var ctx = new Baza())
            {

                foreach (var komitent in ctx.Komitenti.ToList())
                {
                    int danes = DateTime.Today.Year;
                    int rojstvo = komitent.DatumRojstva.Year;
                    skupajLet = skupajLet + (danes - rojstvo);
                    stevecKomitentov++;
                }

            }
            return skupajLet / stevecKomitentov;
        }
    
        public Račun RačunPridobi(Komitent kom, int idRač)
        {
            using (var ctx = new Baza())
            {
                foreach (var Račun in ctx.Računi.Include(t => t.lastnik).ToList())
                {
                    if (Račun.lastnik.KomitentId == kom.KomitentId && Račun.RačunId == idRač)
                        return Račun;
                }
                return null;
            }
        }


        
        /// <summary>
        /// Tukaj so shranjene vse motode za delo z podatkovno bazo
        /// </summary>

     
        public void KomitentShrani(Komitent kom)
        {
            using (var ctx = new Baza())
            {
                ctx.Komitenti.Add(kom); // Shrani v spomin
                ctx.SaveChanges(); // dokončno shrani v bazo
            }
        }

      
        public void KomitentBriši(Komitent kom)
        {
            using (var ctx = new Baza())
            {

                List<Transakcija> tranKom = ctx.Transakcije.Where(t => t.račun.lastnik.KomitentId == kom.KomitentId).ToList();
                List<Račun> račKom = ctx.Računi.Where(t => t.lastnik.KomitentId == kom.KomitentId).ToList();
                var query = from kom1 in ctx.Komitenti
                            where kom1.KomitentId == kom.KomitentId
                            select kom1;


                foreach (var kom2 in query)
                {
                    ctx.Komitenti.Remove(kom2);
                }
                foreach (var račKomitenta in račKom)
                {
                    ctx.Računi.Remove(račKomitenta);
                }
                foreach (var transakcijaKomitenta in tranKom)
                {
                    ctx.Transakcije.Remove(transakcijaKomitenta);
                }


                ctx.SaveChanges();



            }
        }

      
        public void KomitentAžuriraj(Komitent kom)
        {
            using (var ctx = new Baza())
            {
                ctx.Komitenti.Attach(kom);
                ctx.Entry(kom).State = EntityState.Modified;
                ctx.SaveChanges();

            }
        }


        public Komitent KomitentPridobi(int idKomitenta)
        {
            Komitent PraviKomitent = null;
            using (var ctx = new Baza())
            {
                PraviKomitent = ctx.Komitenti.SqlQuery("SELECT * FROM Komitents WHERE KomitentId = " + idKomitenta).Single();
            }
            return PraviKomitent;

        }


        public void RačunShrani(Račun rač)
        {
            using (var ctx = new Baza())
            {
                rač.lastnik = ctx.Komitenti.Find(rač.lastnik.KomitentId);
                ctx.Računi.Add(rač); // Shrani v spomin
                ctx.SaveChanges(); // dokončno shrani v bazo
            }
        }

    
        public void RačunBriši(Račun rač)
        {
            using (var ctx = new Baza())
            {

                List<Transakcija> tranRac = ctx.Transakcije.Where(t => t.račun.RačunId == rač.RačunId).ToList();
                List<Račun> račKom = ctx.Računi.Where(t => t.RačunId == rač.RačunId).ToList();

                foreach (var transakcijaRacuna in tranRac)
                {
                    ctx.Transakcije.Remove(transakcijaRacuna);
                }
                foreach (var račKomitenta in račKom)
                {
                    ctx.Računi.Remove(račKomitenta);
                }
                ctx.SaveChanges();
            }
        }

        public void RačunAžuriraj(Račun rač)
        {
            using (var ctx = new Baza())
            {
                ctx.Računi.Attach(rač);
                ctx.Entry(rač).State = EntityState.Modified;
                ctx.SaveChanges();

            }
        }

        /*[WebMethod]
        public Račun RačunPridobi(int idRačuna)
        {
            Račun PraviRačun = null;
            using (var ctx = new Baza())
            {
                PraviRačun = ctx.Računi.SqlQuery("SELECT * FROM Račun WHERE RačunId = " + idRačuna).Single();
            }
            return PraviRačun;

        }*/

    
        public void TransakcijaShrani(Transakcija tra)
        {
            using (var ctx = new Baza())
            {
                tra.račun = ctx.Računi.Find(tra.račun.RačunId);
                ctx.Transakcije.Add(tra); // Shrani v spomin
                ctx.SaveChanges(); // dokončno shrani v bazo
            }
        }


        public void TransakcijaBriši(Transakcija tra)
        {
            using (var ctx = new Baza())
            {
                foreach (var tra2 in ctx.Transakcije)
                {
                    if (tra2.TransakcijaId == tra.TransakcijaId)
                        ctx.Transakcije.Remove(tra2);
                }
                ctx.SaveChanges();
            }


        }

        public void TransakcijaAžuriraj(Transakcija tra)
        {
            using (var ctx = new Baza())
            {
                ctx.Transakcije.Attach(tra);
                ctx.Entry(tra).State = EntityState.Modified;
                ctx.SaveChanges();

            }
        }


        public Transakcija TransakcijaPridobi(int idTransakcije)
        {
            Transakcija PraviTransakcija = null;
            using (var ctx = new Baza())
            {
                PraviTransakcija = ctx.Transakcije.Where(t => t.TransakcijaId == idTransakcije).First();
            }
            return PraviTransakcija;

        }

        public void UporabniškiRačunShrani(UporabniskiRacun upoRac)
        {
            using (var ctx = new Baza())
            {
                ctx.UporabniškiRačuni.Add(upoRac); // Shrani v spomin
                ctx.SaveChanges(); // dokončno shrani v bazo
            }
        }


        public void UporabniškiRačunBriši(UporabniskiRacun upoRac)
        {
            using (var ctx = new Baza())
            {
                ctx.UporabniškiRačuni.Remove(upoRac); // Shrani v spomin
                ctx.SaveChanges(); // dokončno shrani v bazo
            }
        }

        public void UporabniškiRačunAžuriraj(UporabniskiRacun upoRac)
        {
            using (var ctx = new Baza())
            {
                ctx.UporabniškiRačuni.Attach(upoRac);
                ctx.Entry(upoRac).State = EntityState.Modified;
                ctx.SaveChanges();

            }
        }


        public UporabniskiRacun UporabniškiRačunPridobi(int idUporabniškiRačun)
        {
            UporabniskiRacun PraviUporabniškiRačun = null;
            using (var ctx = new Baza())
            {
                PraviUporabniškiRačun = ctx.UporabniškiRačuni.SqlQuery("SELECT * FROM UporabniskiRacuns WHERE UporabniskiRacunId = " + idUporabniškiRačun).Single();
            }
            return PraviUporabniškiRačun;

        }




    }
}
