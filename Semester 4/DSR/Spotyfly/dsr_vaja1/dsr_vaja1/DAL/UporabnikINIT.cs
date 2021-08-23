using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dsr_vaja1.Models.Uporabnik;
using System.Data.Entity;
namespace dsr_vaja1.DAL
{
    public class UporabnikINIT : System.Data.Entity.DropCreateDatabaseIfModelChanges<UporabnikContext>
    {
        protected override void Seed(UporabnikContext context)
        {
            ;
        }
    }
}