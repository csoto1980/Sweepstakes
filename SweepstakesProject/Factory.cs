using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Factory //want to build my manager | managers need to be instan | user needs to pick/choose which manager | goal is to build a factory | than the factory...
    {
        // Member Variables
        public SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
        public SweepstakesStackManager SweepstakesStackManager = new SweepstakesStackManager();
        // Constructor
        public Factory()
        {

        }

        // Member Methods
        public void ChooseManager()
        {

        }

    }
}
