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
        //public string Name; // Property .Name

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        //Member Methods
        public void RegisterContestant(Contestant contestant) //Method for registering each contestant to the sweepstakes //adding contestants to the dictionary & giving a registration number
        {
            //add contestant to dictionary of contestants 
            dictionaryNumber++;
            contestants.Add(dictionaryNumber, contestant);
        }
        public void PrintContestantInfo(Contestant contestant) //pass in contestant infor via .notation
        {
            Console.WriteLine("First Name: " + contestant.FirstName + " Last Name: " + contestant.LastName);
            Console.WriteLine("Email Address: " + contestant.EmailAddress);
            Console.WriteLine("Registration #: " + contestant.RegistrationNumber);
        }
        public Contestant PickWinner() //Method to pick a random contestant from dictionary//
        {
            int randomNumber = new Random().Next(1, dictionaryNumber);
            Contestant contestantWinner = contestants[randomNumber];//new Contestant(); | could use dictionary or reg# |
            return contestantWinner;
        }
        public void NotifyAllContestants()
        {
            Contestant contestantWinner = PickWinner();
            //contestants[]
        }
    }
}
