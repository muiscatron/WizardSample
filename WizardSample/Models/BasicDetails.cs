using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WizardSample.Models
{
    public class BasicDetails
    {
        [Required]
        public string CustomerID { get; set; }
        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }
    }
}