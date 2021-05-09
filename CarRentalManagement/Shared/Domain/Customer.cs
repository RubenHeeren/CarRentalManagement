using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    /// <summary>
    /// Easiest way to do validation is with ASP.NET data annotations. See this class for an example.
    /// .NET reads out the annotations and performs its own validation rules on the field below it.
    /// </summary>
    public class Customer : BaseDomainModel
    {
        [Required(ErrorMessage = "Enter a first name.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 100 characters.")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Enter a last name.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 100 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter a tax id.")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Tax id must be between 8 and 15 characters.")]
        public string TaxId { get; set; }
        
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter a phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Enter an email address.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public virtual List<Booking> Bookings { get; set; }
    }
}