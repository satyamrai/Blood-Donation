using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blood_Donation.Models
{
    public class DonorRegistrationContext : DbContext
    {
        public DonorRegistrationContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Blood_Donation.Models.DonorResgistration> DonorResgistrations { get; set; }
    }
}