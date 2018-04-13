using BoardGameEloCalculator.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Helpers
{
    class Recalculator
    {
        public static void Recalculate()
        {
            foreach(Person player in Program.PlayerList.Players)
            {
                player.Wipe();
            }

            foreach(PlaySession play in Program.PlayList.Plays)
            {
                //foreach (KeyValuePair<string,int> player in play.Players)
                //{
                //    Program.PlayerList.Find(player.Key).Wipe();
                //}
                LogPlay.Evaluate(play);
            }
            Logger.Log("Recalculated after "+ Program.PlayList.Plays.Count()+ " plays");
        }
    }
}
