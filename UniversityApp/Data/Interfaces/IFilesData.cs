using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityApp.Data.Models;

namespace UniversityApp.Data.Interfaces
{
    public interface IFilesData
    {
        Task<IEnumerable<Files>> ReturnFilesAsync();
        Task<Files> RemoveFileAsync(int fileId);
        Task<int> CommitAsync();
        Task<Files> GetSpecificFileAsync(int fileId);
        Task<Files> AddFileAsync(Files files);
    }
}
