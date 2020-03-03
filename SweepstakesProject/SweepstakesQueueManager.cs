using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    //*******USe Queue Data Structure as an underlying structure**************
    //Inherit ISweepstakesManager and implement the methods from the ISweepstakesManager interface using Stack and Queue methods.
    {
        // Member Variables
        private readonly Queue<Sweepstakes> queue;

        // Constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }
        // Member Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = queue.Dequeue();
            return sweepstakes;
        }
    }
}
