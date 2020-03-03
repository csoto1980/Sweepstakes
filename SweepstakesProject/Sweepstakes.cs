using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        // Member Variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        int dictionaryNumber = 0;
        Contestant contestantWinner;
        //public string Name; // Property .Name

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        //Member Methods
        public void RegisterContestant(Contestant contestant) 
        {
            dictionaryNumber++;
            contestants.Add(dictionaryNumber, contestant);
        }
        
        public Contestant PickWinner() 
        {
            int randomNumber = new Random().Next(1, dictionaryNumber);
            Contestant contestantWinner = contestants[randomNumber];
            return contestantWinner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("First Name: " + contestant.FirstName + " Last Name: " + contestant.LastName);
            Console.WriteLine("Email Address: " + contestant.EmailAddress);
            Console.WriteLine("Registration #: " + contestant.RegistrationNumber);
        }
        public void PrintContestantWinnerInfo(Contestant contestant)
        {
            Console.WriteLine("First Name: " + contestantWinner.FirstName + " Last Name: " + contestantWinner.LastName);
            Console.WriteLine("Email Address: " + contestantWinner.EmailAddress);
            Console.WriteLine("Registration #: " + contestantWinner.RegistrationNumber);
        }
        public void NotifyAllContestants()
        {
            Contestant contestantWinner = PickWinner();
            //contestants[]
        }
    }
}
