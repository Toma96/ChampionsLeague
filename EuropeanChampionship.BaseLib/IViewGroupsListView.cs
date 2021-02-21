using ChampionsLeague.Model;
using System.Collections.Generic;

namespace ChampionsLeague.BaseLib
{
    public interface IViewGroupsListView
    {
        void ShowAllGroups(IGroupController groupController, List<Group> listGroups);
    }
}
