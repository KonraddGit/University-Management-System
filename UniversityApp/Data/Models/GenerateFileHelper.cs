using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Data.Models
{
    public class GenerateFileHelper
    {
        [Display(Name = "Data")]
        public List<string> Date { get; set; }

        [Display(Name = "Rok Akademicki")]
        public string AcademicYear { get; set; }

        [Display(Name = "Nauczyciel")]
        public IEnumerable<string> Teacher { get; set; }

        [Display(Name = "Przedmiot")]
        public ICollection<string> Subject { get; set; }
    }
}
