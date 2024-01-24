using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Medicine : BaseDomainModel
    {
        [Required(ErrorMessage = "Please enter the medicine name")]
        [StringLength(100, MinimumLength = 3)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Enter NIL if nothing to write about")]
        [StringLength(100, MinimumLength = 3)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter the type of medicine")]
        [StringLength(100, MinimumLength = 3)]
        public string? Type { get; set; }

        [Required(ErrorMessage = "Please provide a valid medicine fee")]
        public double? MedicineFee { get; set; }

        [Required(ErrorMessage = "Please provide a valid manufactured time")]
        [DataType(DataType.Date)]
        public DateTime? ManufacturedDate { get; set; }

        [Required(ErrorMessage = "Please provide a valid expiry time")]
        [DataType(DataType.Date)]
        public DateTime? ExpiryDate { get; set; }
    }
}
