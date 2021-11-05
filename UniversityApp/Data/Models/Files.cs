using System;

namespace UniversityApp.Data.Models
{
    public class Files
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Content { get; set; }
        public string AcademicYear { get; set; }
        public string FileName
        {
            get
            {
                var semestr = Semester.Letni;
                var date = DateTime.Now;

                if (date.Month > 8 && date.Month < 3)
                    semestr = Semester.Zimowy;

                var fileName = $"Plan {AcademicYear} semestr {semestr}";

                return fileName;
            }
            set { }
        }

        public enum Semester
        {
            Letni = 0,
            Zimowy = 1
        }
    }
}
