using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Appointment : BaseDomainModel
    {

        public virtual Staff? Staff { get; set; }
        [Required]
        public int? StaffId { get; set; }
        
        public virtual Patient? Patient { get; set; }
        [Required]
        public int? PatientId { get; set; }
        
        public virtual Hospital? Hospital { get; set; }
        [Required]
        public int? HospitalId { get; set; }

        [Required(ErrorMessage = "Please provide a valid date for the appointment")]
        [DataType(DataType.Date)]
        public DateTime PlannedDateTime { get; set; }
    }
}
