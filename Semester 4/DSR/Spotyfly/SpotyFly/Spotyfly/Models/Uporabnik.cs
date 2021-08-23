using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spotyfly.Models
{
    public class Uporabnik
    {
        
        public string ime { get; set; }
        public string priimek { get; set; }
        public DateTime datumRojstva { get; set;}
        public string emšo { get; set; }
        public string starost { get; set; }
        public string naslov { get; set; }
        public string poštnaŠtevilka { get; set; }
        public string pošta { get; set; }
        public string država { get; set; }
        public string eNaslov { get; set; }
        public string geslo { get; set; }


      
        public bool uporabnikPravilen_korak01()
        {
            if (this.ime == "" || this.priimek == "" || this.datumRojstva == null || this.emšo == "" || this.starost == "")
                return false;
            if (this.ime.All(char.IsLetter) == false)
                return false;
            if (this.priimek.All(char.IsLetter) == false)
                return false;
            if (this.datumRojstva < new DateTime(1900, 1, 1) || this.datumRojstva > DateTime.Today)
                return false;
            if (pravilenEmšo(this.emšo)== false)
                return false;
            else return true;
        }

        public bool uporabnikPravilen_korak02()
        {
            if (this.naslov == "" || this.poštnaŠtevilka == "" || this.pošta == "" || this.država == "")
                return false;
            else return true;
        }

        public bool uporabnikPravilen_korak03()
        {
            if (this.geslo == "" || this.eNaslov == "")
                return false;
            else return true;
        }

        public bool pravilenEmšo(string emšo)
        {
            if (this.emšo.All(char.IsNumber) == false)
                return false;
            if (int.Parse(this.emšo.Substring(0, 2)) != this.datumRojstva.Day)
                return false;
            if (int.Parse(this.emšo.Substring(2, 2)) != this.datumRojstva.Month)
                return false;
            if (this.emšo.Substring(4, 3) != this.datumRojstva.Year.ToString().Substring(1,3))
                return false;
            if (this.emšo.Length < 13 || this.emšo.Length > 13)
                return false;
            return true;
        }

        public List<string> Države()
        {
            return new List<string> { "Nemčija", "Slovenija", "Italija", "Španija" };
        }
    }

    
}