using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniversityApp.Data.Interfaces
{
    public interface IUsersData
    {
        IEnumerable<ApplicationUser> GetAllUsers();
        IEnumerable<ApplicationUser> GetNotConfirmedUsers();
        ApplicationUser GetSpecificUser(string name);
        ApplicationUser Update(ApplicationUser updateUser);
        ApplicationUser Add(ApplicationUser newUser);
        ApplicationUser Delete(string id);
        ApplicationUser ConfirmUser(string id);
        int Commit();
        string ReturnRole(ApplicationUser user);
        Task<IEnumerable<ApplicationUser>> GetTeachersAsync();
    }
}
