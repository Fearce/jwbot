using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWBot
{
    class Cycle
    {

        public void Start()
        {
            Form1.LogMessage = "Starting";
            DailyRewards.DailyRewardsCheck();
            DailyRewards.RewardsReceived();
        }



       



    }
}
