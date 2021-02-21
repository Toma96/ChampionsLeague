using ChampionsLeague.Model;

namespace ChampionsLeague.BaseLib
{
    public interface IPlayerController
    {
        void ShowAllPlayers(IViewPlayers newFrm);
        void AddNewPlayer(IAddNewPlayerView newForm, Player player, IViewPlayers form);
        void DeletePlayer(Player player, IViewPlayers form);
    }
}
