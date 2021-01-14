using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Models
{
    public class Zaposlenik
    {
        public int ZaposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        [Required]
        [Display(Name = "Korisnik:")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Lozinka:")]
        public string Password { get; set; }
    }
}
