using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Data.UserData
{
    public class SqlBalanceData : IBalanceData
    {
        public UserBalance ReturnUserBalance(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
