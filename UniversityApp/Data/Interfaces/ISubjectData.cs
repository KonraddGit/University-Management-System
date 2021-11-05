using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Data.Models;

namespace UniversityApp.Data.Interfaces
{
    public interface ISubjectData
    {
        Task<IEnumerable<Subject>> GetSubjectsAsync();
        Task<Subject> AddSubjectAsync(Subject subject);
        Task<int> CommitAsync();
        Task<Subject> RemoveSubjectAsync(int subjectId);
        Task<Subject> GetSpecificSubject(int subjectId);
        Subject Update(Subject subject);
    }
}
