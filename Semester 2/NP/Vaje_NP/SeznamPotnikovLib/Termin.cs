using System;
using System.Collections.Generic;

namespace Pot_Lib
{
    public class Termin
    {
        
        
        public DateTime časOdhoda;
        DateTime časPrihoda;
        Avtobus dodeljenAvtobus;
        static int maxŠtPotnikov;
        static int številoPotnikov;
        public Dictionary<string, Potnik> seznamPotnikov;

        // event v terminih
        public event obvestilo Obvestilo;
        
        public Termin(DateTime časOdhoda, DateTime časPrihoda, Avtobus dodeljenAvtobus)
        {
            this.časOdhoda = časOdhoda;
            this.časPrihoda = časPrihoda;
            this.dodeljenAvtobus = dodeljenAvtobus;
            this.seznamPotnikov = new Dictionary<string, Potnik>();
        }

        
        public int _maxŠteviloPotnikov
        {
            get { return maxŠtPotnikov; }
            set { maxŠtPotnikov = dodeljenAvtobus._skupnoŠteviloSedežev + dodeljenAvtobus._skupnoŠteviloStojišč; }

        }

        public int _stPotnikov
        {
            get { return številoPotnikov; }
            set { številoPotnikov = value; }

        }
        public void urediSeznam()
        {
            Potnik[] poljeValue = new Potnik[seznamPotnikov.Count];
            int stevec = 0;
            foreach (var x in seznamPotnikov)
            {
                poljeValue[stevec] = x.Value;
                
                stevec++;
            }
             
           
            for (int i = 0; i < poljeValue.Length; i++)
            {
                for (int j = i+1; j < poljeValue.Length; j++)
                {
                    
                    if(poljeValue[i]._priimek.CompareTo(poljeValue[j]._priimek)>0)
                    {
                        var temp = poljeValue[i];
                        poljeValue[i] = poljeValue[j];
                        poljeValue[j] = temp;
                        
                    }
                }
            }

            seznamPotnikov.Clear();
            foreach (var x in poljeValue)
            {
                seznamPotnikov.Add(x.email, x);
            }
        }

        public void IzpisiSeznamPotnikov()
        {
            foreach (var a in seznamPotnikov)
            {
                a.Value.Izpis();
            }
        }

        public void ObvestiPotnike()
        {
            if (Obvestilo != null)
                Obvestilo(", uspešno ste prijavljeni na termin!");
        }

        

        

    }
}
