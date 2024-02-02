using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class PrescriptionItem : BaseDomainModel
    {
        public virtual Prescription? Prescription { get; set; }
        public int? PrescriptionId { get; set; }

        public virtual Medicine? Medicine { get; set; }
        [Required]
        public int? MedicineId { get; set; }

        [Required(ErrorMessage = "Please enter quantity for the specified medicine")]
        public int? MedicineQty { get; set; }
    }
}
