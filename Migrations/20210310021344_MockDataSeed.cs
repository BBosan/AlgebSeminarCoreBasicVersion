using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarCore2.Migrations
{
    public partial class MockDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Predbiljezba",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Predbiljezba",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Seminar",
                columns: new[] { "SeminarID", "Datum", "Naziv", "Opis", "PopunjenDaNe" },
                values: new object[,]
                {
                    { 1, new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#", "Opis 1", true },
                    { 2, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Basic", "Opis 2", false },
                    { 3, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python", "Opis 3", true },
                    { 4, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "C++", "Opis 4", false },
                    { 5, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Java", "Opis 5", false },
                    { 6, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graphic Design", "Opis 6", false },
                    { 7, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javescript & jQuery", "Opis 7", false },
                    { 8, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angular", "Opis 8", false },
                    { 9, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby", "Opis 9", false }
                });

            migrationBuilder.InsertData(
                table: "Zaposlenik",
                columns: new[] { "ZaposlenikID", "Ime", "Password", "Prezime", "Username" },
                values: new object[] { -1, "Ivan", "Admin", "Ivanic", "Admin" });

            migrationBuilder.InsertData(
                table: "Predbiljezba",
                columns: new[] { "PredbiljezbaID", "Adresa", "BrojTelefona", "Datum", "Email", "Ime", "Prezime", "SeminarID", "StatusDaNe" },
                values: new object[,]
                {
                    { 8, "33 Amoth Pass", "1625805625", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fbranney7@cnn.com", "Faun", "Branney", 1, true },
                    { 34, "7 Twin Pines Way", "2108940577", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fmalamorex@amazon.com", "Fifine", "Malamore", 7, true },
                    { 2, "934 Northport Center", "3157073929", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "gzeale1@amazonaws.com", "Georgena", "Zeale", 7, true },
                    { 95, "0447 Burning Wood Park", "4052263142", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "nmills2m@hatena.ne.jp", "Neysa", "Mills", 6, false },
                    { 90, "996 Michigan Trail", "2466558471", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "msappson2h@marriott.com", "Morrie", "Sappson", 6, true },
                    { 88, "9 Ridgeview Park", "2218784429", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "emcgaughey2f@seattletimes.com", "Elva", "Mc Gaughey", 6, false },
                    { 78, "3 Melody Hill", "5965196455", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "speterken25@vistaprint.com", "Sabra", "Peterken", 6, true },
                    { 55, "75 Maryland Avenue", "7349551843", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "shabard1i@microsoft.com", "Sherye", "Habard", 6, true },
                    { 46, "85703 Oak Valley Circle", "3374592419", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "gwolfit19@ft.com", "Garek", "Wolfit", 6, false },
                    { 43, "1 Elka Pass", "2861855460", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmacgrath16@globo.com", "Maddalena", "MacGrath", 6, true },
                    { 36, "047 Commercial Way", "3889400373", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fhackingez@rambler.ru", "Fransisco", "Hackinge", 6, false },
                    { 33, "1 Waubesa Road", "5782652578", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "umossw@biblegateway.com", "Ursala", "Moss", 6, true },
                    { 32, "743 Straubel Alley", "3229957926", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "rbellamv@chicagotribune.com", "Read", "Bellam", 6, false },
                    { 20, "247 Acker Street", "4784773033", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ssapwellj@naver.com", "Silvan", "Sapwell", 6, true },
                    { 16, "3637 Bluejay Alley", "9492511661", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "sgittoesf@foxnews.com", "Sebastiano", "Gittoes", 6, true },
                    { 98, "67570 Warrior Pass", "8515944733", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmathie2p@princeton.edu", "Melosa", "Mathie", 5, false },
                    { 86, "3041 Roth Court", "8494210282", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jdargue2d@gnu.org", "Jany", "Dargue", 5, false },
                    { 84, "0812 Loftsgordon Plaza", "5261026496", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "hgahagan2b@yolasite.com", "Hiram", "Gahagan", 5, false },
                    { 67, "02 Rieder Circle", "2616956274", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ashemwell1u@yahoo.com", "Angie", "Shemwell", 5, true },
                    { 66, "3339 Hauk Street", "3186443831", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "sriveles1t@ucoz.ru", "Sonnie", "Riveles", 5, true },
                    { 63, "27444 Kensington Lane", "9563403608", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bfairholm1q@over-blog.com", "Barris", "Fairholm", 5, true },
                    { 52, "61227 Hanover Parkway", "4819326272", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tgiacovelli1f@nbcnews.com", "Tasia", "Giacovelli", 5, true },
                    { 45, "5368 Ilene Pass", "3428099573", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tlanger18@dell.com", "Tresa", "Langer", 7, true },
                    { 48, "23776 Forest Run Crossing", "6337918303", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mvink1b@weibo.com", "Melvin", "Vink", 5, true },
                    { 70, "8 Reinke Court", "3101385311", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "aorrin1x@harvard.edu", "Angel", "Orrin", 7, true },
                    { 81, "375 Garrison Trail", "9782096552", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bburgwyn28@hp.com", "Brigida", "Burgwyn", 7, false },
                    { 73, "5253 Raven Alley", "2545970265", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcritchlow20@ow.ly", "Mickey", "Critchlow", 9, false },
                    { 72, "15395 Garrison Place", "6124121294", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bkulvear1z@github.io", "Byron", "Kulvear", 9, true },
                    { 68, "22645 Cascade Terrace", "6048667403", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mcoursor1v@a8.net", "Minda", "Coursor", 9, false },
                    { 65, "7 Kennedy Street", "1661348024", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "goscanlan1s@stanford.edu", "Glori", "O'Scanlan", 9, true },
                    { 60, "06 Clarendon Crossing", "6131033769", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mtourner1n@prlog.org", "Mark", "Tourner", 9, false },
                    { 41, "53 Mifflin Place", "2287803132", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mbilston14@census.gov", "Marja", "Bilston", 9, true },
                    { 26, "75 Montana Center", "5316710291", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "hgulbergp@meetup.com", "Hana", "Gulberg", 9, true },
                    { 22, "7211 Manufacturers Plaza", "5703106587", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "cdumsdayl@ftc.gov", "Casper", "Dumsday", 9, true },
                    { 18, "73926 Morrow Junction", "7174787707", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "kpeckitth@addthis.com", "Kacie", "Peckitt", 9, true },
                    { 15, "448 Merchant Drive", "1125683489", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mbenziese@networkadvertising.org", "Michail", "Benzies", 9, true },
                    { 5, "45 Butternut Avenue", "3341834111", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "atiffany4@slate.com", "Alain", "Tiffany", 9, true },
                    { 96, "3444 Vera Place", "9543352672", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "abaden2n@baidu.com", "Andre", "Baden", 8, false },
                    { 87, "90 Village Green Place", "5579731320", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "kspinello2e@bloomberg.com", "Kimble", "Spinello", 8, false },
                    { 83, "905 Nancy Place", "6873159245", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "hdarling2a@dell.com", "Heath", "Darling", 8, true },
                    { 74, "703 Lake View Circle", "8803826876", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bbusst21@bravesites.com", "Brnaby", "Busst", 8, false },
                    { 59, "52674 Village Green Drive", "2454513649", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tmckinless1m@hao123.com", "Tonnie", "McKinless", 8, true },
                    { 51, "97 Lawn Plaza", "8404724615", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "cweavers1e@salon.com", "Cornela", "Weavers", 8, false },
                    { 27, "9 Pierstorff Avenue", "3327893290", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "adanettq@mtv.com", "Augustus", "Danett", 8, true },
                    { 3, "28274 Waxwing Circle", "2085217617", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mduffield2@cargocollective.com", "Mikol", "Duffield", 8, true },
                    { 100, "3 Ridgeview Crossing", "5071896550", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "kkilius2r@sciencedaily.com", "Kort", "Kilius", 7, false },
                    { 91, "7 Pankratz Circle", "3157940297", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fcordaroy2i@kickstarter.com", "Felizio", "Cordaroy", 7, true },
                    { 76, "071 Mcguire Trail", "4429101661", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "icosker23@adobe.com", "Isidro", "Cosker", 7, false },
                    { 47, "7 Charing Cross Junction", "2439852536", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "krashleigh1a@fda.gov", "Kit", "Rashleigh", 5, true },
                    { 39, "581 Gina Park", "1609554358", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "npiquard12@1und1.de", "Noak", "Piquard", 5, true },
                    { 31, "107 Banding Point", "3786824935", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "brattenburyu@statcounter.com", "Benito", "Rattenbury", 5, false },
                    { 6, "4536 Elmside Way", "3676841030", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ttapsfield5@goodreads.com", "Toddie", "Tapsfield", 3, false },
                    { 92, "6 Oxford Drive", "7442823743", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "chuyghe2j@rambler.ru", "Celie", "Huyghe", 2, false },
                    { 82, "16 Farwell Avenue", "5681390743", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ftilston29@trellian.com", "Fabe", "Tilston", 2, false },
                    { 58, "70 Randy Center", "1027689813", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "afrankes1l@omniture.com", "Arlan", "Frankes", 2, false },
                    { 53, "58 Bowman Court", "6945479897", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "lfishbourn1g@histats.com", "Linda", "Fishbourn", 2, true },
                    { 50, "20568 Northridge Hill", "7979792847", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "erubinowitch1d@epa.gov", "Elfie", "Rubinowitch", 2, true },
                    { 49, "848 Fisk Trail", "6532773069", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "hroulston1c@ebay.co.uk", "Hamid", "Roulston", 2, true },
                    { 25, "50 Carberry Court", "8316387384", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ejustiso@php.net", "Earl", "Justis", 2, false },
                    { 9, "35243 Mcbride Alley", "5205010980", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "sbisp8@vk.com", "Sandie", "Bisp", 2, false },
                    { 97, "64294 Chinook Point", "7826172779", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "pnowell2o@soundcloud.com", "Prudence", "Nowell", 1, true },
                    { 94, "0 Badeau Pass", "8771001221", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "oforkan2l@wunderground.com", "Otto", "Forkan", 1, true },
                    { 80, "61 Arrowood Avenue", "7714941396", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "solone27@weebly.com", "Say", "O' Lone", 1, false },
                    { 79, "59 Calypso Trail", "9815221384", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jtailour26@dailymotion.com", "Jeramey", "Tailour", 1, false },
                    { 75, "1385 Harbort Center", "3235671971", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "dwildgoose22@weibo.com", "Dov", "Wildgoose", 1, false },
                    { 71, "8655 Marquette Plaza", "3159185954", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "amcgillivray1y@joomla.org", "Alexander", "McGillivray", 1, false },
                    { 57, "179 Thierer Terrace", "5154100589", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbilt1k@mac.com", "Janene", "Bilt", 1, false },
                    { 38, "3 Birchwood Lane", "4971198302", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "plunam11@blinklist.com", "Pru", "Lunam", 1, true },
                    { 37, "339 Hintze Court", "8039343366", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "icrab10@springer.com", "Ives", "Crab", 1, true },
                    { 30, "71341 Kings Place", "8106137485", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "dlukasent@youtu.be", "Doug", "Lukasen", 1, true },
                    { 17, "6375 Dennis Trail", "7632981138", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "kcassyg@paypal.com", "Konstantine", "Cassy", 1, true },
                    { 14, "68 Hovde Center", "2946340613", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "lveard@ycombinator.com", "Leonard", "Vear", 1, false },
                    { 11, "07 Bluejay Hill", "4323400386", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "gmacilhaggaa@umn.edu", "Garrett", "MacIlhagga", 3, false },
                    { 19, "5050 New Castle Center", "2373518447", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "nsteedeni@berkeley.edu", "Nanice", "Steeden", 3, false },
                    { 23, "02 Garrison Circle", "1767584765", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "cforsythem@aol.com", "Claiborn", "Forsythe", 3, true },
                    { 35, "09504 Goodland Plaza", "5071818282", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "giianony@imgur.com", "Gene", "Iianon", 3, true },
                    { 28, "92 Bayside Center", "3577232352", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ksimpkissr@mashable.com", "Kippy", "Simpkiss", 5, true },
                    { 21, "63 Sachs Place", "3368486646", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "cclosek@typepad.com", "Coriss", "Close", 5, false },
                    { 10, "35488 Riverside Alley", "4625606776", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "cmocquer9@phpbb.com", "Cindy", "Mocquer", 5, true },
                    { 4, "39111 Leroy Crossing", "8165857024", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bbirks3@cdc.gov", "Beau", "Birks", 5, true },
                    { 1, "00065 Johnson Lane", "6053905224", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bknoble0@indiegogo.com", "Billie", "Knoble", 5, true },
                    { 89, "05214 Pine View Terrace", "6265404835", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "svenneur2g@dyndns.org", "Sean", "Venneur", 4, false },
                    { 77, "24168 Laurel Trail", "5941351824", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "cmacglory24@blinklist.com", "Candis", "MacGlory", 4, true },
                    { 69, "2 Pond Trail", "7283237979", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "lskippen1w@liveinternet.ru", "Lorrie", "Skippen", 4, false },
                    { 62, "0074 Thompson Parkway", "4224994386", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tivanishin1p@usgs.gov", "Talbot", "Ivanishin", 4, true },
                    { 61, "1058 Arrowood Terrace", "9758098743", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "dglabach1o@boston.com", "Diego", "Glabach", 4, true },
                    { 93, "2 Duke Court", "5891781168", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "adot2k@aboutads.info", "Antony", "Dot", 9, false },
                    { 56, "516 Anniversary Junction", "8938504375", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ekingsland1j@privacy.gov.au", "Elianore", "Kingsland", 4, true },
                    { 29, "33 Sunfield Avenue", "4313662073", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "egormans@dot.gov", "Eugenius", "Gorman", 4, true },
                    { 24, "5179 Cordelia Drive", "9482592137", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jedelmannn@google.pl", "Julian", "Edelmann", 4, true },
                    { 13, "2198 Logan Terrace", "1069173520", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "kgueinnc@amazon.co.uk", "Kim", "Gueinn", 4, false },
                    { 12, "10974 Dakota Circle", "3381321862", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "sfoskenb@opensource.org", "Steve", "Fosken", 4, true },
                    { 7, "713 Sutherland Avenue", "1366201018", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bfernandes6@biglobe.ne.jp", "Brenna", "Fernandes", 4, true },
                    { 85, "19629 Anderson Parkway", "6653503024", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "phammatt2c@oracle.com", "Patricio", "Hammatt", 3, true },
                    { 64, "025 Ilene Center", "1836791765", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "hspink1r@google.de", "Hillary", "Spink", 3, false },
                    { 54, "03331 Pankratz Center", "9813727144", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jgiordano1h@liveinternet.ru", "Jobina", "Giordano", 3, true },
                    { 44, "90395 Corry Park", "3091914190", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "jbeaney17@livejournal.com", "Julia", "Beaney", 3, true },
                    { 42, "9 Parkside Lane", "2704108843", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "glutty15@comcast.net", "Guillemette", "Lutty", 3, true },
                    { 40, "46860 Morrow Plaza", "8699322796", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mderyebarrett13@gov.uk", "Morten", "Derye-Barrett", 4, false },
                    { 99, "0022 Lakewood Avenue", "8301745124", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "rgange2q@tripod.com", "Roslyn", "Gange", 9, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Predbiljezba",
                keyColumn: "PredbiljezbaID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seminar",
                keyColumn: "SeminarID",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Predbiljezba",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Predbiljezba",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }
    }
}
