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
        static List<KeyValuePair<Person, int>> players;
        static List<Person> playerChecker;


        public static int AddPerson(String playername,int position)
        {
            if (players == null)
            {
                players = new List<KeyValuePair<Person, int>>();
                playerChecker = new List<Person>();
            }

            var player = Program.PlayerList.Find(playername);
            if (player == null || position == 0)
                return 0;
            if (playerChecker.Contains(player))
                return 0;
            players.Add(new KeyValuePair<Person,int>(player, position));
            playerChecker.Add(player);
            return 1;
        }

        public static void RemovePerson(string playername)
        {
            Person player = players.Find(p => p.Key.Name == playername).Key;
            if (playerChecker.Contains(player))
            {

                for(int i=0;i<players.Count();i++)
                {
                    if (players[i].Key == player)
                        players.RemoveAt(i);

                }
                playerChecker.Remove(player);
            }
        }

        public static int Evaluate(Game game, DateTime date)
        {
            Play play = new Play
            {
                ID = Program.PlayList.Plays.Count(),
                Game = game,
                Date = date,
                Players = players
            };

            List<float> changes = new List<float>();
            foreach (KeyValuePair<Person,int> player in players)
            {
                var losers = players.Where(pair => pair.Value > player.Value).Select(pair => pair.Key);
                var winners = players.Where(pair => pair.Value < player.Value).Select(pair => pair.Key);
                float change = 0;
                foreach (Person loser in losers)
                {
                    change += EloFormula(loser, player.Key);
                }
                foreach (Person winner in winners)
                {
                    change -= EloFormula(player.Key, winner);
                }
                changes.Add(change);
            }

            for (int i = 0; i < players.Count(); i++)
            {
                players[i].Key.NewElo(changes[i], play);
            }

            Program.PlayerList.SaveToFile();
            Program.PlayList.Add(play);
            players = new List<KeyValuePair<Person, int>>();
            playerChecker = new List<Person>();
            return 1;
        }

        internal static int Log(String gamename,DateTime date)
        {
            Game game = Program.GameList.Find(gamename);
            if (players == null)
                return 0;
            if (players.Count == 0)
                return 0;
            return Evaluate(game,date);
        }

        private static float EloFormula(Person loser, Person winner)
        {
            return (float)Math.Max(10, 25 + 0.1 * (loser.getLatestElo() - winner.getLatestElo()));
        }
    }
}
