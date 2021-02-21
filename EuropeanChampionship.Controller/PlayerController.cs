using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague.Controller
{
    public class PlayerController : IPlayerController
    {
        ITeamRepository _teamRepository;
        IPlayerRepository _playerRepository;

        public PlayerController(IPlayerRepository playerRepository, ITeamRepository teamRepository)
        {
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
        }
        public void AddNewPlayer(IAddNewPlayerView newForm, Player player, IViewPlayers form)
        {
            _playerRepository.AddPlayer(player);

            this.ShowAllPlayers(form);
        }

        public void DeletePlayer(Player player, IViewPlayers form)
        {
            _playerRepository.DeletePlayer(player);
            Team t = _teamRepository.GetTeam(player.Team.ToString());
            t.Players.Remove(player);

            this.ShowAllPlayers(form);
        }

        public void ShowAllPlayers(IViewPlayers newFrm)
        {
            newFrm.ShowAllPlayers(this, _playerRepository, _teamRepository);
        }
    }
}
