using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using dsr_vaja1.Validacija;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;
namespace dsr_vaja1.Models.Uporabnik
{
    
  
    public class Uporabnik

    {
   
        public int Id { get; set; }
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Dovoljene so le črke!")]
        [StringLength(20, ErrorMessage = "Največ 20 znakov!")]
        [Required(ErrorMessage ="Polje je obvezno!")]
        public string ime { get; set; }

        [StringLength(30, ErrorMessage = "Največ 30 znakov!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Dovoljene so le črke")]
        [Required(ErrorMessage = "Polje je obvezno!")]
        public string priimek { get; set; }

        [Required(ErrorMessage = "Polje je obvezno!")]
        [validacijadatuma]
        public DateTime? rojstni_datum { get; set; }

        [Required(ErrorMessage = "Polje je obvezno!")]
        public string Kraji { get; set; }
        public IEnumerable<SelectListItem> kraji_list
        {
            get
            {
                yield return new SelectListItem { Text = "Maribor" };
                yield return new SelectListItem { Text = "Ljubljana" };
                yield return new SelectListItem { Text = "Koper" };
                yield return new SelectListItem { Text = "Kranj" };
                yield return new SelectListItem { Text = "Murska Sobota" };
            }
        }
        [Required(ErrorMessage = "Polje je obvezno!")]
        [EmsoValidacija]
        public string emso { get; set; }

        [Required(ErrorMessage = "Polje je obvezno!")]
        public int? Starost { get; set; }

        [RegularExpression(@"[a-zA-z].+\s[0-9]+[a-z]?", ErrorMessage = "Dovoljene so črke in številke!")]
        [StringLength(30, ErrorMessage = "Največ 30 znakov!")]
        [Required(ErrorMessage = "Polje je obvezno!")]
        public string naslov { get; set; }

        [StringLength(30, ErrorMessage = "Največ 30 znakov!")]
        [Required(ErrorMessage = "Polje je obvezno!")]
        public string email { get; set; }

        [StringLength(30, ErrorMessage = "Največ 30 znakov!")]
        [Required(ErrorMessage = "Polje je obvezno!")]
        public string posta { get; set; }
        [StringLength(30, ErrorMessage = "Največ 30 znakov!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Vnesete lahko samo črke!")]
        [Required(ErrorMessage = "Polje je obvezno!")]
        public string drzava { get; set; }
        
        [RegularExpression(@"\d{4}", ErrorMessage = "Poštna številka je dolga 4 številke!")]
        [Required(ErrorMessage = "Polje je obvezno!")]
        public string postna_stevilka { get; set; }
        [NotMapped]
        [StringLength(30, ErrorMessage = "Največ 30 znakov!")]
        [Required(ErrorMessage = "Polje je obvezno!")]
        public string geslo { get; set; }
        [NotMapped]
        [StringLength(30, ErrorMessage = "Največ 30 znakov!")]
        [Required(ErrorMessage = "Polje je obvezno!")]
        public string ponovi_geslo { get; set; }

    }
}