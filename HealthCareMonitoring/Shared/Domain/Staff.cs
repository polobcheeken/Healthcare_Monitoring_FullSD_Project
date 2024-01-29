﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareMonitoring.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
      
        public virtual Hospital? Hospital { get; set; }
        [Required]
        public int? HospitalId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "First Name does not meet length requirements")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Last Name does not meet length requirements")]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")] /* start with 6,8,9*/
        public int? ContactNo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Please enter - Male OR Female")]
        public string? Gender { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email")]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Username  does not meet length requirements")]
        public string? Username { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[!@#$%^&*()_+{}|:;<>,.?/~`[\]\\';=""+-])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must contain AT LEAST one special symbol, one uppercase alphabet, and one number")]
        public string? Password { get; set; }

        [Required]
        public double? Salary { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateYearJoined { get; set; }
    }
}
