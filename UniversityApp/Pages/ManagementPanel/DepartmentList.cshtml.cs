using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "student, office")]
    public class DepartmentListModel : PageModel
    {
        public IDepartmentData DepartmentData { get; }
        public DepartmentListModel(IDepartmentData departmentData)
        {
            DepartmentData = departmentData;
        }
        public IEnumerable<Department> Departments { get; set; }

        public void OnGet()
        {
            Departments = DepartmentData.ReturnDepartments();
        }
    }
}
