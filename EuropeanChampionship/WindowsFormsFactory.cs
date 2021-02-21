using ChampionsLeague.BaseLib;

namespace ChampionsLeague
{
    class WindowsFormsFactory : IWindowsFormsFactory
    {
        public IViewGroups CreateViewGroups()
        {
            var newFrm = new frmViewGroups();
            return newFrm;
        }

        public IViewTeams CreateViewTeams()
        {
            var newFrm = new frmViewTeams();
            return newFrm;
        }

        public IViewGroupGames CreateViewGroupGames()
        {
            var newFrm = new frmViewGroupGames();
            return newFrm;
        }

        public IViewPlayers CreateViewPlayers()
        {
            var newFrm = new frmViewPlayers();
            return newFrm;
        }
    }
}
