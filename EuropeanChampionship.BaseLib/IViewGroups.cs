using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System.Collections.Generic;

namespace ChampionsLeague.BaseLib
{
    public interface IViewGroups
    {
        void ShowAllGroups(IGroupController groupController, List<Group> listGroup);
    }
}
