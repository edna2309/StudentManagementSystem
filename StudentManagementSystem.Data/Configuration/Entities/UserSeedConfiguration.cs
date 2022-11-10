using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Data.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var passwordHasher = new PasswordHasher<User>();
            builder.HasData(
                new User
                {
                    Id = "807d4075-6fa0-465e-aa89-6255708fde21",
                    Email = "superadmin@localhost.com",
                    UserName = "superadmin@localhost.com",
                    NormalizedEmail = "SUPERADMIN@LOCALHOST.COM",
                    NormalizedUserName = "SUPERADMIN@LOCALHOST.COM",
                    FirstName = "SuperAdmin",
                    LastName = "SuperAdmin",
                    PasswordHash = passwordHasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true, 
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now                  
                },
                new User
                {
                    Id = "5843c9b4-cb39-4efd-843c-dbaea81c4706",
                    Email = "sysmanager@localhost.com",
                    UserName = "sysmanager@localhost.com",
                    NormalizedEmail = "SYSMANAGER@LOCALHOST.COM",
                    NormalizedUserName = "SYSMANAGER@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Manager",
                    PasswordHash = passwordHasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
                );
        }
    }
}
