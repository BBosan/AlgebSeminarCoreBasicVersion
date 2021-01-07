using SeminarCore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Data
{
    public class DbInitializer
    {
        public static void Initialize(MojContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Seminars.
            if (context.Seminari.Any())
            {
                return;   // DB has been seeded
            }

            context.Seminari.AddRange(
                    new Seminar
                    {
                        Naziv = "C#",
                        Opis = "Opis 1",
                        Datum = DateTime.Parse("1989-2-12"),
                        PopunjenDaNe = true
                    },

                    new Seminar
                    {
                        Naziv = "Visual Basic",
                        Opis = "Opis 2",
                        Datum = DateTime.Parse("2005-09-01"),
                        PopunjenDaNe = false
                    },

                    new Seminar
                    {
                        Naziv = "Python",
                        Opis = "Opis 3",
                        Datum = DateTime.Parse(DateTime.Now.Date.ToString()),
                        PopunjenDaNe = false
                    }
                );
            context.SaveChanges();

            context.Predbiljezbe.AddRange(
                    new Predbiljezba
                    {
                        Ime = "Jozo",
                        Prezime = "Jozic",
                        Datum = DateTime.Parse("1989-2-12"),
                        StatusDaNe = true,
                        BrojTelefona = "385098123987",
                        Adresa = "Vijenceva 12",
                        Email = "nekiemail@gmail.com",
                        SeminarID = 1
                    }
                );
            context.SaveChanges();

            context.Zaposlenici.AddRange(
                    new Zaposlenik
                    { 
                        Username = "Admin",
                        Password = "Admin",
                        Ime = "Ivan",
                        Prezime = "Ivanic"
                    }
                );
            context.SaveChanges();

        }
    }
}
