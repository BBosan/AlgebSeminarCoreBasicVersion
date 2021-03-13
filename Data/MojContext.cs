using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SeminarCore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeminarCore2.Data;

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
            base.OnModelCreating(modelBuilder); //fix for error after addmigration //The entity type 'IdentityUserLogin<string>' requires a primary key to be defined

            modelBuilder.Seed(); //ModelBuilderForMockDataExtensions.cs

            #region ON DELETE TO NO ACTION - Default Je Cascade
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                    .SelectMany(x => x.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
            #endregion

        }


    }
}
