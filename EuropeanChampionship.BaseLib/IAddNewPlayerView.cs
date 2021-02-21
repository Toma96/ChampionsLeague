using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague.BaseLib
{
    public interface IAddNewPlayerView
    {
        bool ShowModal();
        void AddPlayer(IViewPlayers form, IPlayerController playerController, ITeamRepository teamRepository);
    }
}
