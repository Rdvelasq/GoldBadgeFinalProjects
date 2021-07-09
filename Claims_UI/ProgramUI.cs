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
        int id = 1;
        public void Run()
        {
            //SeedData();
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
            Console.Clear();
            Queue<Claim> claims = _claimRepo.ReadClaims();
            foreach(var claim in claims)
            {
                printClaimInfo(claim);
            
            }
        }
        public void TakeCareOfNextClaim()
        {
            Console.Clear();
            Claim claim = _claimRepo.PeekClaim();
            printClaimInfo(claim);
            Console.WriteLine("Do you want to process Claim? Y | N");
            string processClaim = Console.ReadLine().ToLower();
            if(processClaim == "y")
            {
                _claimRepo.DeleteClaim();
            }
            Console.Clear();

        }
        public void EnterNewClaim()
        {
            Console.Clear();
            ClaimType claimType = (ClaimType)TypeOfClaim();
            Console.Clear();
            Console.WriteLine("Description of the claim?");
            string description = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Amount of the Claim?");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            DateTime dateOfAccident = GetDate("Accident");
            DateTime dateOfClaim = DateTime.Now;
            //bool claimIsValid= ValidClaim(dateOfAccident, dateOfClaim);
            Claim claim = new Claim(id, claimType, description, amount, dateOfAccident, dateOfClaim);
            _claimRepo.CreateClaim(claim);
            id++;
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
            Console.WriteLine("\n");
            Console.WriteLine($"Enter the day of the {typeOfDate}");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine($"Enter the year of the {typeOfDate}");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime = new DateTime(year, month, day);
            Console.Clear();
            return dateTime;       
        }
        /*public bool ValidClaim(DateTime dateOfAccident, DateTime dateOfClaim)
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
        */

        public void printClaimInfo(Claim claim)
        {
            Console.WriteLine($"Claim ID: {claim.ID}\n" +
                                  $"Type of Claim: {claim.ClaimType}\n" +
                                  $"Description: {claim.Description}\n" +
                                  $"Amount: {claim.Amount}\n" +
                                  $"Date Of Accident: {claim.DateOfIncident}\n" +
                                  $"Date of Claim: {claim.DateOfClaim}\n" +
                                  $"Is valid: {claim.IsValid}\n");
        }

        /*public void SeedData()
        {
            DateTime dateTime1 = new DateTime(2021, 06, 21);
            DateTime dateTime2 = new DateTime(2021, 07, 01);
            DateTime dateTime3 = new DateTime(2021, 05, 01);

            ClaimType one = (ClaimType)1;
            ClaimType two = (ClaimType)2;
            ClaimType three = (ClaimType)3;



            Claim claim = new Claim(1, one, "Auto Accident", 500.00m, dateTime1, DateTime.Now, true);
            Claim claim1 = new Claim(2, two, "House Caught On Fire", 1000.99m, dateTime2, DateTime.Now, true);
            Claim claim2 = new Claim(3, three, "Stolen Bike", 20m, dateTime3, DateTime.Now, false);

        }
        */
    }
}
