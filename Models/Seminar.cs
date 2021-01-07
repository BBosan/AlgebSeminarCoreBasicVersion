using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Models
{
    public class Seminar
    {
        //[Key]
        public int SeminarID { get; set; }
        //[Required]
        public string Naziv { get; set; }
        //[Required]
        public string Opis { get; set; }

        //[Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        //[Display(Name = "Status")]
        public bool PopunjenDaNe { get; set; }

        public ICollection<Predbiljezba> Predbiljezbe { get; set; }
    }
}
