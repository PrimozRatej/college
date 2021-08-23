using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnikGooG.Ogrodje;

namespace UrnikGooG_AdminClient
{
    public static class povezave
    {
        // Get all
        static public string zaposleniList = "http://localhost:57982/Storitev/Service1.svc/Zaposleni";
        static public string urnikiList = "http://localhost:57982/Storitev/Service1.svc/urnik";

        static public string tipOpravilaList = "http://localhost:57982/Storitev/Service1.svc/tipOpravila";
        static public string opraviloList = "http://localhost:57982/Storitev/Service1.svc/opravilo";
        static public string izmenaList = "http://localhost:57982/Storitev/Service1.svc/izmena";
        static public string DopustList = "http://localhost:57982/Storitev/Service1.svc/dopust";
        static public string prostiDneviList = "http://localhost:57982/Storitev/Service1.svc/prostiDnevi";
        static public string bolniskeList = "http://localhost:57982/Storitev/Service1.svc/bolniske";

        //POST_PUT
        static public string zaposleniPOST_PUT = "http://localhost:57982/Storitev/Service1.svc/zaposleni";
        static public string urnik_POST_PUT = "http://localhost:57982/Storitev/Service1.svc/urnik";

        static public string zaposleniDelete(Zaposleni zap)
        {
            return "http://localhost:57982/Storitev/Service1.svc/zaposleni/"+zap.Id;
        }

        static public string izmeneZaposlenih(Zaposleni zap)
        {
            return izmenaList;
        }



    }
}
