using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FerkvencnaAnaliza
{
    class Dešifrirnik
    {
        public string dešifrirajDelno(Datoteka referenčnaDatoteka, Datoteka šifriranaDatoteka)
        {
            string dešifriranNiz = "";
            int znakZaZamenjavo = 0;
            foreach (var znak in šifriranaDatoteka.text)
            {
                if (!Datoteka.znakPravilen(znak))
                {
                    dešifriranNiz += znak;
                    continue;
                }
                else
                {
                    znakZaZamenjavo = referenčnaDatoteka.ferkvencnaAnaliza.Keys.ElementAt(šifriranaDatoteka.ferkvencnaAnaliza.Keys.ToList().IndexOf(znak));
                }

                dešifriranNiz += (char)znakZaZamenjavo; 
            }
            return dešifriranNiz;
        }

        public string zamenjaj(string crkakiBoZamenjana, string crkasKateroZamenjamo, string inkriptiranoSporočilo)
        {
            string niz = inkriptiranoSporočilo;
            string vrnjen = "";
            string znakKigaBomoNadomestili = crkakiBoZamenjana;
            string znakZaZamenjavo = crkasKateroZamenjamo;
            foreach (var znak in niz)
            {
                if (znak == znakKigaBomoNadomestili[0])
                {
                    vrnjen += znakZaZamenjavo;
                    continue;
                }
                if (znak == znakZaZamenjavo[0])
                {
                    vrnjen += znakKigaBomoNadomestili;
                    continue;
                }
                vrnjen += znak;
            }

            return vrnjen;
        }
    }
}
