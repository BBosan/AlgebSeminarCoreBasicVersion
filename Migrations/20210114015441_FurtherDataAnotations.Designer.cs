﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeminarCore2.Data;

namespace SeminarCore2.Migrations
{
    [DbContext(typeof(MojContext))]
    [Migration("20210114015441_FurtherDataAnotations")]
    partial class FurtherDataAnotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeminarCore2.Models.Predbiljezba", b =>
                {
                    b.Property<int>("PredbiljezbaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired();

                    b.Property<string>("BrojTelefona")
                        .IsRequired();

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("SeminarID");

                    b.Property<bool?>("StatusDaNe");

                    b.HasKey("PredbiljezbaID");

                    b.HasIndex("SeminarID");

                    b.ToTable("Predbiljezba");
                });

            modelBuilder.Entity("SeminarCore2.Models.Seminar", b =>
                {
                    b.Property<int>("SeminarID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("PopunjenDaNe");

                    b.HasKey("SeminarID");

                    b.ToTable("Seminar");
                });

            modelBuilder.Entity("SeminarCore2.Models.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Prezime");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("ZaposlenikID");

                    b.ToTable("Zaposlenik");
                });

            modelBuilder.Entity("SeminarCore2.Models.Predbiljezba", b =>
                {
                    b.HasOne("SeminarCore2.Models.Seminar", "Seminar")
                        .WithMany("Predbiljezbe")
                        .HasForeignKey("SeminarID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}