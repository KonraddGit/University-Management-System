using System;

namespace UniversityApp.Data
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
