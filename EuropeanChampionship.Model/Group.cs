using System.Collections.Generic;

namespace ChampionsLeague.Model
{
    public class Group
    {
        public virtual string Name { get; set; }
        public virtual IList<Team> Teams { get; set; }
        public virtual IList<Game> Games { get; set; }

        public Group(string name, IList<Team> teams, IList<Game> g)
        {
            Name = name;
            Teams = teams;
            Games = g;
        }

        public Group(string name)
        {
            Name = name;
            Teams = new List<Team>();
            Games = new List<Game>();
        }

        public Group()
        {
            Name = "NoGroup";
            Teams = new List<Team>();
            Games = new List<Game>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
