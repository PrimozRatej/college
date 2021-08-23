using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dsr_vaja1.Models.Igra;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace dsr_vaja1.DAL
{
    public class IgraContext : DbContext
    {
        public IgraContext() : base("IgraContext")
        {
        }

        public DbSet<Igra> Igre { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}