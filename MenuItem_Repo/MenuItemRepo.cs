using MenuItem_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItem_Repo
{
    public class MenuItemRepo
    {
        private List<MealItem> _mealItems = new List<MealItem>();

        //Create
        public void CreateMealItem(MealItem mealItem)
        {
            _mealItems.Add(mealItem);
        }

        //Read
        public List<MealItem> ReadMealItem()
        {
            return _mealItems;
        }

        //Delete
        public bool DeleteMealItem(int mealNumberUserDelete)
        {
            MealItem deletedMealItem = GetMealItemByNumber(mealNumberUserDelete);
            if (deletedMealItem != null)
            {
                _mealItems.Remove(deletedMealItem);
                return true;
            }
            return false;
        }

        //Helper
        public MealItem GetMealItemByNumber(int mealNumber)
        {
            foreach (MealItem mealItem in _mealItems)
            {
                if (mealItem.Number == mealNumber)
                {
                    return mealItem;
                }
            }
            return null;
        }

    }
    
}
