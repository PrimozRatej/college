using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace dsr_vaja1.Validacija
{
    public class validacijadatuma:RangeAttribute
    {
   
            public validacijadatuma()
                : base(typeof(DateTime), DateTime.Parse("01/01/1900").ToShortDateString(), DateTime.Now.AddDays(-1).ToShortDateString()) { ErrorMessage = "Datum rojstva mora biti večji od 1.1.1900 ter manjši od današnjega dne!"; }
    }
    
}