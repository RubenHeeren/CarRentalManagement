using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
    {
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public virtual Customer Customer { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn != null)
            {
                // Business rule
                if (DateIn <= DateOut)
                {
                    yield return new ValidationResult("Date in must be greater than date out.", new[] { "DateIn" });
                }
            }
        }
    }
}