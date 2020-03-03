using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    //*******USe Stack Data Structure as an underlying structure**************
    //Inherit ISweepstakesManager and implement the methods from the ISweepstakesManager interface using Stack and Queue methods.
    {
        // Member Variables
        private Stack<Sweepstakes> stack;

        //Constructor


        //Member Methods

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes()
        {
            return;
        }
    }
}
