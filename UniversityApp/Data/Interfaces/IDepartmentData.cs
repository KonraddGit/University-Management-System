using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityApp.Data.Models;

namespace UniversityApp.Data.Interfaces
{
    public interface IDepartmentData
    {
        bool OpenDepartment(int departmentId);
        bool CloseDepartment(int departmentId);
        IEnumerable<Department> ReturnDepartments();
        Department RemoveDepartment(int departmentId);
        Task AddStudentToClass(int departmentId);
        Task<bool> CheckIfStudentIsAdded(int departmentId);
        Department GetSpecificDepartment(int departmentId);
        Department AddDepartment(Department department);
        public int Commit();
        IEnumerable<ApplicationUser> StudentsList(int departmentId);
        Task DeleteStudentFromClass(int departmentID);
        Task<ApplicationUser> GetCurrentUserAsync();
        //Task<ApplicationUser> AddTeacherToDepartment();
        //Task<ApplicationUser> RemoveTeacherFromDepartment();
    }
}
