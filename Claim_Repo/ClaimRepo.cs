﻿using Claim_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim_Repo
{
    public class ClaimRepo
    {
        private Queue<Claim> _claims = new Queue<Claim>();

        //Create
        public void CreateClaim(int id, ClaimType claimType, string description, decimal amount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            Claim claim = new Claim(id, claimType, description, amount, dateOfIncident, dateOfClaim, isValid);
            _claims.Enqueue(claim);
        }
        //Read
        public Queue<Claim> ReadClaims()
        {
            return _claims;
        }

        //Delete
        public void DeleteClaim()
        {
            _claims.Dequeue();
        }

        //Helper
        public Claim GetClaimByID(int id)
        {
            foreach(Claim claim in _claims)
            {
                if (claim.ID == id)
                {
                    return claim;
                }
            }
            return null;
        }
    }
}