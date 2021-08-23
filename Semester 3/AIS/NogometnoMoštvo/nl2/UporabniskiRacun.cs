using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nl2
{
    public class UporabniskiRacun
    {   
        [Key]
        public int UporabniskiRacunId { get; set; }
        public string ime { get; set; }
        public string geslo { get; set; }
        public bool aliJeAdmin { get; set; }
        

        public UporabniskiRacun()
        {

        }
        public UporabniskiRacun(string ime, string geslo, bool aliJeAdmin)
        {
            this.ime = ime;
            this.geslo = geslo;
            this.aliJeAdmin = aliJeAdmin;
        }

        public bool avtentifikacija()
        {
            if (this.aliJeAdmin == true) return true;
            else return false;

        }
    }
}