using System.Collections.Generic;

namespace ChampionsLeague.Model
{
    public class Team
    {
        public virtual string Name { get; set; }
        public virtual Group Group { get; set; }
        public virtual IList<Game> Games { get; set; }
        public virtual int Points { get; set; }
        public virtual short NoPlayedGames { get; set; }
        public virtual short NoWins { get; set; }
        public virtual short NoDraws { get; set; }
        public virtual short NoLosses { get; set; }
        public virtual int GoalsScored { get; set; }
        public virtual int GoalsConceded { get; set; }
        public virtual int GoalDifference { get; set; }
        public virtual IList<Player> Players { get; set; }

        public Team(string name, IList<Game> g, Group group)
        {
            Name = name;
            Group = group;
            Games = g;
            Points = 0;
            NoPlayedGames = 0;
            NoWins = 0;
            NoLosses = 0;
            GoalsScored = 0;
            GoalsConceded = 0;
            GoalDifference = 0;
            Players = new List<Player>();
        }

        public Team(string name, Group group)
        {
            Name = name;
            Group = group;
            Games = new List<Game>();
            Players = new List<Player>();

        }

        public Team(string name)
        {
            Name = name;
            Games = new List<Game>();
            Players = new List<Player>();

        }

        public Team()
        {
            Name = "NoTeam";
            Games = new List<Game>();
            Players = new List<Player>();

        }

        public override string ToString()
        {
            return Name;
        }

    }
}
