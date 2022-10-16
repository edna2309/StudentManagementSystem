using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Common.Constants;

namespace StudentManagementSystem.Data.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "88105423-d222-48ec-85c5-04e4f3cb2aa6",
                    Name = Roles.SuperAdmin,
                    NormalizedName = Roles.SuperAdmin.ToUpper()
                },
                new IdentityRole
                {
                    Id = "4a15c4bc-ffac-481c-b997-475a1e82c911",
                    Name = Roles.SystemManager,
                    NormalizedName = Roles.SystemManager.ToUpper()
                },
                new IdentityRole
                {
                    Id = "8bb3807a-9f64-42a6-9b15-e9ca45435d16",
                    Name = Roles.Student,
                    NormalizedName = Roles.Student.ToUpper()
                }); ;
        }
    }
}
