using Microsoft.AspNetCore.Identity;

namespace UniversityApp.Data.Models
{
    public class UserAddress
    {
        [PersonalData]
        public int UserAddressId { get; set; }
        [PersonalData]
        public string UserId { get; set; }
        [PersonalData]
        public string Address { get; set; }
        [PersonalData]
        public string ApartamentNumber { get; set; }
        [PersonalData]
        public string City { get; set; }
        [PersonalData]
        public string State { get; set; }
        [PersonalData]
        public string ZipCode { get; set; }
        [PersonalData]
        public string Country { get; set; }
    }
}
