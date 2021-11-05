using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "office")]
    public class AddDepartmentModel : PageModel
    {
        public IDepartmentData departmentData { get; }

        [BindProperty]
        public Department Department { get; set; }

        public AddDepartmentModel(IDepartmentData department)
        {
            departmentData = department;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var department = new Department
            {
                DepartmentName = Department.DepartmentName,
                SignInAvailable = true,
                OfficeRoom = new Room { Building = Department.OfficeRoom.Building, RoomNumber = Department.OfficeRoom.RoomNumber } };

            try
            {
                departmentData.AddDepartment(department);
                departmentData.Commit();
            }
            catch (Exception)
            {
                throw;

            }

            return RedirectToPage("./DepartmentList");
        }
    }
}
