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
            base.OnModelCreating(modelBuilder); //fix for error after addmigration //The entity type 'IdentityUserLogin<string>' requires a primary key to be defined

            modelBuilder.Entity<Seminar>().ToTable("Seminar").HasData(
                    new Seminar
                    {
                        SeminarID = 1,
                        Naziv = "C#",
                        Opis = "Opis 1",
                        Datum = DateTime.Parse("1989-2-12"),
                        PopunjenDaNe = true
                    },

                    new Seminar
                    {
                        SeminarID = 2,
                        Naziv = "Visual Basic",
                        Opis = "Opis 2",
                        Datum = DateTime.Parse("2005-09-01"),
                        PopunjenDaNe = false
                    },

                    new Seminar
                    {
                        SeminarID = 3,
                        Naziv = "Python",
                        Opis = "Opis 3",
                        Datum = DateTime.Parse(DateTime.Now.Date.ToString()),
                        PopunjenDaNe = true
                    },

                    new Seminar
                    {
                        SeminarID = 4,
                        Naziv = "C++",
                        Opis = "Opis 4",
                        Datum = DateTime.Parse(DateTime.Now.Date.ToString()),
                        PopunjenDaNe = false
                    },

                    new Seminar
                    {
                        SeminarID = 5,
                        Naziv = "Java",
                        Opis = "Opis 5",
                        Datum = DateTime.Parse(DateTime.Now.Date.ToString()),
                        PopunjenDaNe = false
                    },

                    new Seminar
                    {
                        SeminarID = 6,
                        Naziv = "Graphic Design",
                        Opis = "Opis 6",
                        Datum = DateTime.Parse(DateTime.Now.Date.ToString()),
                        PopunjenDaNe = false
                    },

                    new Seminar
                    {
                        SeminarID = 7,
                        Naziv = "Javescript & jQuery",
                        Opis = "Opis 7",
                        Datum = DateTime.Parse(DateTime.Now.Date.ToString()),
                        PopunjenDaNe = false
                    },

                    new Seminar
                    {
                        SeminarID = 8,
                        Naziv = "Angular",
                        Opis = "Opis 8",
                        Datum = DateTime.Parse(DateTime.Now.Date.ToString()),
                        PopunjenDaNe = false
                    },

                    new Seminar
                    {
                        SeminarID = 9,
                        Naziv = "Ruby",
                        Opis = "Opis 9",
                        Datum = DateTime.Parse(DateTime.Now.Date.ToString()),
                        PopunjenDaNe = false
                    }

                );

            modelBuilder.Entity<Predbiljezba>().ToTable("Predbiljezba").HasData(
                    new Predbiljezba
                    {
                        PredbiljezbaID = 1,
                        Ime = "Billie",
                        Prezime = "Knoble",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "6053905224",
                        Adresa = "00065 Johnson Lane",
                        Email = "bknoble0@indiegogo.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 2,
                        Ime = "Georgena",
                        Prezime = "Zeale",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3157073929",
                        Adresa = "934 Northport Center",
                        Email = "gzeale1@amazonaws.com",
                        SeminarID = 7
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 3,
                        Ime = "Mikol",
                        Prezime = "Duffield",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2085217617",
                        Adresa = "28274 Waxwing Circle",
                        Email = "mduffield2@cargocollective.com",
                        SeminarID = 8
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 4,
                        Ime = "Beau",
                        Prezime = "Birks",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "8165857024",
                        Adresa = "39111 Leroy Crossing",
                        Email = "bbirks3@cdc.gov",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 5,
                        Ime = "Alain",
                        Prezime = "Tiffany",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3341834111",
                        Adresa = "45 Butternut Avenue",
                        Email = "atiffany4@slate.com",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 6,
                        Ime = "Toddie",
                        Prezime = "Tapsfield",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "3676841030",
                        Adresa = "4536 Elmside Way",
                        Email = "ttapsfield5@goodreads.com",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 7,
                        Ime = "Brenna",
                        Prezime = "Fernandes",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "1366201018",
                        Adresa = "713 Sutherland Avenue",
                        Email = "bfernandes6@biglobe.ne.jp",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 8,
                        Ime = "Faun",
                        Prezime = "Branney",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "1625805625",
                        Adresa = "33 Amoth Pass",
                        Email = "fbranney7@cnn.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 9,
                        Ime = "Sandie",
                        Prezime = "Bisp",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "5205010980",
                        Adresa = "35243 Mcbride Alley",
                        Email = "sbisp8@vk.com",
                        SeminarID = 2
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 10,
                        Ime = "Cindy",
                        Prezime = "Mocquer",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "4625606776",
                        Adresa = "35488 Riverside Alley",
                        Email = "cmocquer9@phpbb.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 11,
                        Ime = "Garrett",
                        Prezime = "MacIlhagga",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "4323400386",
                        Adresa = "07 Bluejay Hill",
                        Email = "gmacilhaggaa@umn.edu",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 12,
                        Ime = "Steve",
                        Prezime = "Fosken",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3381321862",
                        Adresa = "10974 Dakota Circle",
                        Email = "sfoskenb@opensource.org",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 13,
                        Ime = "Kim",
                        Prezime = "Gueinn",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "1069173520",
                        Adresa = "2198 Logan Terrace",
                        Email = "kgueinnc@amazon.co.uk",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 14,
                        Ime = "Leonard",
                        Prezime = "Vear",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "2946340613",
                        Adresa = "68 Hovde Center",
                        Email = "lveard@ycombinator.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 15,
                        Ime = "Michail",
                        Prezime = "Benzies",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "1125683489",
                        Adresa = "448 Merchant Drive",
                        Email = "mbenziese@networkadvertising.org",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 16,
                        Ime = "Sebastiano",
                        Prezime = "Gittoes",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "9492511661",
                        Adresa = "3637 Bluejay Alley",
                        Email = "sgittoesf@foxnews.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 17,
                        Ime = "Konstantine",
                        Prezime = "Cassy",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "7632981138",
                        Adresa = "6375 Dennis Trail",
                        Email = "kcassyg@paypal.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 18,
                        Ime = "Kacie",
                        Prezime = "Peckitt",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "7174787707",
                        Adresa = "73926 Morrow Junction",
                        Email = "kpeckitth@addthis.com",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 19,
                        Ime = "Nanice",
                        Prezime = "Steeden",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "2373518447",
                        Adresa = "5050 New Castle Center",
                        Email = "nsteedeni@berkeley.edu",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 20,
                        Ime = "Silvan",
                        Prezime = "Sapwell",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "4784773033",
                        Adresa = "247 Acker Street",
                        Email = "ssapwellj@naver.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 21,
                        Ime = "Coriss",
                        Prezime = "Close",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "3368486646",
                        Adresa = "63 Sachs Place",
                        Email = "cclosek@typepad.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 22,
                        Ime = "Casper",
                        Prezime = "Dumsday",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "5703106587",
                        Adresa = "7211 Manufacturers Plaza",
                        Email = "cdumsdayl@ftc.gov",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 23,
                        Ime = "Claiborn",
                        Prezime = "Forsythe",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "1767584765",
                        Adresa = "02 Garrison Circle",
                        Email = "cforsythem@aol.com",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 24,
                        Ime = "Julian",
                        Prezime = "Edelmann",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "9482592137",
                        Adresa = "5179 Cordelia Drive",
                        Email = "jedelmannn@google.pl",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 25,
                        Ime = "Earl",
                        Prezime = "Justis",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "8316387384",
                        Adresa = "50 Carberry Court",
                        Email = "ejustiso@php.net",
                        SeminarID = 2
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 26,
                        Ime = "Hana",
                        Prezime = "Gulberg",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "5316710291",
                        Adresa = "75 Montana Center",
                        Email = "hgulbergp@meetup.com",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 27,
                        Ime = "Augustus",
                        Prezime = "Danett",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3327893290",
                        Adresa = "9 Pierstorff Avenue",
                        Email = "adanettq@mtv.com",
                        SeminarID = 8
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 28,
                        Ime = "Kippy",
                        Prezime = "Simpkiss",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3577232352",
                        Adresa = "92 Bayside Center",
                        Email = "ksimpkissr@mashable.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 29,
                        Ime = "Eugenius",
                        Prezime = "Gorman",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "4313662073",
                        Adresa = "33 Sunfield Avenue",
                        Email = "egormans@dot.gov",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 30,
                        Ime = "Doug",
                        Prezime = "Lukasen",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "8106137485",
                        Adresa = "71341 Kings Place",
                        Email = "dlukasent@youtu.be",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 31,
                        Ime = "Benito",
                        Prezime = "Rattenbury",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "3786824935",
                        Adresa = "107 Banding Point",
                        Email = "brattenburyu@statcounter.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 32,
                        Ime = "Read",
                        Prezime = "Bellam",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "3229957926",
                        Adresa = "743 Straubel Alley",
                        Email = "rbellamv@chicagotribune.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 33,
                        Ime = "Ursala",
                        Prezime = "Moss",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "5782652578",
                        Adresa = "1 Waubesa Road",
                        Email = "umossw@biblegateway.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 34,
                        Ime = "Fifine",
                        Prezime = "Malamore",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2108940577",
                        Adresa = "7 Twin Pines Way",
                        Email = "fmalamorex@amazon.com",
                        SeminarID = 7
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 35,
                        Ime = "Gene",
                        Prezime = "Iianon",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "5071818282",
                        Adresa = "09504 Goodland Plaza",
                        Email = "giianony@imgur.com",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 36,
                        Ime = "Fransisco",
                        Prezime = "Hackinge",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "3889400373",
                        Adresa = "047 Commercial Way",
                        Email = "fhackingez@rambler.ru",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 37,
                        Ime = "Ives",
                        Prezime = "Crab",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "8039343366",
                        Adresa = "339 Hintze Court",
                        Email = "icrab10@springer.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 38,
                        Ime = "Pru",
                        Prezime = "Lunam",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "4971198302",
                        Adresa = "3 Birchwood Lane",
                        Email = "plunam11@blinklist.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 39,
                        Ime = "Noak",
                        Prezime = "Piquard",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "1609554358",
                        Adresa = "581 Gina Park",
                        Email = "npiquard12@1und1.de",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 40,
                        Ime = "Morten",
                        Prezime = "Derye-Barrett",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "8699322796",
                        Adresa = "46860 Morrow Plaza",
                        Email = "mderyebarrett13@gov.uk",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 41,
                        Ime = "Marja",
                        Prezime = "Bilston",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2287803132",
                        Adresa = "53 Mifflin Place",
                        Email = "mbilston14@census.gov",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 42,
                        Ime = "Guillemette",
                        Prezime = "Lutty",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2704108843",
                        Adresa = "9 Parkside Lane",
                        Email = "glutty15@comcast.net",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 43,
                        Ime = "Maddalena",
                        Prezime = "MacGrath",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2861855460",
                        Adresa = "1 Elka Pass",
                        Email = "mmacgrath16@globo.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 44,
                        Ime = "Julia",
                        Prezime = "Beaney",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3091914190",
                        Adresa = "90395 Corry Park",
                        Email = "jbeaney17@livejournal.com",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 45,
                        Ime = "Tresa",
                        Prezime = "Langer",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3428099573",
                        Adresa = "5368 Ilene Pass",
                        Email = "tlanger18@dell.com",
                        SeminarID = 7
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 46,
                        Ime = "Garek",
                        Prezime = "Wolfit",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "3374592419",
                        Adresa = "85703 Oak Valley Circle",
                        Email = "gwolfit19@ft.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 47,
                        Ime = "Kit",
                        Prezime = "Rashleigh",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2439852536",
                        Adresa = "7 Charing Cross Junction",
                        Email = "krashleigh1a@fda.gov",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 48,
                        Ime = "Melvin",
                        Prezime = "Vink",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "6337918303",
                        Adresa = "23776 Forest Run Crossing",
                        Email = "mvink1b@weibo.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 49,
                        Ime = "Hamid",
                        Prezime = "Roulston",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "6532773069",
                        Adresa = "848 Fisk Trail",
                        Email = "hroulston1c@ebay.co.uk",
                        SeminarID = 2
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 50,
                        Ime = "Elfie",
                        Prezime = "Rubinowitch",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "7979792847",
                        Adresa = "20568 Northridge Hill",
                        Email = "erubinowitch1d@epa.gov",
                        SeminarID = 2
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 51,
                        Ime = "Cornela",
                        Prezime = "Weavers",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "8404724615",
                        Adresa = "97 Lawn Plaza",
                        Email = "cweavers1e@salon.com",
                        SeminarID = 8
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 52,
                        Ime = "Tasia",
                        Prezime = "Giacovelli",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "4819326272",
                        Adresa = "61227 Hanover Parkway",
                        Email = "tgiacovelli1f@nbcnews.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 53,
                        Ime = "Linda",
                        Prezime = "Fishbourn",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "6945479897",
                        Adresa = "58 Bowman Court",
                        Email = "lfishbourn1g@histats.com",
                        SeminarID = 2
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 54,
                        Ime = "Jobina",
                        Prezime = "Giordano",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "9813727144",
                        Adresa = "03331 Pankratz Center",
                        Email = "jgiordano1h@liveinternet.ru",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 55,
                        Ime = "Sherye",
                        Prezime = "Habard",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "7349551843",
                        Adresa = "75 Maryland Avenue",
                        Email = "shabard1i@microsoft.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 56,
                        Ime = "Elianore",
                        Prezime = "Kingsland",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "8938504375",
                        Adresa = "516 Anniversary Junction",
                        Email = "ekingsland1j@privacy.gov.au",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 57,
                        Ime = "Janene",
                        Prezime = "Bilt",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "5154100589",
                        Adresa = "179 Thierer Terrace",
                        Email = "jbilt1k@mac.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 58,
                        Ime = "Arlan",
                        Prezime = "Frankes",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "1027689813",
                        Adresa = "70 Randy Center",
                        Email = "afrankes1l@omniture.com",
                        SeminarID = 2
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 59,
                        Ime = "Tonnie",
                        Prezime = "McKinless",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2454513649",
                        Adresa = "52674 Village Green Drive",
                        Email = "tmckinless1m@hao123.com",
                        SeminarID = 8
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 60,
                        Ime = "Mark",
                        Prezime = "Tourner",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "6131033769",
                        Adresa = "06 Clarendon Crossing",
                        Email = "mtourner1n@prlog.org",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 61,
                        Ime = "Diego",
                        Prezime = "Glabach",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "9758098743",
                        Adresa = "1058 Arrowood Terrace",
                        Email = "dglabach1o@boston.com",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 62,
                        Ime = "Talbot",
                        Prezime = "Ivanishin",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "4224994386",
                        Adresa = "0074 Thompson Parkway",
                        Email = "tivanishin1p@usgs.gov",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 63,
                        Ime = "Barris",
                        Prezime = "Fairholm",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "9563403608",
                        Adresa = "27444 Kensington Lane",
                        Email = "bfairholm1q@over-blog.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 64,
                        Ime = "Hillary",
                        Prezime = "Spink",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "1836791765",
                        Adresa = "025 Ilene Center",
                        Email = "hspink1r@google.de",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 65,
                        Ime = "Glori",
                        Prezime = "O'Scanlan",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "1661348024",
                        Adresa = "7 Kennedy Street",
                        Email = "goscanlan1s@stanford.edu",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 66,
                        Ime = "Sonnie",
                        Prezime = "Riveles",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3186443831",
                        Adresa = "3339 Hauk Street",
                        Email = "sriveles1t@ucoz.ru",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 67,
                        Ime = "Angie",
                        Prezime = "Shemwell",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2616956274",
                        Adresa = "02 Rieder Circle",
                        Email = "ashemwell1u@yahoo.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 68,
                        Ime = "Minda",
                        Prezime = "Coursor",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "6048667403",
                        Adresa = "22645 Cascade Terrace",
                        Email = "mcoursor1v@a8.net",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 69,
                        Ime = "Lorrie",
                        Prezime = "Skippen",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "7283237979",
                        Adresa = "2 Pond Trail",
                        Email = "lskippen1w@liveinternet.ru",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 70,
                        Ime = "Angel",
                        Prezime = "Orrin",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3101385311",
                        Adresa = "8 Reinke Court",
                        Email = "aorrin1x@harvard.edu",
                        SeminarID = 7
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 71,
                        Ime = "Alexander",
                        Prezime = "McGillivray",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "3159185954",
                        Adresa = "8655 Marquette Plaza",
                        Email = "amcgillivray1y@joomla.org",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 72,
                        Ime = "Byron",
                        Prezime = "Kulvear",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "6124121294",
                        Adresa = "15395 Garrison Place",
                        Email = "bkulvear1z@github.io",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 73,
                        Ime = "Mickey",
                        Prezime = "Critchlow",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "2545970265",
                        Adresa = "5253 Raven Alley",
                        Email = "mcritchlow20@ow.ly",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 74,
                        Ime = "Brnaby",
                        Prezime = "Busst",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "8803826876",
                        Adresa = "703 Lake View Circle",
                        Email = "bbusst21@bravesites.com",
                        SeminarID = 8
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 75,
                        Ime = "Dov",
                        Prezime = "Wildgoose",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "3235671971",
                        Adresa = "1385 Harbort Center",
                        Email = "dwildgoose22@weibo.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 76,
                        Ime = "Isidro",
                        Prezime = "Cosker",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "4429101661",
                        Adresa = "071 Mcguire Trail",
                        Email = "icosker23@adobe.com",
                        SeminarID = 7
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 77,
                        Ime = "Candis",
                        Prezime = "MacGlory",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "5941351824",
                        Adresa = "24168 Laurel Trail",
                        Email = "cmacglory24@blinklist.com",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 78,
                        Ime = "Sabra",
                        Prezime = "Peterken",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "5965196455",
                        Adresa = "3 Melody Hill",
                        Email = "speterken25@vistaprint.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 79,
                        Ime = "Jeramey",
                        Prezime = "Tailour",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "9815221384",
                        Adresa = "59 Calypso Trail",
                        Email = "jtailour26@dailymotion.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 80,
                        Ime = "Say",
                        Prezime = "O' Lone",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "7714941396",
                        Adresa = "61 Arrowood Avenue",
                        Email = "solone27@weebly.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 81,
                        Ime = "Brigida",
                        Prezime = "Burgwyn",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "9782096552",
                        Adresa = "375 Garrison Trail",
                        Email = "bburgwyn28@hp.com",
                        SeminarID = 7
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 82,
                        Ime = "Fabe",
                        Prezime = "Tilston",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "5681390743",
                        Adresa = "16 Farwell Avenue",
                        Email = "ftilston29@trellian.com",
                        SeminarID = 2
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 83,
                        Ime = "Heath",
                        Prezime = "Darling",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "6873159245",
                        Adresa = "905 Nancy Place",
                        Email = "hdarling2a@dell.com",
                        SeminarID = 8
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 84,
                        Ime = "Hiram",
                        Prezime = "Gahagan",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "5261026496",
                        Adresa = "0812 Loftsgordon Plaza",
                        Email = "hgahagan2b@yolasite.com",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 85,
                        Ime = "Patricio",
                        Prezime = "Hammatt",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "6653503024",
                        Adresa = "19629 Anderson Parkway",
                        Email = "phammatt2c@oracle.com",
                        SeminarID = 3
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 86,
                        Ime = "Jany",
                        Prezime = "Dargue",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "8494210282",
                        Adresa = "3041 Roth Court",
                        Email = "jdargue2d@gnu.org",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 87,
                        Ime = "Kimble",
                        Prezime = "Spinello",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "5579731320",
                        Adresa = "90 Village Green Place",
                        Email = "kspinello2e@bloomberg.com",
                        SeminarID = 8
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 88,
                        Ime = "Elva",
                        Prezime = "Mc Gaughey",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "2218784429",
                        Adresa = "9 Ridgeview Park",
                        Email = "emcgaughey2f@seattletimes.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 89,
                        Ime = "Sean",
                        Prezime = "Venneur",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "6265404835",
                        Adresa = "05214 Pine View Terrace",
                        Email = "svenneur2g@dyndns.org",
                        SeminarID = 4
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 90,
                        Ime = "Morrie",
                        Prezime = "Sappson",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "2466558471",
                        Adresa = "996 Michigan Trail",
                        Email = "msappson2h@marriott.com",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 91,
                        Ime = "Felizio",
                        Prezime = "Cordaroy",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "3157940297",
                        Adresa = "7 Pankratz Circle",
                        Email = "fcordaroy2i@kickstarter.com",
                        SeminarID = 7
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 92,
                        Ime = "Celie",
                        Prezime = "Huyghe",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "7442823743",
                        Adresa = "6 Oxford Drive",
                        Email = "chuyghe2j@rambler.ru",
                        SeminarID = 2
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 93,
                        Ime = "Antony",
                        Prezime = "Dot",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "5891781168",
                        Adresa = "2 Duke Court",
                        Email = "adot2k@aboutads.info",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 94,
                        Ime = "Otto",
                        Prezime = "Forkan",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "8771001221",
                        Adresa = "0 Badeau Pass",
                        Email = "oforkan2l@wunderground.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 95,
                        Ime = "Neysa",
                        Prezime = "Mills",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "4052263142",
                        Adresa = "0447 Burning Wood Park",
                        Email = "nmills2m@hatena.ne.jp",
                        SeminarID = 6
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 96,
                        Ime = "Andre",
                        Prezime = "Baden",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "9543352672",
                        Adresa = "3444 Vera Place",
                        Email = "abaden2n@baidu.com",
                        SeminarID = 8
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 97,
                        Ime = "Prudence",
                        Prezime = "Nowell",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "7826172779",
                        Adresa = "64294 Chinook Point",
                        Email = "pnowell2o@soundcloud.com",
                        SeminarID = 1
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 98,
                        Ime = "Melosa",
                        Prezime = "Mathie",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "8515944733",
                        Adresa = "67570 Warrior Pass",
                        Email = "mmathie2p@princeton.edu",
                        SeminarID = 5
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 99,
                        Ime = "Roslyn",
                        Prezime = "Gange",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = true,
                        BrojTelefona = "8301745124",
                        Adresa = "0022 Lakewood Avenue",
                        Email = "rgange2q@tripod.com",
                        SeminarID = 9
                    }, new Predbiljezba
                    {
                        PredbiljezbaID = 100,
                        Ime = "Kort",
                        Prezime = "Kilius",
                        Datum = DateTime.Parse("2023-03-10"),
                        StatusDaNe = false,
                        BrojTelefona = "5071896550",
                        Adresa = "3 Ridgeview Crossing",
                        Email = "kkilius2r@sciencedaily.com",
                        SeminarID = 7
                    }
                );

            modelBuilder.Entity<Zaposlenik>().ToTable("Zaposlenik").HasData(
                    new Zaposlenik
                    {
                        ZaposlenikID = -1,
                        Username = "Admin",
                        Password = "Admin",
                        Ime = "Ivan",
                        Prezime = "Ivanic"
                    }
                );


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
