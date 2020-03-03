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
        public static string GetFirstName()
        {
            Console.WriteLine("Please enter your First Name:");
            return Console.ReadLine();
        }
        public static string GetLastName()
        {
            Console.WriteLine("Please enter your Last Name:");
            return Console.ReadLine();
        }
        public static string GetEmailAddress()
        {
            Console.WriteLine("Please enter your E-mail Address:");
            return Console.ReadLine();
        }
        public static void DisplayContestantInfor()
        {
            Console.WriteLine();
        }

    }
}
