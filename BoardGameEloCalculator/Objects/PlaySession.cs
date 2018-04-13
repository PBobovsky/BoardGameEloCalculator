using BoardGameEloCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Objects
{
    class PlaySession : IBoardGameObject
    {
        int id;
        Game game;
        DateTime date;

        //zmenit na kombinacie meno poradie
        List<KeyValuePair<string, int>> players;

        public int ID { get => id; set => id = value; }
        public Game Game { get => game; set => game = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<KeyValuePair<string, int>> Players { get => players; set => players = value; }
    }
}
