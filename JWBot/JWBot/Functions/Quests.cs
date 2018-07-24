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
                        Form1.LogMessage = "On quest screen, checking quests";
                        QuestReward();
                        HelperFunctions.LeftMouseClick(location.X+100, location.Y+50);
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500); 
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(500);
                        SendKeys.SendWait("s");
                        Thread.Sleep(1000);
                        TogetherToVictory();

                    }
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
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\questsFoodComplete.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Quest complete, escaping";
                        HelperFunctions.LeftMouseClick(1750, 930);

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

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Clan mission found, going to complete";
                        HelperFunctions.LeftMouseClick(location.X+1020, location.Y+100);
                        Thread.Sleep(1000);
                        Clan.BattleCaveEnter();

                    }
                });
        }

        //questsNoFood

    }
}
