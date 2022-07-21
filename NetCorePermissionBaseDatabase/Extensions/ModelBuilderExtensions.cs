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
                    FullName = "Administrator",
                    Phone = "0987654321",
                    Address = "Gò Vấp, Tp HCM",
                    CreatedTime = DateTime.Now,
                    CreatedUser = 1,
                    UpdatedTime = DateTime.Now,
                    UpdatedUser = 1
                }
            );
        }
    }
}
