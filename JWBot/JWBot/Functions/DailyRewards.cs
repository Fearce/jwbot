using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JWBot
{
    static class DailyRewards
    {
        public static async Task CheckDailyRewards()
        {
            await Task.Run(
                () =>
                {
                    DailyRewardsCheck();
                    RewardsReceived();

                });
        }

        //TODO: Fix day 1, 2, 4, 5, 6, 7
        public static async Task RewardsReceived()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\dailyRewardRewardReceived.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Rewards received, escaping.";
                        HelperFunctions.LeftMouseClick(Cycle.EscapeCoords.X, Cycle.EscapeCoords.Y);

                    }


                }); 
        }

        public static async Task DailyRewardsCheck()
        {
            await Task.Run(
                () => {
                    //Check if Daily Reward screen is here
                    bool isScreenHere = false;
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\dailyRewardScreen.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        isScreenHere = true;
                        Form1.LogMessage = "Daily Reward Screen here, starting daycheck";
                    }

                    if (isScreenHere)
                    {
                        bool rewardFound = false;
                        //Check day 1
                        if (rewardFound == false)
                        {
                            Form1.LogMessage = "Checking day 1";
                            //DateTime dtNow1 = DateTime.Now;
                            //while (DateTime.Now.Second - dtNow1.Second < 2)
                            //{

                            //}
                        }

                        if (rewardFound == false)
                        {
                            Form1.LogMessage = "Checking day 2";
                            //DateTime dtNow2 = DateTime.Now;
                            //while (DateTime.Now.Second - dtNow2.Second < 2)
                            //{

                            //}
                        }

                        if (rewardFound == false)
                        {
                            Form1.LogMessage = "Checking day 3";
                            //DateTime dtNow3 = DateTime.Now;
                            //while (DateTime.Now.Second - dtNow3.Second < 2)
                            //{
                                var d3ss = HelperFunctions.CaptureScreen();
                                var d3location = HelperFunctions.searchBitmap(
                                    (Bitmap) Bitmap.FromFile(
                                        @"C:\Users\theke\Desktop\jwbot\resources\dailyRewardDay3.png"), d3ss, 0);

                                if (d3location.Width != 0 && d3location.X > 10 && d3location.Y > 10)
                                {
                                    Form1.LogMessage = "Day 3 rewards here, clicking";
                                    HelperFunctions.LeftMouseClick(d3location.X+50, d3location.Y-50); //+50 -50
                                    rewardFound = true;
                                }
                            //}
                        }

                        if (rewardFound == false)
                        {
                            Form1.LogMessage = "Checking day 4";
                            //DateTime dtNow4 = DateTime.Now;
                            //while (DateTime.Now.Second - dtNow4.Second < 2)
                            //{

                            //}
                        }

                        if (rewardFound == false)
                        {
                            Form1.LogMessage = "Checking day 5";
                            //DateTime dtNow5 = DateTime.Now;
                            //while (DateTime.Now.Second - dtNow5.Second < 2)
                            //{

                            //}
                        }

                        if (rewardFound == false)
                        {
                            Form1.LogMessage = "Checking day 6";
                            //DateTime dtNow6 = DateTime.Now;
                            //while (DateTime.Now.Second - dtNow6.Second < 2)
                            //{

                            //}
                        }

                        if (rewardFound == false)
                        {
                            Form1.LogMessage = "Checking day 7";
                            //DateTime dtNow7 = DateTime.Now;
                            //while (DateTime.Now.Second - dtNow7.Second < 2)
                            //{

                            //}
                        }

                        if (rewardFound == false)
                        {
                            Form1.LogMessage = "Seems like reward is already taken, escaping!";
                            HelperFunctions.LeftMouseClick(Cycle.EscapeCoords.X, Cycle.EscapeCoords.Y);
                            Thread.Sleep(1000);
                        }

                    }
                });
            


        }


    }
}
