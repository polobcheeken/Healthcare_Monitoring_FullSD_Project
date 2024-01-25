using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Consultation : BaseDomainModel
    {
        
        public virtual Appointment? Appointment { get; set; }
        [Required]
        public int? AppointmentId { get; set; }

        public virtual Staff? Staff { get; set; }
        [Required]
        public int? StaffId { get; set; }

        [Required(ErrorMessage = "Enter NIL if nothing to write about")]
        [StringLength(100, MinimumLength = 3)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please input the consultation length")]
        public int? ConsultationLength { get; set; }

        [Required(ErrorMessage = "Please enter the consultation fee")]
        public double? ConsultationFee { get; set; }

        [Required(ErrorMessage = "Please provide a valid start time for the consultation")]
        public DateTime StartDateTime { get; set; }
    }
}
