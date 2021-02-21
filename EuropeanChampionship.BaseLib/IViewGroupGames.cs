using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System.Collections.Generic;

namespace ChampionsLeague.BaseLib
{
    public interface IViewGroupGames
    {
        void ShowAllGroupGames(IGameController gameController, IGameRepository gameRepository, ITeamRepository teamRepository);
    }
}
