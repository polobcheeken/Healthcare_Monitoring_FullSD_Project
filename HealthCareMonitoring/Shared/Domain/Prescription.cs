using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Prescription : BaseDomainModel 
    {
        public int? ConsultationId { get; set; }
        public virtual Consultation? Consultation { get; set; }
        public string? Description { get; set; }
<<<<<<< HEAD
        public virtual List<PrescriptionItem> PrescriptionItems { get; set; }
=======
        public virtual List<PrescriptionItem>? PrescriptionItems { get; set; }
>>>>>>> 5eb0dad489109e8062baaa3f6fb89913533d6b0d

    }
}
