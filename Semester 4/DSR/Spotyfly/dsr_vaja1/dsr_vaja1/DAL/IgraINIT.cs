using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dsr_vaja1.Models.Igra;
using System.Data.Entity;
namespace dsr_vaja1.DAL
{
    public class IgraINIT : System.Data.Entity.DropCreateDatabaseIfModelChanges<IgraContext>
    {
        protected override void Seed(IgraContext context)
        {
            var students = new List<Igra>
            {
                new Igra {ime="test", cena=55, datum_prihoda=new DateTime(1996,1,1), Id=1, proizvajalec="test", zaloga=2, Zvrsti="FPS" }
            };
            students.ForEach(s => context.Igre.Add(s));
            context.SaveChanges();
        }
    }
}