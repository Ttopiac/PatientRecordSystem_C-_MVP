using System;
using System.Collections.Generic;

namespace HIS.View
{
    public interface IOperatorView
    {
        Object profilesGridDataSource { set; }
        Presenter.OperatorPresenter Presenter { set; }
        String searchedFName { get; set; }
        String searchedSName { get; set; }
        String searchedGender { get; }
        String searchedVillage { get; }
        String searchedHIsland { get; }
        String searchedReligion { get; }
        String searchedContact { get; }
        String selectedPID { get; set; }
        Int32 selectedIndex { get;  set; }
        Object selectedProfile { get; }
        List<String> genderList { set; }
        List<String> villageList { set; }
        List<String> hIslandList { set; }
        List<String> religionList { set; }
        List<String> contactList { set; }
        List<String> PIDList { set; }
        Boolean infoChangedHandler { set; }
    }
}

