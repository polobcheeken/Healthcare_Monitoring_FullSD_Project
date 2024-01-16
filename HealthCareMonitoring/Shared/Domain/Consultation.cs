using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Consultation : BaseDomainModel
    {
        public int? AppointmentId { get; set; }
        public virtual Appointment? Appointment { get; set; }
        public int? StaffId { get; set; }
        public virtual Staff? Staff { get; set; }
        public int? HospitalId { get; set; }
        public virtual Hospital? Hospital { get; set; }
        public string? Description { get; set; }
        public float? ConsultationFee{ get; set; }
        public DateTime DateTime { get; set; }
    }
}
