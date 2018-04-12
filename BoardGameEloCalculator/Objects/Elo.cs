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
        float amount;
        Elo previous;
        float valuePrevious;

        public int ValidAfter { get => validAfterPlay; set => validAfterPlay = value; }
        public float Amount { get => amount; set => amount = value; }
        public Elo Previous { get => previous; set => previous = value; }
        public float ValuePrevious { get => valuePrevious; set => valuePrevious = value; }

        public Elo(Elo previousElo,float change,Play play)
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

        public float GetValue()
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
