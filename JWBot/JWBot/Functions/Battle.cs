using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JWBot.Functions
{
    static class Battle
    {
        public static async Task CheckBattle()
        {
            await Task.Run(
                () =>
                {
                    CheckBattleEnded();

                    Form1.LogMessage = "No battles, escaping and checking clan";
                    HelperFunctions.LeftMouseClick(Cycle.EscapeCoords.X, Cycle.EscapeCoords.Y);
                    Thread.Sleep(1000);
                    Clan.CheckClan();
                });
        }

        public static async Task CheckBattleEnded()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\battleEnded.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Battle has ended";
                        ClickNext();

                    }

                });
        }

        public static async Task ClickNext()
        {
            await Task.Run(
                () =>
                {
                    var ss = HelperFunctions.CaptureScreen();
                    var location = HelperFunctions.searchBitmap((Bitmap)Bitmap.FromFile(@"C:\Users\theke\Desktop\jwbot\resources\battleNext.png"), ss, 0);

                    if (location.Width != 0 && location.X > 10 && location.Y > 10)
                    {
                        Form1.LogMessage = "Clicking Next";
                        HelperFunctions.LeftMouseClick(location.X, location.Y);

                    }

                });
        }



    }
}
