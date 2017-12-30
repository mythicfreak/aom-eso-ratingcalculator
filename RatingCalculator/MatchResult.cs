namespace AoM.ESO
{
    public class MatchResult
    {
        public Rating Winner { get; }
        public Rating Loser { get; }

        public MatchResult(Rating winner, Rating loser)
        {
            Winner = winner;
            Loser = loser;
        }
    }
}