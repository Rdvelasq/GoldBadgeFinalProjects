using Badge_POCO;
using Badge_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BadgeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private BadgeRepo _badgeRepo = new BadgeRepo();
        [TestMethod]
        public void Create_BadgeWasCreated_ReturnTrue()
        {
            //Arrange
          //  Badge badge = new Badge(1, 45893);

            //Act
          //  bool result = _badgeRepo.Create(badge, "A3");

            //Assert
           // Assert.IsTrue(result);
        }
    }
}
