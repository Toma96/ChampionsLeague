using ChampionsLeague.Model;

namespace ChampionsLeague.BaseLib
{
    public interface IGameController
    {
        void ShowAllGroupGames(IViewGroupGames newFrm);
        void UpdateGameScore(IUpdateGame newForm, Game game, IViewGroupGames form);

        void ShowAddGame(IAddNewGameView newFrm, IViewGroupGames callingForm);

        void UndoGame(Game game);
    }
}
