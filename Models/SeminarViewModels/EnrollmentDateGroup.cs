using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Models.SeminarViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? DatumSeminara { get; set; }
        public int StudentCount { get; set; }
        public string NazivSeminara { get; set; }

    }
}
