using ChampionsLeague.Model;

namespace ChampionsLeague.BaseLib
{
    public interface IGroupController
    {
        void ShowAllGroups(IViewGroups newFrm);
        void AddNewGroup(IAddNewGroupView newForm, Group g, IViewGroups form);
    }
}
