using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Models
{
    public class Predbiljezba
    {
        public int PredbiljezbaID { get; set; }
        public DateTime Datum { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public Nullable<bool> StatusDaNe { get; set; }

        public int SeminarID { get; set; }
        public virtual Seminar Seminar { get; set; }
    }
}
