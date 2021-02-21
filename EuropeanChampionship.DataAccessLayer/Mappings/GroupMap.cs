using ChampionsLeague.Model;
using FluentNHibernate.Mapping;

namespace ChampionsLeague.DataAccessLayer.Mappings
{
    public class GroupMap : ClassMap<Group>
    {
        public GroupMap()
        {
            Id(p => p.Name).GeneratedBy.Assigned();
            HasMany(p => p.Teams).Cascade.All();
            HasMany(p => p.Games).Cascade.All();
        }
    }
}
