using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Data.Models
{
    public class UserTeaches
    {
        [PersonalData]
        public int UserTeachesId{ get; set; }
        [PersonalData]
        public string UserId { get; set; }
        public int Semester { get; set; }
        public int Year { get; set; }
    }
}
