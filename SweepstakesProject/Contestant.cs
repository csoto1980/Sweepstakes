using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant
    {
        // Member Variables
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber = 0;
        

        // Constructor
        public Contestant()
        {
            FirstName = UserInterface.GetFirstName();
            LastName = UserInterface.GetLastName();
            EmailAddress = UserInterface.GetEmailAddress();
            RegistrationNumber = GenerateRegNumber();
        }
        // Member Methods
        public int GenerateRegNumber()
        {
            RegistrationNumber++;
            return RegistrationNumber;
        }


    }
}
