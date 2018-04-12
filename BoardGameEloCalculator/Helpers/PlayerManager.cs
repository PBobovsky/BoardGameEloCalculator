using BoardGameEloCalculator.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Helpers
{
    class PlayerManager
    {
        internal static void Add(string text)
        {
            Person player = new Person(text);
            Program.PlayerList.Add(player);
        }
    }
}
