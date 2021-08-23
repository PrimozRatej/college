using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot_Lib
{
    public class Potnik : Oseba
    {
        public string email;
        Status status;

        public string _email
        {
            get { return email; }
            set { email = value; }
        }

        public Status _status
        {
            get { return status; }
            set { if (email.Contains("@"))status = value; }
        }

        public Potnik()
            : base()
        {
            email = "something@something.com";
            status = Status.N_A;
        }

        public Potnik(string ime, string priimek, Spol spol, DateTime datumRojstva, string email, Status status)
            : base(ime, priimek, spol, datumRojstva)
        {
            this.email = email;
            this.status = status;
        }

        public override sealed void Izpis()
        {
            Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3}\nEmail: {4} \nStatus: {5}", _ime, _priimek, _spol, _datumRojstva, email, status);
        }
        public void SpremembaStatusa(Status status)
        {
            this.status = status;
        }

    }
}
