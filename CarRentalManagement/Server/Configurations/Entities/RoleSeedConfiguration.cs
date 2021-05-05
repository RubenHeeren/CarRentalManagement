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
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
            (
                new IdentityRole 
                { 
                    Id = "13cbb285-08fd-4e6c-87dc-a85e520b168e", 
                    Name = "User", 
                    NormalizedName = "USER" 
                },
                new IdentityRole 
                { 
                    Id = "0770a08e-3529-4ccc-ae8e-145059a2192f", 
                    Name = "Administrator", 
                    NormalizedName = "ADMINISTRATOR" 
                }
            );
        }
    }
}
