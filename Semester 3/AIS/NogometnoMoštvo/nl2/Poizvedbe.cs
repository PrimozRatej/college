using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nl2
{
    public static class Poizvedbe
    {
        public static string sqlVsiKomitentiZtransakcijo = "SELECT DISTINCT kom.KomitentId,kom.Ime,kom.Priimek,kom.DavcnaStevilka,kom.DatumRojstva FROM Komitents kom RIGHT JOIN Račun rač ON kom.KomitentId = rač.lastnik_KomitentId RIGHT JOIN Transakcijas tra ON rač.RačunId = tra.račun_RačunId ";
        public static string sqlVseTransakcijeDoločenegaKomitenta(string davcna)
        {
            return "SELECT tra.TransakcijaId,tra.datumTransakcije,tra.znesek,tra.račun_RačunId FROM Komitents kom RIGHT JOIN Račun rač ON kom.KomitentId = rač.lastnik_KomitentId RIGHT JOIN Transakcijas tra ON rač.RačunId = tra.račun_RačunId where kom.DavcnaStevilka = " + davcna;
        }

        public static string sqlKomitentZdavčno(string davčna)
        {
            return "SELECT * FROM Komitents kom WHERE kom.DavcnaStevilka = " + davčna;
        }
        public static string sqlVsiBlokiraniRačuni = "SELECT * FROM Račun rač WHERE rač.blokiran = 'TRUE'";
        public static string sqlVseTransakcije = "SELECT * FROM Transakcijas";

        public static string sqlPovprečnaStarost = "Select AVG(Datediff("+"yyyy"+",kom.DatumRojstva,getdate())) as AVGage from Komitents kom";
    }
}