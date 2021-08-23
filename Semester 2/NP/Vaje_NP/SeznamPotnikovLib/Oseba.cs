using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot_Lib
{
    public class Oseba
    {

        Spol spol;
        public string ime;
        string priimek;
        DateTime datumRojstva;

        public string _ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string _priimek
        {
            get { return priimek; }
            set { priimek = value; }
        }

        public Spol _spol
        {
            get { return spol; }
            set { spol = value; }
        }

        public DateTime _datumRojstva
        {
            get { return datumRojstva; }
            set { datumRojstva = value; }
        }

        public override bool Equals(Object p1)
        {
            Oseba a = p1 as Oseba;
            if ((ime == a.ime) && (priimek == a.priimek)) return true;
            return false;
        }

        public Oseba()
        {

            ime = "Ne";
            priimek = "Ne";
            spol = Spol.N_A;
            datumRojstva = new DateTime(1584, 1, 1);


        }

        public Oseba(string ime, string priimek, Spol spol, DateTime datumRojstva)
            : this(ime, priimek)
        {
            this.spol = spol;
            this.datumRojstva = datumRojstva;

        }

        public Oseba(string ime, string priimek)
        {

            this.ime = ime;
            this.priimek = priimek;
        }

        public virtual void Izpis()
        {
            Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3}", ime, priimek, spol, datumRojstva);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
