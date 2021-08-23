using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace dsr_vaja1.Validacija
{
    public class EmsoValidacija:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int mnozitelj = 7;
            int sestevek = 0;
            int kontrolnaSt = 0;

            int tempSt;
            string emso;

            if (value == null)
                return false;
            else
                emso = value.ToString();

            if (emso.Length > 13 || emso.Length < 13)
                return false;

            for (int i = 0; i < 12; i++)
            {
                if (mnozitelj == 1)
                    mnozitelj = 7;

                tempSt = int.Parse(emso[i].ToString());
                sestevek = sestevek + tempSt * mnozitelj;
                mnozitelj--;
            }

            kontrolnaSt = int.Parse(emso[emso.Length - 1].ToString());

            if (11 - (sestevek % 11) < 10 &&
                11 - (sestevek % 11) == kontrolnaSt)
                return true;
            return false;
        }
    }
}