using Microsoft.AspNetCore.Identity;

namespace UniversityApp.Data.Models
{
    public class UserBalance
    {
        [PersonalData]
        public int UserBalanceId { get; set; }

        [PersonalData]
        public string UserId { get; set; }

        [PersonalData]
        public double Balance { get; set; }

        [PersonalData]
        public int ECTS { get; set; }
    }
}
