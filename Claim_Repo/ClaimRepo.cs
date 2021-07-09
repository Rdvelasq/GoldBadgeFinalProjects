using Claim_POCO;
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
        public void CreateClaim(Claim claim)
        {
            _claims.Enqueue(claim);
        }
        //Read
        public Queue<Claim> ReadClaims() => _claims;
       

        //Peek
        public Claim PeekClaim() => _claims.Peek();


        //Delete
        public void DeleteClaim()
        {
            _claims.Dequeue(); ;
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
