using System.Collections.Generic;
using System.Linq;
using NHibernate;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using NHibernate.Linq;

namespace ChampionsLeague.DataAccessLayer.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private ISession _currSession = null;
        public PlayerRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public void AddPlayer(Player player)
        {
            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Save(player);
                transaction.Commit();
            }
        }

        public void DeletePlayer(Player player)
        {
            Player p = _currSession.Get<Player>(player.ID);
            if (p == null) { return; }

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Delete(p);
                transaction.Commit();
            }
        }

        public IList<Player> GetAllPlayers()
        {
            List<Player> players = _currSession.Query<Player>().ToList();
            return players;
        }

        public Player GetPlayer(int playerId)
        {
            Player player = _currSession.Get<Player>(playerId);
            return player;
        }

        public IList<Player> GetPlayersByTeam(string teamId)
        {
            Team team = _currSession.Get<Team>(teamId);
            return team.Players;
        }

        public void UpdatePlayer(Player player)
        {
            Player p = _currSession.Get<Player>(player.ID);
            if (p == null) { return; }
            p = player;

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Update(p);
                transaction.Commit();
            }
        }
    }
}
