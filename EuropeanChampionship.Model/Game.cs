namespace ChampionsLeague.Model
{
    public class Game
    {
        public virtual int ID { get; set; }
        public virtual Team TeamHome { get; set; }
        public virtual Team TeamAway { get; set; }
        public virtual Group Group { get; set; }
        public virtual int TeamHomeScore { get; set; }
        public virtual int TeamAwayScore { get; set; }

        public Game(Team team1, Team team2, Group g)
        {
            Group = g;
            TeamHome = team1;
            TeamAway = team2;
            TeamHomeScore = 0;
            TeamAwayScore = 0;
        }

        public Game(Team team1, Team team2)
        {
            TeamHome = team1;
            TeamAway = team2;
            TeamHomeScore = 0;
            TeamAwayScore = 0;
        }

        public Game()
        {
            TeamHomeScore = 0;
            TeamAwayScore = 0;
        }
    }
}
