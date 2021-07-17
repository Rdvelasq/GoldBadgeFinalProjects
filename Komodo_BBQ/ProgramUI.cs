using BBQ_Repo;
using Burger_Booth_POCO;
using Burger_Booth_Repo;
using Employee_POCO;
using Employee_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treat_Booth_POCO;
using Treat_Booth_Repo;

namespace Komodo_BBQ
{
    public class ProgramUI
    {
        int id = 1;
        private BurgerBoothRepo _burgerBoothRepo = new BurgerBoothRepo();
        private TreatBoothRepo _treatBoothRepo = new TreatBoothRepo();
        private BBQRepo _bbqRepo = new BBQRepo();
        private EmployeeRepo _employeeRepo = new EmployeeRepo();

        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            BurgerBooth burgerBooth = _burgerBoothRepo.MakeBurgerBoothMenu();
            TreatBooth treatBooth = _treatBoothRepo.CreateTreatBoothMenu();
            _bbqRepo.MakeBBQ(burgerBooth, treatBooth);
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Welcome to Komodo BBQ\n\n" +
                                  "Where would you like to eat at?\n" +
                                  "1) Burger Booth\n" +
                                  "2) Treat Booth\n" +
                                  "3) View BBQ Stats\n" +
                                  "4) Create Employee\n"+
                                  "5) Exit\n") ;
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        BurgerBoothMenu(burgerBooth);
                        break;
                    case "2":
                        Console.Clear();
                        TreatBoothMenu(treatBooth);
                        break;
                    case "3":
                        Console.Clear();
                        ViewBBQStats();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        CreateEmployee();
                        Console.Clear();
                        break;
                    case "5":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
        public void CreateEmployee()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Employee employee = new Employee(id, name, 1, 1);
            _employeeRepo.Create(employee);
            id++;
        }
        public void BurgerBoothMenu(BurgerBooth burgerBooth)
        {
            Console.WriteLine("Select the ID that matches your name!");
            Employee employee = ViewEmployees();
            if (employee.BurgerBoothTicket != 0)
            {
                bool keepGoing = true;
                while (keepGoing)
                {

                    Console.WriteLine("What Would you like to buy\n\n" +
                                      $"1) Veggie Burger ${burgerBooth.VeggieBurger}\n" +
                                      $"2) Hamburger ${burgerBooth.Hamburger}\n" +
                                      $"3) Hotdog ${burgerBooth.HotDog}\n" +
                                      "4) Go Back");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            _burgerBoothRepo.AddToTotalCost(burgerBooth.VeggieBurger);
                            _burgerBoothRepo.AddToTotalTicket();
                            employee.BurgerBoothTicket = 0;
                            keepGoing = false;
                            break;
                        case "2":
                            _burgerBoothRepo.AddToTotalCost(burgerBooth.Hamburger);
                            _burgerBoothRepo.AddToTotalTicket();
                            employee.BurgerBoothTicket = 0;
                            keepGoing = false;
                            break;
                        case "3":
                            _burgerBoothRepo.AddToTotalCost(burgerBooth.HotDog);
                            _burgerBoothRepo.AddToTotalTicket();
                            employee.BurgerBoothTicket = 0;
                            keepGoing = false;
                            break;
                        case "4":
                            keepGoing = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
            }

            else
            {
                Console.WriteLine("This Employee Does Not have Enough Tickets To Enter The Burger Boothh!\nPress Any Key To Go Back");
                Console.ReadKey();
                Console.Clear();

            }
            
        }
        public void TreatBoothMenu(TreatBooth treatBooth)
        {
            Console.WriteLine("Select the ID that matches your name!");
            Employee employee = ViewEmployees();
            bool keepGoing = true;
            if (employee.TreatBoothTicket != 0)
            {
                while (keepGoing)
                {
                    Console.WriteLine("What Would you like to buy\n\n" +
                                      $"1) Popcorn ${treatBooth.Popcorn}\n" +
                                      $"2) Ice Cream ${treatBooth.IceCream}\n" +
                                      "3) Go Back");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            _treatBoothRepo.AddToTotalCost(treatBooth.Popcorn);
                            _treatBoothRepo.AddToTotalTickets();
                            employee.TreatBoothTicket = 0;
                            keepGoing = false;
                            break;
                        case "2":
                            _treatBoothRepo.AddToTotalCost(treatBooth.IceCream);
                            _treatBoothRepo.AddToTotalTickets();
                            employee.TreatBoothTicket = 0;
                            keepGoing = false;
                            break;
                        case "3":
                            keepGoing = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("This Employee Does Not have Enough Tickets To Enter The Treat Booth\nPress any key to go back");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void ViewBBQStats()
        {
            Console.WriteLine("----------------Burger Booth---------------------");

            Console.WriteLine($"Total Tickets : {_burgerBoothRepo.GetTickets()}");
            Console.WriteLine($"Total Cost: ${_burgerBoothRepo.GetTotalCost()}\n");
            Console.WriteLine("----------------Treat Booth----------------------");

            Console.WriteLine($"Total Tickets: {_treatBoothRepo.GetTickets()}");
            Console.WriteLine($"Total Cost: ${_treatBoothRepo.GetTotalCost()}\n");

            Console.WriteLine("----------------------BBQ-----------------------");
            Console.WriteLine($"Total Tickets {_bbqRepo.GetTotalTickets()}");
            Console.WriteLine($"Total Cost: ${_bbqRepo.GetTotalCost()}\n");
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
        public Employee ViewEmployees()
        {
            List<Employee> _listOfEmployees = _employeeRepo.GetEmployees();
            foreach (var employee in _listOfEmployees)
            {
                Console.WriteLine($"ID: {employee.ID}\n"+
                                  $"Name: {employee.Name}\n" +
                                  $"Burger Booth Ticket: {employee.BurgerBoothTicket}\n"+
                                  $"Treat Booth Ticket: {employee.TreatBoothTicket}\n \n");
            }
            int userID = Convert.ToInt32(Console.ReadLine());
            return _employeeRepo.GetEmployee(userID);

        }
    }
    
}
