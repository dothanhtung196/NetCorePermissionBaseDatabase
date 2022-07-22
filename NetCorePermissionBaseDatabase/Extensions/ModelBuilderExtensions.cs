using Microsoft.EntityFrameworkCore;
using NetCorePermissionBaseDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCorePermissionBaseDatabase.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    Id = 1,
                    Username = "Administrator",
                    Password = "123456",
                    AccessToken = "",
                    CreatedTime = DateTime.Now,
                    CreatedUser = 1,
                    UpdatedTime = DateTime.Now,
                    UpdatedUser = 1
                },
                new User
                {
                    Id = 2,
                    Username = "Employee",
                    Password = "123456",
                    AccessToken = "",
                    CreatedTime = DateTime.Now,
                    CreatedUser = 1,
                    UpdatedTime = DateTime.Now,
                    UpdatedUser = 1
                },
                new User
                {
                    Id = 3,
                    Username = "Guest",
                    Password = "123456",
                    AccessToken = "",
                    CreatedTime = DateTime.Now,
                    CreatedUser = 1,
                    UpdatedTime = DateTime.Now,
                    UpdatedUser = 1
                }
            );

            modelBuilder.Entity<Role>().HasData
            (
                new Role
                {
                    Id = 1,
                    Name = "Administrator",
                },
                new Role
                {
                    Id = 2,
                    Name = "Employee",
                },
                new Role
                {
                    Id = 3,
                    Name = "Guest",
                }
            );

            modelBuilder.Entity<Permission>().HasData
            (
                new Permission
                {
                    Id = 1,
                    Name = "View",
                },
                new Permission
                {
                    Id = 2,
                    Name = "Add",
                },
                new Permission
                {
                    Id = 3,
                    Name = "Edit",
                },
                new Permission
                {
                    Id = 4,
                    Name = "Delete",
                },
                new Permission
                {
                    Id = 5,
                    Name = "Export",
                },
                new Permission
                {
                    Id = 6,
                    Name = "Import",
                }
            );
        }
    }
}
