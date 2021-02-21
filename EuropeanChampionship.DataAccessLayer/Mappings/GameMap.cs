using ChampionsLeague.Model;
using FluentNHibernate.Mapping;

namespace ChampionsLeague.DataAccessLayer.Mappings
{
    public class GameMap : ClassMap<Game>
    {
        public GameMap()
        {
            Id(p => p.ID).GeneratedBy.Native();
            References(p => p.TeamHome);
            References(p => p.TeamAway);
            References(p => p.Group);
            Map(p => p.TeamHomeScore);
            Map(p => p.TeamAwayScore);
        }
    }
}
