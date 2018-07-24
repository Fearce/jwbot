using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JWBot.Functions;

namespace JWBot
{
    class Cycle
    {

        public void Start()
        {
            Form1.LogMessage = "Starting";
            //Daily rewards
            Form1.LogMessage = "Daily Rewards check";
            DailyRewards.CheckDailyRewards();
            //Quests
            Form1.LogMessage = "Quests check";
            Quests.CheckQuests();
            //Clan
            Form1.LogMessage = "Clan check";
            Clan.CheckClan();
        }



       



    }
}
