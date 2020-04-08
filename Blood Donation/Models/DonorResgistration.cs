using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blood_Donation.Models
{
    public class DonorResgistration
    {
        [Key]
        public int donorID { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public BloodGroup Blood { get; set; }
        public string Address { get; set; }
        public Hospital HospitalName { get; set; }
    }
}