using NHibernate;
using System.Collections.Generic;
using System.Linq;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using NHibernate.Linq;

namespace ChampionsLeague.DataAccessLayer.Repository
{
    public class GroupRepository : IGroupRepository
    {
        private ISession _currSession = null;
        public GroupRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public void AddGroup(Group group)
        {
            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Save(group);
                transaction.Commit();
            }
        }

        public void DeleteGroup(Group group)
        {
            Group g = _currSession.Get<Group>(group.Name);
            if (g == null) { return; }

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Delete(g);
                transaction.Commit();
            }
        }

        public IList<Group> GetAllGroups()
        {
            List<Group> groups = _currSession.Query<Group>().ToList();
            return groups;
        }

        public Group GetGroup(string groupId)
        {
            Group group = _currSession.Get<Group>(groupId);
            return group;
        }

        public IList<Game> GetGroupGames(string groupId)
        {
            Group group = _currSession.Get<Group>(groupId);
            return group.Games;
            
        }

        public IList<Team> GetGroupTeams(string groupId)
        {
            Group group = _currSession.Get<Group>(groupId);
            return group.Teams;
        }

        public void UpdateGroup(Group group)
        {
            Group g = _currSession.Get<Group>(group.Name);
            if(g == null) { return; }
            g = group;

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Update(g);
                transaction.Commit();
            }
        }
    }
}
