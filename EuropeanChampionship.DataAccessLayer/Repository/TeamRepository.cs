using NHibernate;
using ChampionsLeague.Model.Repositories;
using System.Collections.Generic;
using System.Linq;
using ChampionsLeague.Model;
using NHibernate.Linq;

namespace ChampionsLeague.DataAccessLayer.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private ISession _currSession = null;
        public TeamRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public void AddTeam(Team team)
        {
            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Save(team);
                transaction.Commit();
            }
        }

        public void DeleteTeam(Team team)
        {
            Team t = _currSession.Get<Team>(team.Name);
            if (t == null) { return; }

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Delete(t);
                transaction.Commit();
            }
        }

        public Team GetTeam(string teamId)
        {
            Team team = _currSession.Get<Team>(teamId);
            return team;
        }

        public IList<Team> GetAllTeams()
        {
            List<Team> teams = _currSession.Query<Team>().ToList();
            return teams;
        }

        public IList<Game> GetTeamGames(string teamId)
        {
            Team t = _currSession.Get<Team>(teamId);
            return t.Games;
        }

        public void UpdateTeam(Team team)
        {
            Team t = _currSession.Get<Team>(team.Name);
            if (t == null) { return; }
            t = team;

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Update(t);
                transaction.Commit();
            }
        }
    }
}
