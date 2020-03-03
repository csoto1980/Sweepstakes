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
        public int RegistrationNumber;
        

        // Constructor
        public Contestant(string FirstName, string LastName, string EmailAddress, int RegistrationNumber)
        {
            FirstName = UserInterface.GetUserInputFor("firstName");
            LastName = UserInterface.GetUserInputFor("lastName");
            EmailAddress = UserInterface.GetUserInputFor("emailAddress");
            this.RegistrationNumber = RegistrationNumber;
        }
        // Member Methods

    }
}
