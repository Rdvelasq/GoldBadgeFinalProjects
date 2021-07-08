using Claim_POCO;
using Claim_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_UI
{
    public class ProgramUI
    {
        private ClaimRepo _claimRepo = new ClaimRepo();
        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("1) See All Claims\n" +
                                  "2) Take Care of Next Claim\n" +
                                  "3) Enter a New Claim\n" +
                                  "4) Exit\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
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
        public void SeeAllClaims()
        {

        }
        public void TakeCareOfNextClaim()
        {

        }
        public void EnterNewClaim()
        {

            int id = 1;
            ClaimType claimType = (ClaimType)TypeOfClaim();
            Console.WriteLine("Description of the claim?");
            string description = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Amount of the Claim?");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            DateTime dateOfAccident = GetDate("Accident");
            DateTime dateOfClaim = DateTime.Now;
            bool claimIsValid= ValidClaim(dateOfAccident, dateOfClaim);
            Claim claim = new Claim(id, claimType, description, amount, dateOfAccident, dateOfClaim, claimIsValid);
            _claimRepo.CreateClaim(claim);

        }

        public int TypeOfClaim()
        {
            bool keepGoing = true;
            int userTypeOfClaim;
            while (keepGoing)
            {
                Console.WriteLine("What type of claim was it?\n\n" +
                                "1) Car\n" +
                                "2) Home\n" +
                                "3) Theft\n");
                userTypeOfClaim = Convert.ToInt32(Console.ReadLine());
                if ((userTypeOfClaim == 1) || (userTypeOfClaim == 2) || (userTypeOfClaim == 3))
                {
                    keepGoing = false;
                    return userTypeOfClaim;
                }
                else
                {
                    Console.WriteLine("Not a Valid Input");
                }
            }
            return 0;

        }
        public DateTime GetDate(string typeOfDate)
        {
            Console.WriteLine($"Enter the month of the {typeOfDate}");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the day of the {typeOfDate}");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the year of the {typeOfDate}");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime = new DateTime(year, month, day);
            return dateTime;
        }
        public bool ValidClaim(DateTime dateOfAccident, DateTime dateOfClaim)
        {
            double numberOfDaysPasseed = (dateOfClaim - dateOfAccident).TotalDays;
            if(numberOfDaysPasseed <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
