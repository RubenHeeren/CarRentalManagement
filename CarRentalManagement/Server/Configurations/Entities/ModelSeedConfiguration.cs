using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            // Auto increments ID if left empty.
            builder.HasData
            (
                new Model { Id = 1, CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, Name = "X5", UpdatedBy = "System" },
                new Model { Id = 2, CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, Name = "3 series", UpdatedBy = "System" },
                new Model { Id = 3, CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, Name = "Prius", UpdatedBy = "System" },
                new Model { Id = 4, CreatedBy = "System", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, Name = "Vitz", UpdatedBy = "System" }
            );
        }
    }
}
