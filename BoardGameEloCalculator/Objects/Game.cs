using BoardGameEloCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Objects
{
    class Game : IBoardGameObject
    {
        string name;

        public string Name { get => name; set => name = value; }

        public Game(string name)
        {
            Name = name;
        }
    }
}
