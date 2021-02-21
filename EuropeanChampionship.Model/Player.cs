
namespace ChampionsLeague.Model
{
    public enum Position {GK, DEF, MID, FW};
    public class Player
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual Team Team { get; set; }
        public virtual Position Pos { get; set; }
        public virtual int NoGames { get; set; }
        public virtual int NoGoals { get; set; }
        public virtual int RedCards { get; set; }

        public Player(string name, Team team, Position position)
        {
            Name = name;
            Team = team;
            Pos = position;
            NoGames = 0;
            NoGoals = 0;
            RedCards = 0;
            team.Players.Add(this);
        }

        public Player()
        {
            Name = "Unnamed";
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
