using BoardGameEloCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Objects
{
    class Person : IBoardGameObject
    {
        string name;
        List<Elo> eloList;

        public Person(string name)
        {
            Name = name;
            EloList = new List<Elo>
            {
                new Elo()
            };
        }

        public string Name { get => name; set => name = value; }
        public List<Elo> EloList { get => eloList; set => eloList = value; }

        public double getLatestElo()
        {
            return EloList.Last().GetValue();
        }

        public void NewElo(double change, PlaySession play)
        {
            Elo newElo = new Elo(EloList.Last(), change, play);
            EloList.Add(newElo);

        }

        public void Wipe()
        {
            eloList.Clear();
            eloList.Add(new Elo());
        }
    }
}
