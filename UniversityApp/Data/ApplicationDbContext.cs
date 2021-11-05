using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniversityApp.Data.Models;

namespace UniversityApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Department>().HasMany(x => x.Subjects).WithOne();
            //builder.Entity<Department>().HasMany(x => x.Students).WithOne();
            //builder.Entity<Department>().HasMany(x => x.Teachers).WithOne();
        }

        public DbSet<ApplicationUser> DbUsers { get; set; }
        public DbSet<Announcement> DbAnnouncement { get; set; }
        public DbSet<UserAddress> DbUserAddress { get; set; }
        public DbSet<UserBalance> DbUserBalance { get; set; }
        public DbSet<Department> DbDepartment { get; set; }
        public DbSet<UserTakes> DbUserTakes { get; set; }
        public DbSet<UserTeaches> DbUserTeaches { get; set; }
        public DbSet<TimeSlot> DbTimeSlot { get; set; }
        public DbSet<Subject> DbSubject { get; set; }
        public DbSet<Room> DbRoom { get; set; }
        public DbSet<Files> DbFiles { get; set; }
    }
}
