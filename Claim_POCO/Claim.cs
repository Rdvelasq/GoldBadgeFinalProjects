using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim_POCO
{
    public class Claim
    {
        public int ID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid 
        {
            get 
            {
                double numberOfDaysPasseed = (DateOfClaim - DateOfIncident).TotalDays;
                return (numberOfDaysPasseed <= 30);
                
            } 
        }
        public Claim()
        {

        }
        public Claim(int id, ClaimType claimType, string description, decimal amount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ID = id;
            ClaimType = claimType;
            Description = description;
            Amount = amount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;

        }
    }

   
}
