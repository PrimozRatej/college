using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UrnikGooG.Ogrodje;
using UrnikGooG_AdminClient;

namespace UrnikGooG_UporabnikClient.Models
{
    public static class Uporabnik
    {
        public static Zaposleni getzaposleni(string username)
        {
            string[] name_split = username.Split('@');
            Zaposleni zap = RestHelper.GetListOfObjects<Zaposleni>(povezave.zaposleniList).FirstOrDefault(t=>t.Ime == name_split[0]);
            return zap;
            
        }

        internal static object ProstiDneviZaposlenega(Zaposleni zap)
        {
            // Vsi urniki zap.. Urnik ima zap 
            List<Urnik> urniki_zap = RestHelper.GetListOfObjects<Urnik>(povezave.urnikiList).FindAll(t => t.Zaposleni.Id == zap.Id);
            // izmena ima urnik
            List<ProstiDan> ProstiDnevi = RestHelper.GetListOfObjects<ProstiDan>(povezave.prostiDneviList);
            List<ProstiDan> ProstiDnevi_zap = new List<ProstiDan>();
            foreach (var urnik in urniki_zap)
            {
                foreach (var prostiDan in ProstiDnevi)
                {
                    if (prostiDan.Urnik.Id == urnik.Id)
                        ProstiDnevi_zap.Add(prostiDan);
                }
            }
            return ProstiDnevi_zap;
        }

        public static List<Izmena> izmeneZaposlenih(Zaposleni zap)
        {
            // Vsi urniki zap.. Urnik ima zap 
            List<Urnik> urniki_zap = RestHelper.GetListOfObjects<Urnik>(povezave.urnikiList).FindAll(t => t.Zaposleni.Id == zap.Id);
            // izmena ima urnik
            List<Izmena> Izmene = RestHelper.GetListOfObjects<Izmena>(povezave.izmenaList);
            List<Izmena> Izmene_zap = new List<Izmena>();
            foreach (var urnik in urniki_zap)
            {
                foreach (var izmena in Izmene)
                {
                    if (izmena.urnik.Id == urnik.Id)
                        Izmene_zap.Add(izmena);
                }
            }
            return Izmene_zap;
        }

        public static List<Dopust> DopustiZaposlenih(Zaposleni zap)
        {
            // Vsi urniki zap.. Urnik ima zap 
            List<Urnik> urniki_zap = RestHelper.GetListOfObjects<Urnik>(povezave.urnikiList).FindAll(t => t.Zaposleni.Id == zap.Id);
            // izmena ima urnik
            List<Dopust> Dopusti = RestHelper.GetListOfObjects<Dopust>(povezave.DopustList);
            List<Dopust> Dopusti_zap = new List<Dopust>();
            foreach (var urnik in urniki_zap)
            {
                foreach (var dopust in Dopusti)
                {
                    if (dopust.urnik.Id == urnik.Id)
                        Dopusti_zap.Add(dopust);
                }
            }
            return Dopusti_zap;
        }

        public static List<Bolniška> BolniškeZaposlenih(Zaposleni zap)
        {
            // Vsi urniki zap.. Urnik ima zap 
            List<Urnik> urniki_zap = RestHelper.GetListOfObjects<Urnik>(povezave.urnikiList).FindAll(t => t.Zaposleni.Id == zap.Id);
            // izmena ima urnik
            List<Bolniška> Bolniške = RestHelper.GetListOfObjects<Bolniška>(povezave.bolniskeList);
            List<Bolniška> Bolniške_zap = new List<Bolniška>();
            foreach (var urnik in urniki_zap)
            {
                foreach (var bolniska in Bolniške)
                {
                    if (bolniska.Urnik.Id == urnik.Id)
                        Bolniške_zap.Add(bolniska);
                }
            }
            return Bolniške_zap;
        }

        public static List<Urnik> Urniki_zap(Zaposleni zap)
        {
            // Vsi urniki zap.. Urnik ima zap 
            return RestHelper.GetListOfObjects<Urnik>(povezave.urnikiList).FindAll(t => t.Zaposleni.Id == zap.Id);
            
        }
    }
}