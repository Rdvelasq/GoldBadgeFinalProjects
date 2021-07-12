using Claim_POCO;
using Claim_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClaimsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private ClaimRepo _claimRepo = new ClaimRepo();
        [TestMethod]
        public void GetClaimByID_ClaimIsFound_ReturnsClaim()
        {
            //Arrange 
            DateTime dateOfAccident = new DateTime(2021, 07, 01);
            Claim claim = new Claim(1, ClaimType.Car, "Car Crash", 1000.00m, dateOfAccident, DateTime.Now);
            _claimRepo.CreateClaim(claim);

            //Act
            int claimID = 1;
            Claim result = _claimRepo.GetClaimByID(claimID);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ID, claimID);
        }

        [TestMethod]
        public void GetClaimByID_ClaimIsNotFound_ReturnsNull()
        {
            //Arrange 
            DateTime dateOfAccident = new DateTime(2021, 07, 01);
            Claim claim = new Claim(1, ClaimType.Car, "Car Crash", 1000.00m, dateOfAccident, DateTime.Now);
            _claimRepo.CreateClaim(claim);

            //Act
            int claimID = 3;
            Claim result = _claimRepo.GetClaimByID(claimID);

            //Assert
            Assert.IsNull(result);
        }
    }
}
