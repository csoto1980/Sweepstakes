using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class UserInterface //The functionality to assign a Contestant object a first name, last name, email address, and registration number
    {
        
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        
        }
        public static void ContestantRegistration()
        {
            string firstName = GetUserInputFor("Enter your first name:");
            string lastName = GetUserInputFor("Enter your last name:");
            string emailAddress = GetUserInputFor("Enter your email addres:");
            int registrationNumber = 
        }
        public static void DisplayContestantInfor()
        {

        }
    }
}
