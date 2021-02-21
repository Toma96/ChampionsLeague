using ChampionsLeague.Model;
using System.Collections.Generic;

namespace ChampionsLeague.BaseLib
{
    public interface IAddNewGroupView
    {
        bool ShowModal();
        void AddGroup(IViewGroups form, IGroupController groupController,  IList<Group> groupList);
    }
}
