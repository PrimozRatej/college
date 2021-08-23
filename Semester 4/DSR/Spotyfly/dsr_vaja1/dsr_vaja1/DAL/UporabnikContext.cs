using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dsr_vaja1.Models.Uporabnik;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace dsr_vaja1.DAL
{
    public class UporabnikContext:DbContext
    {
        public UporabnikContext() : base("UporabnikContext")
        {
        }

        public DbSet<Uporabnik> Uporabniki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}