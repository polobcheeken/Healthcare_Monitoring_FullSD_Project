using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public virtual Prescription? Prescription { get; set; }
        public int PrescriptionId { get; set; }
        public int AmtPaid { get; set; }
        public int AmtPayable { get; set; }
    }
}
