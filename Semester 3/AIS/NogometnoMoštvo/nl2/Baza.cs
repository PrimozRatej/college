using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace nl2
{
    public class Baza: DbContext
    {
        public DbSet<Transakcija> Transakcije { get; set; }
        public DbSet<Komitent> Komitenti { get; set; }
        public DbSet<Račun> Računi { get; set; }
        public DbSet<UporabniskiRacun> UporabniškiRačuni { get; set; }

    }
}