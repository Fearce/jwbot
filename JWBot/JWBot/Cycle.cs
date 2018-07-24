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
        public static Point EscapeCoords { get; set; }
        public void Start()
        {
            EscapeCoords = new Point(1795,906);
            BOTSTATUS = "REWARDS";
            WorkCycle();
        }

        public static string BOTSTATUS { get; set; }   

        public static async Task WorkCycle()
        {
            await Task.Run(
                () =>
                {
                    Form1.LogMessage = "Starting";
                    Form1.LogMessage = "Daily Rewards check";
                    DailyRewards.CheckDailyRewards();
                    Form1.LogMessage = "Quests check";
                    Quests.CheckQuests();
                    Form1.LogMessage = "Clan check";
                    Clan.CheckClan();
                    //Form1.LogMessage = "Battle check";
                    //Battle.CheckBattle();


                    //Form1.LogMessage = "Starting";
                    //if (BOTSTATUS == "REWARDS")
                    //{
                    //    Form1.LogMessage = "Daily Rewards check";
                    //    DailyRewards.CheckDailyRewards();
                    //    BOTSTATUS = "QUESTS";
                    //    WorkCycle();
                    //}
                    //else if (BOTSTATUS == "QUESTS")
                    //{
                    //    Form1.LogMessage = "Quests check";
                    //    Quests.CheckQuests();
                    //    BOTSTATUS = "CLAN";
                    //    WorkCycle();
                    //}

                    //else if (BOTSTATUS == "CLAN")
                    //{
                    //    Form1.LogMessage = "Clan check";
                    //    Clan.CheckClan();
                    //    BOTSTATUS = "REWARDS";
                    //    WorkCycle();
                    //}
                });
        }



       



    }
}
