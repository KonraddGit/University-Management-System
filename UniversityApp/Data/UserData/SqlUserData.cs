using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Data.Interfaces;

namespace UniversityApp.Data.SqlData
{
    public class SqlUserData : IUsersData
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        public SqlUserData(ApplicationDbContext db,
            UserManager<ApplicationUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        public ApplicationUser Add(ApplicationUser newUser)
        {
            db.Add(newUser);
            return newUser;
        }

        public int Commit()
            => db.SaveChanges();

        public ApplicationUser ConfirmUser(string id)
        {
            var user = db.DbUsers.First(x => x.Id == id);
            user.EmailConfirmed = true;
            return user;
        }

        public ApplicationUser Delete(string id)
        {
            var user = GetSpecificUser(id);

            if (user != null)
                db.Users.Remove(user);

            return user;
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            var query = from r in db.DbUsers.ToList()
                        orderby r.FullName
                        select r;

            return query;
        }

        public IEnumerable<ApplicationUser> GetNotConfirmedUsers()
            => db.DbUsers.Where(x => x.EmailConfirmed == false).ToList();

        public ApplicationUser GetSpecificUser(string name)
            => db.DbUsers.Find(name);

        public ApplicationUser Update(ApplicationUser updateUser)
        {
            db.Users.Attach(updateUser).State = EntityState.Modified;
            return updateUser;
        }

        public async Task<IEnumerable<ApplicationUser>> GetTeachersAsync()
        {
            var query = from r in await db.DbUsers.ToListAsync()
                        where userManager.IsInRoleAsync(r, "teacher").Result
                        orderby r.FullName
                        select r;

            return query;
        }

        public string ReturnRole(ApplicationUser user)
        {
            string role = String.Empty;

            foreach (var item in userManager.GetRolesAsync(user).Result)
            {
                role += item;
            }

            return role;
        }
    }
}
