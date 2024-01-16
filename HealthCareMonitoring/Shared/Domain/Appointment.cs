using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Appointment : BaseDomainModel
    {
        public virtual Staff? Staff { get; set; }
        public int? StaffId { get; set; }
        public virtual Patient? Patient { get; set; }
        public int? PatientId { get; set; }
        public virtual Hospital? Hospital { get; set; }
        public int? HospitalId { get; set; }
        public DateTime PlannedDateTime { get; set; }
    }
}
