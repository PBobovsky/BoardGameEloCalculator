using BoardGameEloCalculator.Helpers;
using BoardGameEloCalculator.Objects;
using CodeRed.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator
{
    class LogPlay
    {
        static List<KeyValuePair<string, int>> players;
        static List<string> playerChecker;


        public static int AddPerson(String playername,int position)
        {
            if (players == null)
            {
                players = new List<KeyValuePair<string, int>>();
                playerChecker = new List<string>();
            }

            if ( position == 0)
                return 0;
            if (playerChecker.Contains(playername))
                return 0;
            players.Add(new KeyValuePair<string, int>(playername, position));
            playerChecker.Add(playername);
            return 1;
        }

        public static void RemovePerson(string playername)
        {
            //Person player = players.Find(p => p.Key.Name == playername).Key;
            if (playerChecker.Contains(playername))
            {

                for(int i=0;i<players.Count();i++)
                {
                    if (players[i].Key == playername)
                        players.RemoveAt(i);

                }
                playerChecker.Remove(playername);
            }
        }

        public static int Evaluate(PlaySession play)
        {
            List<double> changes = new List<double>();
            foreach (KeyValuePair<string,int> player in play.Players)
            {
                var losers = play.Players.Where(pair => pair.Value > player.Value).Select(pair => pair.Key);
                var winners = play.Players.Where(pair => pair.Value < player.Value).Select(pair => pair.Key);
                var ties = play.Players.Where(pair => pair.Value == player.Value && pair.Key != player.Key).Select(pair => pair.Key);
                double change = 0;
                foreach (string loser in losers)
                {
                    change += FormulaKeeper.Formula(Program.PlayerList.Find(loser), Program.PlayerList.Find(player.Key),1);
                }
                foreach (string winner in winners)
                {
                    change += FormulaKeeper.Formula(Program.PlayerList.Find(winner), Program.PlayerList.Find(player.Key),0);
                }

                foreach (string tie in ties)
                {
                    change += FormulaKeeper.Formula(Program.PlayerList.Find(tie), Program.PlayerList.Find(player.Key), 0.5);
                }

                changes.Add(change);
            }

            for (int i = 0; i < play.Players.Count(); i++)
            {
                Program.PlayerList.Find(play.Players[i].Key).NewElo(changes[i], play);
            }

            Program.PlayerList.SaveToFile();
            
            
            return 1;
        }

        internal static int Log(String gamename,DateTime date)
        {
            Game game = Program.GameList.Find(gamename);
            if (players == null)
                return 0;
            if (players.Count == 0)
                return 0;
            PlaySession play = new PlaySession
            {
                ID = Program.PlayList.Plays.Count(),
                Game = game,
                Date = date,
                Players = players
            };
            players = new List<KeyValuePair<string, int>>();
            playerChecker = new List<string>();
            Program.PlayList.Add(play);
            return Evaluate(play);
        }

        
    }
}
