using Badge_POCO;
using Badge_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BadgeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private BadgeRepo _badgeRepo = new BadgeRepo();
        [TestMethod]
        public void GetBadgeByNumber_BadgeWasFound_ReturnBadgeObject()
        {
            //Arrange
            List<string> doorNumbers = new List<string>() { "A1", "C3" };
            Badge badge = new Badge(1, 45678, doorNumbers);
            _badgeRepo.Create(badge);

            //Act
            int badgeNumber = 45678;
            Badge foundBadge = _badgeRepo.GetBadgeByNumber(badgeNumber);

            //Assert
            Assert.IsNotNull(foundBadge);
        }
        [TestMethod]
        public void GetBadgeByNumber_BadgeWasNotFound_ReturnNullt()
        {
            //Arrange
            List<string> doorNumbers = new List<string>() { "A1", "C3" };
            Badge badge = new Badge(1, 45678, doorNumbers);
            _badgeRepo.Create(badge);

            //Act
            int badgeNumber = 12345;
            Badge notFoundBadge = _badgeRepo.GetBadgeByNumber(badgeNumber);

            //Assert
            Assert.IsNull(notFoundBadge);
        }
    }
}
