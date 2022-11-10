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
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    //SuperAdmin
                    RoleId = "88105423-d222-48ec-85c5-04e4f3cb2aa6",
                    UserId = "807d4075-6fa0-465e-aa89-6255708fde21"
                },
                new IdentityUserRole<string>
                {
                    //SystemManager
                    RoleId = "4a15c4bc-ffac-481c-b997-475a1e82c911",
                    UserId = "5843c9b4-cb39-4efd-843c-dbaea81c4706"
                });
        }
    }
}
