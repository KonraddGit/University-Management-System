using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Data.Interfaces;
using UniversityApp.Data.Models;

namespace UniversityApp.Data.UserData
{
    public class SqlSubjectData : ISubjectData
    {
        private readonly ApplicationDbContext db;

        public SqlSubjectData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<Subject> AddSubjectAsync(Subject subject)
        {
            await db.DbSubject.AddAsync(subject);
            return subject;
        }

        public async Task<int> CommitAsync()
            => await db.SaveChangesAsync();

        public async Task<IEnumerable<Subject>> GetSubjectsAsync()
        {
            var query = from r in await db.DbSubject.ToListAsync()
                        orderby r.SubjectId
                        select r;

            return query;
        }

        public async Task<Subject> RemoveSubjectAsync(int subjectId)
        {
            var subject = await GetSpecificSubject(subjectId);

            if (subject != null)
                db.DbSubject.Remove(subject);

            return subject;
        }

        public async Task<Subject> GetSpecificSubject(int subjectId)
           => await db.DbSubject.Where(x => x.SubjectId == subjectId).FirstAsync();

        public Subject Update(Subject subject)
        {
            db.DbSubject.Attach(subject).State = EntityState.Modified;
            return subject;
        }
    }
}
