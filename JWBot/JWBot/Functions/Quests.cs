using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JWBot.Functions;

namespace JWBot
{
    static class Quests 
    {

        public static async Task CheckQuests()
        {
            await Task.Run(
                () =>
                {
                    QuestComplete();
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\questsHeader.png"), ss, 0);
                            
                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        int sleepTimer = 1500;
                        Form1.LogMessage = "On quest screen, checking quests";
                        QuestReward();
                        HelperFunctions.LeftMouseClick(location.X+100, location.Y+50);
                        for (int i = 0; i < 10; i++)
                        {
                            TogetherToVictory();
                            Thread.Sleep(sleepTimer);
                            SendKeys.SendWait("s");
                        }
                    }

                    Form1.LogMessage = "No quests, escaping and checking battles";
                    HelperFunctions.LeftMouseClick(Cycle.EscapeCoords.X, Cycle.EscapeCoords.Y);
                    Thread.Sleep(1000);
                    Battle.CheckBattle();
                });
        }

        public static async Task QuestReward()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\questsReward.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Quest reward found, taking";
                        HelperFunctions.LeftMouseClick(location.X+10, location.Y+100);

                    }
                });
        }

        public static async Task QuestComplete()
        {
            await Task.Run(
                () =>
                {
                    EscapeClanMission();
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\questsFoodComplete.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Quest complete, escaping";
                        HelperFunctions.LeftMouseClick(Cycle.EscapeCoords.X, Cycle.EscapeCoords.Y);

                    }
                }); 
        }

        //Looking for clan quest
        public static async Task TogetherToVictory()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\questsClan.png"), ss, 0);
                    var location2 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\questClanComplete.png"), ss, 0);


                    if (location2.Width != 0 && location2.X > 10 && location2.Y > 10)
                    {
                        Clan.AttemptsRemaining = 0;
                        Form1.LogMessage = "Clan mission completed, taking reward";
                        HelperFunctions.LeftMouseClick(location2.X+750, location2.Y+20);
                        Thread.Sleep(1000);
                        EscapeClanMission();//clanMissionComplete
                    }
                    else if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Clan.AttemptsRemaining = 3;
                        Form1.LogMessage = "Clan mission found, going to complete";
                        HelperFunctions.LeftMouseClick(location.X + 1020, location.Y + 100);
                        Thread.Sleep(1000);
                        Clan.BattleCaveEnter();
                        Clan.CheckClan();
                    }
                });
        }

        public static async Task EscapeClanMission()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanMissionComplete.png"), ss, 0);


                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Clan.AttemptsRemaining = 0;
                        Form1.LogMessage = "Mission Completed, escaping";
                        HelperFunctions.LeftMouseClick(Cycle.EscapeCoords.X, Cycle.EscapeCoords.Y);
                    }
                });
        }

        //questsNoFood

    }
}
