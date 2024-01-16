using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public virtual Hospital? Hospital { get; set; }
        public int HospitalID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public int ContactNo { get; set; }
        public string? Gender { get; set;}
        public string? EmailAddress { get; set; }
        public string? Username { get; set;}
        public string? Password { get; set; }
        public float Salary { get; set; }
        public DateTime DateTimeJoined { get; set; }
    }
}
