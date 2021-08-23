using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FerkvencnaAnaliza
{
    public class Datoteka
    {
        string filePath;
        public string text;
        public Dictionary<int, int> ferkvencnaAnaliza;

        public Datoteka(string filePath)
        {
            this.filePath = filePath;
            using (StreamReader str = new StreamReader(filePath))
            {
                this.text = str.ReadToEnd();
            }
            this.ferkvencnaAnaliza = sortiraj(FerkvencnaAnaliza());
        }

        public Dictionary<int, int> FerkvencnaAnaliza()
        {
            Dictionary<int, int> seznam = new Dictionary<int, int>();
            using (StreamReader reader = new StreamReader(this.filePath))
            {
                while(!reader.EndOfStream)
                {
                    int znak = reader.Read();// znak ki se obravnava v tej sekvenci
                    if (znakPravilen((char)znak))
                    {
                        if (seznam.Keys.Contains(znak))
                            ++seznam[znak];
                        else
                            seznam.Add(znak, 1);
                    }
                }
            }
            return seznam;
        }

        public static bool znakPravilen(char znak)
        {
            if ((znak >= 65 && znak <= 90) || (znak >= 97 && znak <= 122) || znak == 'č' || znak == 'Č' || znak == 'š' || znak == 'Š' || znak == 'ž' || znak == 'Ž')
                return true;
            return false;
        }

        public Dictionary<int,int> sortiraj(Dictionary<int,int> seznam)
        {
            Dictionary<int, int> sortiranSeznam = new Dictionary<int, int>();
            var vmes1 = from pair in seznam
                        orderby pair.Value descending
                        select pair;
            foreach (var par in vmes1)
            {
                sortiranSeznam.Add(par.Key,par.Value);
            }
            return sortiranSeznam;
        }

        

        
    }
}
