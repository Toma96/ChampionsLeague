using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampionsLeague.Model;
using FluentNHibernate.Mapping;

namespace ChampionsLeague.DataAccessLayer.Mappings
{
    public class PlayerMap : ClassMap<Player>
    {
        public PlayerMap()
        {
            Id(p => p.ID).GeneratedBy.Native();
            References(p => p.Team);
        }
    }
}
