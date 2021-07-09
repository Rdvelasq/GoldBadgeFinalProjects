using MenuItem_POCO;
using MenuItem_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe
{

    public class ProgramUI
    {
        private MenuItemRepo _menuItemRepo = new MenuItemRepo();
        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                
                Console.WriteLine("1) Create Menu Item \n" +
                                  "2) Delete Menu Item \n" +
                                  "3) View All Menu Items \n" +
                                  "4) Exit\n"
                                );
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateMenuItem();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        ViewMenuItem();
                        break;
                    case "4":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        public void CreateMenuItem()
        {
            Console.Clear();
            int number = 1;
            Console.WriteLine("What is the name of the Meal?");
            string name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("What is the description of the Meal?");
            string description = Console.ReadLine();
            List<string> ingredients = AddIngredients();
            Console.WriteLine("What is the price of the Meal?");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            MealItem menuItem = new MealItem(number, name, description, ingredients, price);
            _menuItemRepo.CreateMealItem(menuItem);
        }
        public List<string> AddIngredients()
        {
            List<string> ingredients = new List<string>();
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("1) Add Ingredient\n" +
                                  "2) Done Adding Ingredients\n");
                string userInput = Console.ReadLine();
                Console.Clear();
                if (userInput == "1")
                {
                    Console.WriteLine("Name of the Ingredient?");
                    string ingredient = Console.ReadLine();
                    ingredients.Add(ingredient);
                }

                else if (userInput == "2")
                {
                    keepGoing = false;
                }

                else
                {
                    Console.WriteLine("Invalid Input");
                }


            }
            return ingredients;
        }
        public void DeleteMenuItem()
        {
            Console.Clear();
            ViewMenuItem();
            Console.WriteLine("Select the Meal Number you want to Delete");
            int itemUserDelete = Convert.ToInt32(Console.ReadLine());
            bool deleted = _menuItemRepo.DeleteMealItem(itemUserDelete);
            if (deleted)
            {
                Console.WriteLine("Meal has been Deleted!\nPress any Key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Meal was not Deleted!\nPress any Key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void ViewMenuItem()
        {
            Console.Clear();
            List<MealItem> mealItems = _menuItemRepo.ReadMealItem();
            foreach (MealItem mealItem in mealItems)
            {
                Console.WriteLine($"Meal Number: {mealItem.Number}\nMeal Name: {mealItem.Name} \nPrice: ${mealItem.Price} \n \n");
            }

        }
    }
}