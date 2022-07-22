using Microsoft.EntityFrameworkCore;
using NetCorePermissionBaseDatabase.Configurations;
using NetCorePermissionBaseDatabase.Entities;
using NetCorePermissionBaseDatabase.Extensions;

namespace NetCorePermissionBaseDatabase.DatabaseContexts
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Menu> Menus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
                
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            // Apply Configuration
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserInfoConfiguration());
            modelBuilder.ApplyConfiguration(new RefreshTokenConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());

            // Seed data
            modelBuilder.Seed();
        }
    }
}
