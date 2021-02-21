using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System.Collections.Generic;

namespace ChampionsLeague.BaseLib
{
    public interface IViewTeams
    {
        void ShowAllTeams(ITeamController teamController, IGroupRepository groupRepository, List<Team> listTeam);
    }
}