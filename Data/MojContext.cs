using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SeminarCore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Data
{
    public class MojContext : IdentityDbContext<ApplicationUser> //appuser dodan kao generic param da bi se Grad mogao dodati u bazu
    {
        public MojContext(DbContextOptions<MojContext> options) : base(options)
        {
        }

        public DbSet<Seminar> Seminari { get; set; }
        public DbSet<Predbiljezba> Predbiljezbe { get; set; }
        public DbSet<Zaposlenik> Zaposlenici { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //fix for error after addmigration
            modelBuilder.Entity<Seminar>().ToTable("Seminar");
            modelBuilder.Entity<Predbiljezba>().ToTable("Predbiljezba");
            modelBuilder.Entity<Zaposlenik>().ToTable("Zaposlenik");
        }

    }
}
