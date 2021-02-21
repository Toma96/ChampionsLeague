using ChampionsLeague.Model;

namespace ChampionsLeague.BaseLib
{
    public interface ITeamController
    {
        void ShowAllTeams(IViewTeams newFrm);
        void AddNewTeam(IAddNewTeamView newForm, Team team, Group group, IViewTeams form);
    }
}
