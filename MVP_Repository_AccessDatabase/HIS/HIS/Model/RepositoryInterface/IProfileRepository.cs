using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IProfileRepository: IRepository<Profile>
    {
        #region Lists for filteredSimplifiedProfiles
        List<String> genderList { get; }
        List<String> villageList { get; }
        List<String> hIslandList { get; }
        List<String> religionList { get; }
        List<String> contactList { get; }
        List<String> PIDList { get; }
        #endregion
        #region Menus
        List<String> genderMenu { get; }
        List<String> bYearMenu { get; }
        List<String> villageMenu { get; }
        List<String> hIslandMenu { get; }
        List<String> maritalMenu { get; }
        List<String> religionMenu { get; }
        List<String> occupationMenu { get; }
        #endregion
        #region Get
        Double GetNewPid();
        Profile GetByID(Double ID);
        Profile GetNewProfile(
            Double pid,
            DateTime saveDate,
            String fName = null,
            String sName = null,
            String gender = null,
            Int32 bYear = 0,
            String village = null,
            String hIsland = null,
            String religion = null,
            String marital = null,
            String occupation = null,
            String contact = null,
            String allergy = null,
            Int32 enrollFingers = 0
        );
        List<Profile> GetSimilarPros(Profile pro);
        #endregion
        #region Profiles Application
        List<ProfileSimplfied> filteredSimplifiedProfiles { get; set; }
        void FilterProfiles(
            String fName = null, String sName = null,
            String gender = null, String village = null,
            String hIsland = null, String religion = null,
            String contact = null);
        void ReloadProfiles();
        void FilterProfilesByFName(String fName);
        void FilterProfilesBySName(String sName);
        void FilterProfilesByGender(String gender);
        void FilterProfilesByVillage(String village);
        void FilterProfilesByHIsland(String hIsland);
        void FilterProfilesByReligion(String religion);
        void FilterProfilesByContact(String contact);
        #endregion

    }
}
