using System;

namespace Pot_Lib
{
    public class Voznik : Oseba
    {
        DateTime datumVeljavnostiVozniškegaDovoljenja;

        public DateTime _datumVeljavnostiVozniškegaDovoljenja
        {
            get { return datumVeljavnostiVozniškegaDovoljenja; }
            set { datumVeljavnostiVozniškegaDovoljenja = value; }
        }


        public Voznik()
            : base()
        {
            datumVeljavnostiVozniškegaDovoljenja = new DateTime(1000, 1, 1);
        }

        public Voznik(string ime, string priimek, Spol spol, DateTime datumRojstva, DateTime datumVeljavnostiVozniskegaDovoljenja)
            : base(ime, priimek, spol, datumRojstva)
        {
            this.datumVeljavnostiVozniškegaDovoljenja = datumVeljavnostiVozniskegaDovoljenja;
        }

        public override void Izpis()
        {
            Console.WriteLine("Ime:{0} \nPriimek:{1}\nSpol:{2}\nDatum rojstva: {3}\nDatum veljavnosti vozniskega dovoljenja: {3}", _ime, _priimek, _spol, _datumRojstva, _datumVeljavnostiVozniškegaDovoljenja);
        }
    }
}
