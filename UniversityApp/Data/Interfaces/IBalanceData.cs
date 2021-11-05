using UniversityApp.Data.Models;

namespace UniversityApp.Data.Interfaces
{
    public interface IBalanceData
    {
        UserBalance ReturnUserBalance(string userId);


    }
}
