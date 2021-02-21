using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System.Collections.Generic;

namespace ChampionsLeague.Controller
{
    public class GameController : IGameController
    {
        private IGameRepository _gameRepository;
        readonly ITeamRepository _teamRepository;
        readonly IPlayerRepository _playerRepository;

        public GameController(IGameRepository gameRepository, ITeamRepository teamRepository, IPlayerRepository playerRepository)
        {
            _gameRepository = gameRepository;
            _teamRepository = teamRepository;
            _playerRepository = playerRepository;
        }

        public void ShowAllGroupGames(IViewGroupGames newFrm)
        {
            newFrm.ShowAllGroupGames(this, _gameRepository, _teamRepository);
        }

        public void ShowAddGame(IAddNewGameView newFrm, IViewGroupGames callingForm)
        {
            newFrm.AddGame(callingForm, this, _teamRepository, _gameRepository, _playerRepository);
        }

        public void UpdateGameScore(IUpdateGame newForm, Game game, IViewGroupGames form)
        {
            _gameRepository.UpdateGame(game);

            this.ShowAllGroupGames(form);
        }

        public void UndoGame(Game game)
        {
            _gameRepository.UndoGame(game);
        }
    }
}
