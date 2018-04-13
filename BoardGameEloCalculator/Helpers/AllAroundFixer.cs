using BoardGameEloCalculator.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Helpers
{
    static class AllAroundFixer
    {
        public static void ChangePlaysToPlaySessions()
        {
            //List<PlaySession> playSessions = new List<PlaySession>();
            //foreach(Play play in Program.PlayList.Plays)
            //{
            //    PlaySession session = new PlaySession
            //    {
            //        Date = play.Date,
            //        ID = play.ID,
            //        Game = play.Game
            //    };
            //    session.Players = new List<KeyValuePair<string, int>>();
            //    foreach(KeyValuePair<Person,int> players in play.Players)
            //    {
            //        var newPair = new KeyValuePair<string, int>(players.Key.Name,players.Value);
            //        session.Players.Add(newPair);
            //    }
            //    playSessions.Add(session);
            //}

            //Program.PlayList.Form(playSessions);

        }
    }
}
