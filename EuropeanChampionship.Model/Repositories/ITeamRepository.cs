using System.Collections.Generic;

namespace ChampionsLeague.Model.Repositories
{
    public interface ITeamRepository
    {
        Team GetTeam(string teamId);
        IList<Team> GetAllTeams();
        IList<Game> GetTeamGames(string teamId);
        void AddTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(Team team);
    }
}
