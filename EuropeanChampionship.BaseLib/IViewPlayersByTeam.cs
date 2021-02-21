using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampionsLeague.Model;

namespace ChampionsLeague.BaseLib
{
    public interface IViewPlayersByTeam
    {
        void ShowPlayersByTeam(Team team, IList<Player> playerRepository);
    }
}
