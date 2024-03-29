﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        
        public virtual Prescription? Prescription { get; set; }
        [Required]
        public int? PrescriptionId { get; set; }

        [Required(ErrorMessage = "Enter NIL if you pay at stated hospital")]
        [StringLength(100, MinimumLength = 3)]
        public string? CardType { get; set; }
        public double? AmtPayable { get; set; }
    }
}
