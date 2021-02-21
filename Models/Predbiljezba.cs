using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Models
{
    public class Predbiljezba
    {
        public int PredbiljezbaID { get; set; }

        [Display(Name = "Datum Rođ."), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Datum { get; set; }

        [MinLength(2, ErrorMessage = "{0} mora biti duze od 1")]
        [StringLength(maximumLength: 10, ErrorMessage = "{0} je predugacko")]
        [Required]
        public string Ime { get; set; }

        [MinLength(2, ErrorMessage = "{0} mora biti duze od 1")]
        [StringLength(maximumLength: 20, ErrorMessage = "{0} je predugacko")]
        [Required]
        public string Prezime { get; set; }

        [Required]
        public string Adresa { get; set; }

        [EmailAddress(ErrorMessage = "Krivi Format Emaila!!")]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Krivi Format Broja!! (npr: 098-234-7782)")]
        [Required]
        [Display(Name = "Br. Tel.")]
        public string BrojTelefona { get; set; }

        [Display(Name = "Status")]
        //[DisplayFormat(NullDisplayText = "NotSet")] //trebam displayfor isl, nece sa tag helper
        public Nullable<bool> StatusDaNe { get; set; }

        public int SeminarID { get; set; }
        public virtual Seminar Seminar { get; set; }
    }
}
