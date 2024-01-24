using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Prescription : BaseDomainModel
    {
        
        public virtual Consultation? Consultation { get; set; }
        public int? ConsultationId { get; set; }

        [Required(ErrorMessage = "Enter NIL if nothing to write about")]
        [StringLength(100, MinimumLength = 3)]
        public string? Description { get; set; }


        public virtual List<PrescriptionItem>? PrescriptionItems { get; set; }

    }
}
