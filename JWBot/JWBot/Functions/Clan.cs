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
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave3Attempts.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "3 attempts remaining, checking first cave";
                        AttemptsRemaining = 3;
                        CaveToCheck = 1;
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
                            CaveToCheck = 2;
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 2)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave2Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Second cave already completed";
                            CaveToCheck = 3;
                            SendKeys.SendWait("s");
                            Thread.Sleep(2000);
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 3)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave3Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Third cave already completed";
                            CaveToCheck = 4;
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 4)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave4Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Fourth cave already completed";
                            CaveToCheck = 5;
                            SendKeys.SendWait("s");
                            Thread.Sleep(2000);
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 5)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave5Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Fifth cave already completed";
                            CaveToCheck = 6;
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 6)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave6Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Sixth cave already completed";
                            CaveToCheck = 7;
                            SendKeys.SendWait("s");
                            Thread.Sleep(2000);
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 7)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave7Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Seventh cave already completed";
                            CaveToCheck = 8;
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 8)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave8Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Eigth cave already completed";
                            CaveToCheck = 9;
                            SendKeys.SendWait("s");
                            Thread.Sleep(2000);
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 9)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave9Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Ninth cave already completed";
                            CaveToCheck = 10;
                            SendKeys.SendWait("s");
                            Thread.Sleep(2000);
                            await CheckCaves();
                        }
                        ClanRaidFightGo();
                    }
                    else if (CaveToCheck == 10)
                    {
                        var ss = HelperFunctions.CaptureScreen();
                        var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCave10Complete.png"), ss, 0);

                        if (location.Width != 0 && location.X > 10 && location.Y > 10)
                        {
                            Form1.LogMessage = "Tenth cave already completed";
                            CaveToCheck = 11;
                            SendKeys.SendWait("s");
                            Thread.Sleep(2000);
                            await CheckCaves();
                        }
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
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\clanCaveGo.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Found clan raid, enter setup";
                        HelperFunctions.LeftMouseClick(location.X,location.Y);
                    }
                });
        }



    }
}
