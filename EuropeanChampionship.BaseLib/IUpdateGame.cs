using ChampionsLeague.Model;

namespace ChampionsLeague.BaseLib
{
    public interface IUpdateGame
    {
        bool ShowModal();
        void UpdateGame(IViewGroupGames form, IGameController gameController, Game SelectedGame);
    }
}
