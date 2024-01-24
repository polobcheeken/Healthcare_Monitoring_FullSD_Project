using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Hospital : BaseDomainModel
    {
        [Required(ErrorMessage = "Please provide a proper hospital name")]
        [StringLength(100, MinimumLength = 3)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please provide a proper address for the hospital")]
        [StringLength(100, MinimumLength = 3)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Enter NIL if nothing to write about")]
        [StringLength(100, MinimumLength = 3)]
        public string? Description { get; set; }

        [Required]
        [RegularExpression(@"\b(?:Singapore|SINGAPORE)\s\d{6}\b", ErrorMessage = "Please enter 'Singapore' followed by 6 numericals after a spacing")]
        public string? PostalCode { get; set; }
    }
}
