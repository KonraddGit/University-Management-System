using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Pages.ManagementPanel
{
    [Authorize(Roles = "student")]
    public class SignOffFromClassModel : PageModel
    {
        private readonly IDepartmentData departmentData;

        public SignOffFromClassModel(IDepartmentData departmentData)
        {
            this.departmentData = departmentData;
        }
        public async Task<IActionResult> OnGet(int departmentID)
        {
            await departmentData.DeleteStudentFromClass(departmentID);

            return RedirectToPage($"./Index");
        }
    }
}
