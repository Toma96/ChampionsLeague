using System.Collections.Generic;

namespace ChampionsLeague.Model.Repositories
{

    public interface IGameRepository
    {
        void AddGame(Game game);
        void UpdateGame(Game game);
        void DeleteGame(Game game);

        void UndoGame(Game game);
        Game GetGameById(int gameId);
        IList<Game> GetAllGames();
        IList<Game> GetGamesByTeam(string teamId);
        IList<Game> GetGamesByGroup(string groupId);
    }
}
