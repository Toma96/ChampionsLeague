using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague.BaseLib
{
    public interface IAddNewTeamView
    {
        bool ShowModal();
        void AddTeam(IViewTeams form, ITeamController teamController, IGroupRepository groupRepository);
    }
}
