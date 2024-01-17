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
<<<<<<< HEAD
        public int? PrescriptionId { get; set; }
        public int? AmtPaid { get; set; }
        public int? AmtPayable { get; set; }
=======
        public int PrescriptionId { get; set; }
        public int AmtPaid { get; set; }
        public int AmtPayable { get; set; }
>>>>>>> 5eb0dad489109e8062baaa3f6fb89913533d6b0d
    }
}
