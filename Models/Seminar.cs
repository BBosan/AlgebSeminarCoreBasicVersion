using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Models
{
    public class Seminar
    {
        //[Key]
        public int SeminarID { get; set; }
        [Required]
        [StringLength(20)]
        #region REGEX
        /*
        The StringLength attribute won't prevent a user from entering white space for a name. You can use the RegularExpression attribute to apply restrictions to the input. For example, the following code requires the first character to be upper case and the remaining characters to be alphabetical:
        */ 
        #endregion
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Naziv { get; set; }
        [Required]
        [StringLength(50)]
        public string Opis { get; set; }

        [Display(Name = "Datum"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Datum { get; set; }

        [Display(Name = "Status")]
        public bool PopunjenDaNe { get; set; }

        public ICollection<Predbiljezba> Predbiljezbe { get; set; }
    }
}
