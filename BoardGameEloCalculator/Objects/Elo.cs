using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Objects
{
    class Elo
    {
        int validAfterPlay;
        double amount;
        Elo previous;
        double valuePrevious;

        public int ValidAfter { get => validAfterPlay; set => validAfterPlay = value; }
        public double Amount { get => amount; set => amount = value; }
        public Elo Previous { get => previous; set => previous = value; }
        public double ValuePrevious { get => valuePrevious; set => valuePrevious = value; }

        public Elo(Elo previousElo,double change,PlaySession play)
        {
            Previous = previousElo;
            ValuePrevious = previousElo.GetValue();
            ValidAfter = play.ID;
            Amount = previousElo.GetValue() + change;
        }

        public Elo()
        {
            Previous = null;
            ValidAfter = 0;
            Amount = 1000;
            ValuePrevious = 1000;

        }

        public double GetValue()
        {
            return Amount;
        }

        public void FixFromPrevious()
        {
            if (Previous.GetValue() != ValuePrevious)
            {
                Amount = Previous.GetValue() + ValuePrevious - Amount; 
            }
        }
    }
}
