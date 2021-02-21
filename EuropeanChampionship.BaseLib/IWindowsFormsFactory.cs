namespace ChampionsLeague.BaseLib
{
    public interface IWindowsFormsFactory
    {
        IViewGroups CreateViewGroups();
        IViewTeams CreateViewTeams();
        IViewGroupGames CreateViewGroupGames();
        IViewPlayers CreateViewPlayers();
    }
}
