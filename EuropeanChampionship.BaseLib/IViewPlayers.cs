using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague.BaseLib
{
    public interface IViewPlayers
    {
        void ShowAllPlayers(IPlayerController playerController, IPlayerRepository playerRepository, ITeamRepository teamRepository);
    }
}
