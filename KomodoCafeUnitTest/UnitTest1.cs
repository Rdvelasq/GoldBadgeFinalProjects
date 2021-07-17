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
            MealItem mealItem = new MealItem(1, "Big Mac", "Mouthwatering perfection", null, 4.50m);
            _menuItemRepo.CreateMealItem(mealItem);
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
            MealItem mealItem = new MealItem(1, "Big Mac", "Mouthwatering perfection", null, 4.50m);
            _menuItemRepo.CreateMealItem(mealItem);
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
            MealItem mealItem = new MealItem(1, "Big Mac", "Mouthwatering perfection", null, 4.50m);
            _menuItemRepo.CreateMealItem(mealItem);
            int mealNumberID = 1;

            //Act
            MealItem foundMealItem = _menuItemRepo.GetMealItemByNumber(mealNumberID);

            //Assert

            Assert.IsNotNull(foundMealItem);
        }

        [TestMethod]
        public void GetMealItemByNumber_DidNotFindMealItem_ReturnNull()
        {
            //Arrgange 
            MealItem mealItem = new MealItem(1, "Big Mac", "Mouthwatering perfection", null, 4.50m);
            _menuItemRepo.CreateMealItem(mealItem);
            int mealNumberID = 5;

            //Act
            MealItem notFoundMealItem = _menuItemRepo.GetMealItemByNumber(mealNumberID);

            //Assert

            Assert.IsNull(notFoundMealItem);

        }
    }
}
