using BoardGameEloCalculator.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameEloCalculator.Helpers
{
    class FormulaKeeper
    {
        static double K = 50;
        static double minimumChangeWin = 5;
        static double maximumChangeLose = -5;
        static double minimumChangeTie = -1000;

        internal static double Formula(Person opponent, Person player, double state)
        {
            return EloFormula( opponent,  player, state);
        }

        static float PercentageFormula(Person loser, Person winner)
        {
            return (float)Math.Max(10, 25 + 0.1 * (loser.getLatestElo() - winner.getLatestElo()));
        }

        static double EloFormula(Person opponent, Person player, double state)
        {
            var expectedScore = 1 / (1 + Math.Pow(10, (opponent.getLatestElo() - player.getLatestElo()) / 400));


            var changePlayer = K * (state - expectedScore);
            double change=changePlayer;
            if (state == 1)
                change = Math.Max(changePlayer, minimumChangeWin);
            if (state == 0.5)
                change = changePlayer;
            if (state == 0)
                change = Math.Min(changePlayer, maximumChangeLose);


            return change;


        }
    }
}
