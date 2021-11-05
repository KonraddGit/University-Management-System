using Microsoft.AspNetCore.Identity;

namespace UniversityApp.Data.Models
{
    public class UserTakes
    {
        [PersonalData]
        public int UserTakesId { get; set; }
        [PersonalData]
        public string UserId { get; set; }
        public int Semester { get; set; }
        public int Year { get; set; }
        public double Grade { get; set; }
    }
}
