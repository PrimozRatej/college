using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace dsr_vaja1.Models.Igra
{
    public class Igra
   {
        public int Id { get; set; }
        [Required(ErrorMessage ="Polje je obvezno!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Dovoljene so le črke!")]
        [StringLength(20, ErrorMessage = "Največ 20 znakov!")]
        public string ime { get; set; }

        [Required(ErrorMessage = "Polje je obvezno!")]
        [StringLength(20, ErrorMessage = "Največ 20 znakov!")]
        public string proizvajalec { get; set; }

        public double cena { get; set; }

        [Required(ErrorMessage = "Polje je obvezno!")]
        public DateTime datum_prihoda { get; set; }

        public int zaloga { get; set; }

        public string Zvrsti { get; set; }
        public IEnumerable<SelectListItem> zvrsti_list
        {
            get
            {
                yield return new SelectListItem { Text = "FPS" };
                yield return new SelectListItem { Text = "MMORPG" };
                yield return new SelectListItem { Text = "Strateška" };
                yield return new SelectListItem { Text = "MOBA" };
                yield return new SelectListItem { Text = "Horror" };
            }
        }
    }
}