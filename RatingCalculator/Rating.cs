using System;

namespace AoM.ESO
{
    public class Rating
    {
        public const double MaxPoints = 40;
        public const double BaseRating = 1600;

        public Rating(double rate)
        {
            Rate = rate;
        }

        public double Rate {get; }

        public static MatchResult Match(Rating winner, Rating loser) {
            var difference = winner.Rate - loser.Rate;
            var probability = 1.0 / (1.0 + Math.Pow(10.0, -difference / 100));
            var score = MaxPoints*(1-probability);
            var newWinner = new Rating(winner.Rate+score);
            var newLoser = new Rating(loser.Rate-score);
            return new MatchResult(newWinner, newLoser);
        }
    }
}
