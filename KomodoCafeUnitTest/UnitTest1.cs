using MenuItem_POCO;
using MenuItem_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KomodoCafeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private MenuItemRepo _menuItemRepo = new MenuItemRepo();
        
        [TestMethod]
        public void DeleteMeaItem_NotNull_ReturnTrue()
        { 
            //Arrange - create variables we need to test
            _menuItemRepo.CreateMealItem(1, "Big Mac", "Mouthwatering perfection", null, 4.50m);
            int mealNumberUserDelete = 1;

            //Act - use the method and variables 
            bool result = _menuItemRepo.DeleteMealItem(mealNumberUserDelete);

            //Assert - check it worked
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void DeleteMealItem_Null_ReturnFalse()
        {
            //Arrange
            _menuItemRepo.CreateMealItem(1, "Big Mac", "Mouthwatering perfection", null, 4.50m);
            int mealNumberUserDelete = 3;

            //Act
            bool result = _menuItemRepo.DeleteMealItem(mealNumberUserDelete);

            //Assert

            Assert.IsFalse(result);

        }
        [TestMethod]
        public void GetMealItemByNumber_FoundMealItem_ReturnMealItem()
        {
            //Arrgange 
            _menuItemRepo.CreateMealItem(1, "Big Mac", "Mouthwatering perfection", null, 4.50m);
            int mealNumberID = 1;

            //Act
            MealItem mealItem = _menuItemRepo.GetMealItemByNumber(mealNumberID);

            //Assert

            Assert.IsNotNull(mealItem);
        }

        [TestMethod]
        public void GetMealItemByNumber_DidNotFindMealItem_ReturnNull()
        {
            //Arrgange 
            _menuItemRepo.CreateMealItem(1, "Big Mac", "Mouthwatering perfection", null, 4.50m);
            int mealNumberID = 5;

            //Act
            MealItem mealItem = _menuItemRepo.GetMealItemByNumber(mealNumberID);

            //Assert

            Assert.IsNull(mealItem);

        }
    }
}
