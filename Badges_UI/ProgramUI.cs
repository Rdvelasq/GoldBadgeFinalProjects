using Badge_POCO;
using Badge_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges_UI
{
    public class ProgramUI
    {
        int id = 1;
        private BadgeRepo _badgeRepo = new BadgeRepo();
        public void Run()
        {
            SeedData();
            Menu();
        }

        public void Menu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Menu\n\n"+
                                  "1) Add a Badge\n"+
                                  "2) Edit a Badge\n" +
                                  "3) List all Badges\n" +
                                  "4) Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        Console.Clear();
                        ListAllBadges();
                        break;
                     default:
                        Console.WriteLine("Invalid Input");
                        keepGoing = false;
                        break;
                }
            }
            
        }
        public  void AddBadge()
        {
            List<string> doorNumbers = new List<string>();
            Console.WriteLine("What is the badge number:");
            int badgeNumber = Convert.ToInt32(Console.ReadLine());
            doorNumbers.Add(GetDoor());
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("\nAny other doors(y/n)?");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    doorNumbers.Add(GetDoor());

                }
                else if (userInput == "n")
                {
                    keepGoing = false;
                }
            }
            Badge badge = new Badge(id, badgeNumber, doorNumbers);
            _badgeRepo.Create(badge);
            id++;

        }
        public void EditBadge()
        {
            
        }
        public  void ListAllBadges()
        {
            
            List<Badge> listOfBadges = _badgeRepo.GetListOfBadges();
            foreach (var badge in listOfBadges)
            {
                Console.WriteLine($"Badge Number:\n{badge.Name}\n");
                Console.WriteLine("Door Number:");
                foreach(var door in badge.DoorNames)
                {
                    Console.Write($"{door} ");
                }
                Console.WriteLine("\n");
            }
        }
        public string GetDoor() {
            Console.WriteLine("\nList a door that it needs access to:");
            string doorNumber = Console.ReadLine();
            return doorNumber;
        }

        public void SeedData()
        {
            List<string> doorNames = new List<string>() { "A1", "A2", "A3" };
            Badge badge = new Badge(1, 12345, doorNames);
            _badgeRepo.Create(badge);

            List<string> doorNames2 = new List<string>() { "B2", "A2", "C4" };
            Badge badge2 = new Badge(2, 7890, doorNames2);
            _badgeRepo.Create(badge2);
        }

    }
}
