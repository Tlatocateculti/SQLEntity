using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLEntity.Model
{
    internal class Zajecia3p : DbContext
    {
        public Zajecia3p(DbContextOptions options) : base(options) {
            this.Database.EnsureCreated();
            //this.Database.
        }

        public DbSet<Osoba> Osoby { get; set; }
    }

   
}
