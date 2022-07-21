using Microsoft.EntityFrameworkCore;
using NetCorePermissionBaseDatabase.Configurations;
using NetCorePermissionBaseDatabase.Entities;

namespace NetCorePermissionBaseDatabase.DatabaseContexts
{
    public class DataBaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=Data.db");
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
        }
    }
}
