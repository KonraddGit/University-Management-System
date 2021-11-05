using System.Collections.Generic;

namespace UniversityApp.Data.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Room Room { get; set; }
        public List<TimeSlot> TimeSlot { get; set; } 
    }
}