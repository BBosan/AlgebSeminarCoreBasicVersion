using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Models
{
    public class Predbiljezba
    {
        //[Key]
        public int PredbiljezbaID { get; set; }

        [Display(Name = "Rođ."), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Datum { get; set; }

        [MinLength(2, ErrorMessage = "{0} mora biti duze od 1")]
        [StringLength(maximumLength: 20, ErrorMessage = "{0} je predugacko")]
        [Required]
        [RegularExpression(/*@"^[A-Z]+[a-zA-Z]*$"*/ @"^[A-Z]+[-a-zA-Z0-9-()]+(\s+[-a-zA-Z0-9-()]+)*$", ErrorMessage = "First letter must be UPPERCASE + no whitespace at start/end")]
        public string Ime { get; set; }

        [MinLength(2, ErrorMessage = "{0} mora biti duze od 1")]
        [StringLength(maximumLength: 30, ErrorMessage = "{0} je predugacko")]
        [Required]
        [RegularExpression(/*@"^[A-Z]+[a-zA-Z]*$"*/ @"^[A-Z]+[-a-zA-Z0-9-()]+(\s+[-a-zA-Z0-9-()]+)*$", ErrorMessage = "First letter must be UPPERCASE + no whitespace at start/end")]
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
        public Nullable<bool> StatusDaNe { get; set; }

        public int SeminarID { get; set; }
        public virtual Seminar Seminar { get; set; }
    }
}
