using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BAZA
    {
        public static List<Opravilo> seznamOpravil = new List<Opravilo>();
        public static List<Vozilo> seznamVozil = new List<Vozilo>();
        public static List<TehnicniPregledi> seznamtehničnihPregledov = new List<TehnicniPregledi>();
        static Vozilo voz1;
        static Vozilo voz2;
        static Vozilo voz3;
        public static void NaložiOpravila()
        {
            seznamOpravil.Add(new Opravilo("Menjava olja", new DateTime(2017, 1, 20), new DateTime(2017, 1, 1)));
            seznamOpravil.Add(new Opravilo("Menjava gum", new DateTime(2017, 1, 20), new DateTime(2017, 1, 12)));
            seznamOpravil.Add(new Opravilo("Pregled zavor", new DateTime(2017, 1, 20), new DateTime(2017, 1, 12)));
            seznamOpravil.Add(new Opravilo("Menjava jermena", new DateTime(2017, 1, 20), new DateTime(2017, 1, 12)));
        }

        public static void NaložiVozila()
        {
            voz1 = new Vozilo(1, "Ford", "Mustang", 1970, 12.4, 1234532123, new DateTime(1972, 2, 12), 2500, "Limuzin", seznamOpravil.ToArray());
            voz2 = new Vozilo(2, "Chevrole", "Camaro SS", 1969, 12.4, 1235552123, new DateTime(1970, 2, 12), 2300, "Limuzin", seznamOpravil.ToArray());
            voz3 = new Vozilo(3, "Porche", "Cayane", 1980, 12.4, 1236666123, new DateTime(1982, 2, 12), 2500, "Limuzin", seznamOpravil.ToArray());
            seznamVozil.Add(voz1);
            seznamVozil.Add(voz2);
            seznamVozil.Add(voz3);

        }

        public static void NaložiTehničnePreglede()
        {
            seznamtehničnihPregledov.Add(new TehnicniPregledi(1, voz1, "Osnovni tehnični pregled", new DateTime(2016, 10, 3), "Avto kuk", 60));
            seznamtehničnihPregledov.Add(new TehnicniPregledi(1, voz1, "Osnovni tehnični pregled", new DateTime(2017, 10, 3), "Avto kuk", 60));
            seznamtehničnihPregledov.Add(new TehnicniPregledi(1, voz1, "Osnovni tehnični pregled", new DateTime(2018, 10, 3), "Avto kuk", 60));

            seznamtehničnihPregledov.Add(new TehnicniPregledi(1, voz2, "Osnovni tehnični pregled", new DateTime(2016, 10, 3), "Avto kuk", 60));
            seznamtehničnihPregledov.Add(new TehnicniPregledi(1, voz3, "Osnovni tehnični pregled", new DateTime(2017, 10, 3), "Avto kuk", 60));
            

        }
    }
}
