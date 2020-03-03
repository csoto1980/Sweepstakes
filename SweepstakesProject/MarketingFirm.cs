using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm // Is like the Game Class
                        // Functionality to create a sweepstakes. 
                        // Implement dependency injection in my MarketingFirm class so that I can utilize a sweepstakes manager.
    {
        //Member Variables
        public ISweepstakesManager manager; //ISweepstakesManager is like a string or int

        //Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            //injection video
        }

        //Member Methods
        public void CreateSweepstake()
        {
            Sweepstakes sweepstake = new Sweepstakes();//what to pass through to create name
        }
    }
}
