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
        private readonly Stack<Sweepstakes> stack;

        //Constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        //Member Methods

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = stack.Pop();
            return sweepstakes;
        }
    }
}
