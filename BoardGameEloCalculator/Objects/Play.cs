using BoardGameEloCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CodeRed.Serialization;


namespace BoardGameEloCalculator.Objects
{
    class Play : IBoardGameObject
    {
        int id;
        Game game;
        DateTime date;

        //zmenit na kombinacie meno poradie
        List< KeyValuePair<Person, int>> players;

        public int ID { get => id; set => id = value; }
        public Game Game { get => game; set => game = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<KeyValuePair<Person, int>> Players { get => players; set => players = value; }
    }
}
