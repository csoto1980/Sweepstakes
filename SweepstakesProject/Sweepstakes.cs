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
        public string Name;


        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        //Member Methods
        public void RegisterContestant(Contestant contestant)
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
        //public Contestant PickWinner()
        //{
        //    //create a random draw from Contestants
        //}


    }
}
