using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HolidayTrip.Models
{
    public class Trip : IValidatableObject
    {
        public Guid TripId { get; set; }

        [Display(Name = "Start date")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime EndDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Destination { get; set; }


        [MaxLength(256)]
        public string Comments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndDate <= StartDate)
            {
                yield return
                    new ValidationResult(errorMessage: "EndDate must be greater than StartDate",
                        memberNames: new[] {"EndDate"});
            }
        }
    }

}