using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            var hasher = new PasswordHasher<IdentityUserRole<string>>();

            builder.HasData
            (
                new IdentityUserRole<string>
                { 
                    RoleId = "0770a08e-3529-4ccc-ae8e-145059a2192f",                     
                    UserId = "160ff901-ef5f-4512-91eb-361cac1106f4"                    
                },
                new IdentityUserRole<string>
                {
                    RoleId = "13cbb285-08fd-4e6c-87dc-a85e520b168e",
                    UserId = "870c51c3-c551-4bdf-b5a7-709f3d41706f"
                }
            );
        }
    }
}
