using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampionsLeague.Model;
using ChampionsLeague.BaseLib;

namespace ChampionsLeague.BaseLib
{
    public interface IViewTeamsByGroup
    {
        void ShowTeamsByGroup(Group group, IList<Team> teamRepository);
    }
}
