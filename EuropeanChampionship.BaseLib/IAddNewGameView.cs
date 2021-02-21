using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague.BaseLib
{
    public interface IAddNewGameView
    {
        void AddGame(IViewGroupGames callingForm, IGameController gameController, ITeamRepository teamRepository, IGameRepository gameRepository, IPlayerRepository playerRepository);
    }
}
