using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using UniversityApp.Data.Models;

namespace UniversityApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public int ApplicationUserId { get; set; }

        [PersonalData]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [PersonalData]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [PersonalData]
        public string FullName 
        {
            get => $"{FirstName} {LastName}";
            set { }
        }

        [PersonalData]
        public UserAddress UserAddress { get; set; }

        [PersonalData]
        public UserBalance UserBalance { get; set; }
        public DateTimeOffset DateTime { get; set; } = DateTimeOffset.UtcNow;
        public int SignedToDepartment { get; set; }
    }
}
