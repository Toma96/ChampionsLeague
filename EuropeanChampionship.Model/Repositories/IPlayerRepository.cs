using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague.Model.Repositories
{
    public interface IPlayerRepository
    {
        Player GetPlayer(int playerId);
        IList<Player> GetAllPlayers();
        void AddPlayer(Player player);
        void DeletePlayer(Player player);
        void UpdatePlayer(Player player);
        IList<Player> GetPlayersByTeam(string teamId);
    }
}
