using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_UI
{
    public class ProgramUI
    {
        public void run()
        {
            Menu();
        }
        public void Menu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("1) See All Claims\n"+
                                  "2) Take Care of Next Claim\n"+
                                  "3) Enter a New Claim\n"+
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
            int typeOfClaim = TypeOfClaim();
            
            
        }

        public int TypeOfClaim()
        {
            bool keepGoing = true;
            int userTypeOfClaim;
            while (keepGoing)
            {
                Console.WriteLine("What type of claim was it>?\n\n" +
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
    }
}
