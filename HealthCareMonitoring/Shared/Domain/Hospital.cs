using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Hospital : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
    }
}
