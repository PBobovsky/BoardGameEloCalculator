using BoardGameEloCalculator.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Helpers
{
    class GameManager
    {
        internal static void AddGame(string text)
        {
            Game game = new Game(text);
            Program.GameList.Add(game);
        }
    }
}
