using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Data.UserData
{
    public class SqlDepartmentData : IDepartmentData
    {
        private readonly IUsersData usersData;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ApplicationDbContext db { get; }

        public SqlDepartmentData(ApplicationDbContext applicationDbContext,
            IUsersData usersData,
            Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            db = applicationDbContext;
            this.usersData = usersData;
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<Department> ReturnDepartments()
        {
            var query = from r in db.DbDepartment.ToList()
                        orderby r.DepartmentName
                        select r;

            return query;
        }

        public int Commit()
           => db.SaveChanges();

        public Department AddDepartment(Department department)
        {
            db.DbDepartment.Add(department);
            return department;
        }

        public Department RemoveDepartment(int departmentId)
        {
            var department = GetSpecificDepartment(departmentId);

            if (department != null)
                db.DbDepartment.Remove(department);

            return department;
        }

        public bool OpenDepartment(int departmentId)
        {
            var course = GetSpecificDepartment(departmentId);

            if (course != null)
            {
                course.SignInAvailable = true;

                db.DbDepartment.Update(course);
                Commit();
            }

            return true;
        }

        public bool CloseDepartment(int departmentId)
        {
            var course = GetSpecificDepartment(departmentId);

            if (course != null)
            {
                course.SignInAvailable = false;

                db.DbDepartment.Update(course);
                Commit();
            }

            return false;
        }

        public Department GetSpecificDepartment(int departmentId)
            => db.DbDepartment.Where(x => x.DepartmentId == departmentId).First();

        [HttpGet]
        public async Task<string> GetCurrentUserId()
        {
            ApplicationUser usr = await GetCurrentUserAsync();
            return usr?.Id;
        }

        public Task<ApplicationUser> GetCurrentUserAsync() 
            => userManager.GetUserAsync(httpContextAccessor.HttpContext.User);

        public async Task AddStudentToClass(int departmentId)
        {
            var department = GetSpecificDepartment(departmentId);

            if (department == null)
                return;

            var user = await GetCurrentUserAsync();
            
            if (user.FirstName.Any())
            {
                user.SignedToDepartment = departmentId;
                await userManager.UpdateAsync(user);
                Commit();
            }
        }

        public IEnumerable<ApplicationUser> StudentsList(int departmentId)
        {
            var department = GetSpecificDepartment(departmentId);

            var query = from r in db.DbUsers.ToList()
                        where r.SignedToDepartment == department.DepartmentId
                        select r;

            return query;
        }

        public async Task<bool> CheckIfStudentIsAdded(int departmentId)
        {
            var user = await GetCurrentUserAsync();
            var department = GetSpecificDepartment(departmentId);

            if (user.SignedToDepartment is 0)
                return false;

            if (user.SignedToDepartment > 0)
                return true;

            return false;
        }

        public IEnumerable<List<ApplicationUser>> SpecificCourseStudentsList()
        {
            return null;
        }

        public async Task DeleteStudentFromClass(int departmentID)
        {
            var department = GetSpecificDepartment(departmentID);

            if (department == null)
                return;

            var user = await GetCurrentUserAsync();

            if (user.FirstName.Any())
            {
                user.SignedToDepartment = 0;
                await userManager.UpdateAsync(user);
                Commit();
            }
        }
    }
}
