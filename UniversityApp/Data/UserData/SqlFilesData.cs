using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Data.UserData
{
    public class SqlFilesData : IFilesData
    {
        private readonly ApplicationDbContext db;

        public SqlFilesData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<Files> RemoveFileAsync(int fileId)
        {
            var file = await GetSpecificFileAsync(fileId);

            if (file != null)
                db.DbFiles.Remove(file);

            return file;
        }

        public async Task<Files> GetSpecificFileAsync(int fileId)
            => await db.DbFiles.FindAsync(fileId);

        public async Task<IEnumerable<Files>> ReturnFilesAsync()
        {
            var query = from r in await db.DbFiles.ToListAsync()
                        orderby r.Date descending
                        select r;

            return query;
        }

        public async Task<Files> AddFileAsync(Files files)
        {
            await db.DbFiles.AddAsync(files);
            return files;
        }

        public async Task<int> CommitAsync()
            => await db.SaveChangesAsync();
    }
}
