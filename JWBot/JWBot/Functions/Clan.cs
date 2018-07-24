using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWBot.Functions
{
    static class Clan
    {
        //clanQuestsCave
        public static async Task CheckClan()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanBelowBattleCave.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Entering Clan Cave.";
                        HelperFunctions.LeftMouseClick(location.X+20, location.Y-400);

                    }

                    ClanRaids();
                });
        }
        //clanCave3Attempts
        public static async Task BattleCaveEnter()  
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCaveEnter.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Entering Clan Cave.";
                        HelperFunctions.LeftMouseClick(location.X, location.Y);

                    }
                    else
                    {
                        CheckClan();
                    }
                });
        }

        public static int AttemptsRemaining { get; set; }
        public static int CaveToCheck { get; set; }

        public static async Task ClanRaids()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location0 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave0Attempts.png"), ss, 0);

                    var location3 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave3Attempts.png"), ss, 0);
                    var location2 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave2Attempts.png"), ss, 0);
                    var location1 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave1Attempts.png"), ss, 0);


                    if (location0.Width != 0 && location0.X > 10 && location0.Y > 10)
                    {
                        Form1.LogMessage = "0 attempts remaining, escaping";
                        HelperFunctions.LeftMouseClick(Cycle.EscapeCoords.X,Cycle.EscapeCoords.Y);
                        AttemptsRemaining = 0;

                    }
                    else if(location3.Width != 0 && location3.X > 10 && location3.Y > 10)
                    {
                        Form1.LogMessage = "3 attempts remaining, looking for GO button";
                        HelperFunctions.LeftMouseClick(location3.X, location3.Y);
                        ClanRaidFightGo();
                    }
                    else if (location2.Width != 0 && location2.X > 10 && location2.Y > 10)
                    {
                        Form1.LogMessage = "2 attempts remaining, looking for GO button";
                        HelperFunctions.LeftMouseClick(location2.X, location2.Y);
                        ClanRaidFightGo();
                    }
                    else if (location1.Width != 0 && location1.X > 10 && location1.Y > 10)
                    {
                        Form1.LogMessage = "1 attempt remaining, looking for GO button";
                        HelperFunctions.LeftMouseClick(location1.X, location1.Y);
                        ClanRaidFightGo();
                    }
                });
        }
        

        public static async Task CheckCaves()
        {
            await Task.Run(async () =>
                {
                    if (CaveToCheck == 1)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave1Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "First cave already completed";

                        }
                        CaveToCheck = 2;
                        await CheckCaves();
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 2)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave2Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Second cave already completed";
                        }
                        CaveToCheck = 3;
                        SendKeys.SendWait("s");
                        Thread.Sleep(2000);
                        await CheckCaves();
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 3)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave3Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Third cave already completed";

                        }
                        CaveToCheck = 4;
                        await CheckCaves();
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 4)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave4Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Fourth cave already completed";

                            await CheckCaves();
                        }
                        CaveToCheck = 5;
                        SendKeys.SendWait("s");
                        Thread.Sleep(2000);
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 5)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave5Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Fifth cave already completed";

                        }
                        CaveToCheck = 6;
                        await CheckCaves();
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 6)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave6Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Sixth cave already completed";

                            await CheckCaves();
                        }
                        CaveToCheck = 7;
                        SendKeys.SendWait("s");
                        Thread.Sleep(2000);
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 7)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave7Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Seventh cave already completed";

                        }
                        CaveToCheck = 8;
                        await CheckCaves();
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 8)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave8Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Eigth cave already completed";

                        }
                        CaveToCheck = 9;
                        SendKeys.SendWait("s");
                        Thread.Sleep(2000);
                        await CheckCaves();
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 9)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave9Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Ninth cave already completed";

                        }
                        CaveToCheck = 10;
                        SendKeys.SendWait("s");
                        Thread.Sleep(2000);
                        await CheckCaves();
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 10)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave10Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Tenth cave already completed";

                        }
                        CaveToCheck = 11;
                        SendKeys.SendWait("s");
                        Thread.Sleep(2000);
                        await CheckCaves();
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 11)
                    {
                        //var ss = HelperFunctions.CaptureScreen();
                        //var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave11Complete.png"), ss, 0);

                        //if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        //{
                        //    Form1.LogMessage = "Eleventh cave already completed";
                        //    CaveToCheck = 12;
                        //    SendKeys.SendWait("s");
                        //    await CheckCaves();
                        //}
                        ClanRaidFightGo();
                    }
                    //else if (CaveToCheck == 2)
                    //{
                    //    var ss = HelperFunctions.CaptureScreen();
                    //    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave12Complete.png"), ss, 0);

                    //    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    //    {
                    //        Form1.LogMessage = "Second cave already completed";
                    //        CaveToCheck = 3;
                    //        SendKeys.SendWait("s");
                    //        await CheckCaves();
                    //    }
                    //}


                });
        }

        public static async Task ClanRaidFightGo()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location1 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button1.png"), ss, 0);
                    var location2 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button2.png"), ss, 0);
                    var location3 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button3.png"), ss, 0);
                    var location4 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button4.png"), ss, 0);
                    var location5 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button5.png"), ss, 0);
                    var location6 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button6.png"), ss, 0);
                    var location7 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button7.png"), ss, 0);
                    var location8 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button8.png"), ss, 0);
                    var location9 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button9.png"), ss, 0);
                    var location10 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button10.png"), ss, 0);
                    var location11 = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\gobuttons\button11.png"), ss, 0);

                    List<Rectangle> locations = new List<Rectangle>
                    {
                        location1,
                        location2,
                        location3,
                        location4,
                        location5,
                        location6,
                        location7,
                        location8,
                        location9,
                        location10,
                        location11,
                    };
                    bool foundClan = false;
                    foreach (var location in locations)
                    {
                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            foundClan = true;
                            Form1.LogMessage = "Found clan raid, enter setup";
                            HelperFunctions.LeftMouseClick(location.X, location.Y);
                            Thread.Sleep(1000);
                            ClanBattleStart();
                        }
                    }
                    if (!foundClan)
                    {
                        Form1.LogMessage = "Didn't find clan raid, looking";
                        SendKeys.SendWait("s");
                        Thread.Sleep(2000);
                        ClanRaids();
                    }
                });
        }

        public static async Task ClanBattleStart()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCaveBattleStart.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Setup ready, starting battle";
                        HelperFunctions.LeftMouseClick(location.X, location.Y);
                    }
                });
        }

    }
}
