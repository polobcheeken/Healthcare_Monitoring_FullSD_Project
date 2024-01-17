using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Consultation : BaseDomainModel
    {
        public virtual Appointment? Appointment { get; set; }
        public int? AppointmentId { get; set; }
        public virtual Staff? Staff { get; set; }
        public int? StaffId { get; set; }
        public virtual Hospital? Hospital { get; set; }
        public int? HospitalId { get; set; }
        public string? Description { get; set; }
<<<<<<< HEAD
        public float ConsultationFee{ get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
=======
        public float? ConsultationFee{ get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
>>>>>>> 5eb0dad489109e8062baaa3f6fb89913533d6b0d
    }
}
