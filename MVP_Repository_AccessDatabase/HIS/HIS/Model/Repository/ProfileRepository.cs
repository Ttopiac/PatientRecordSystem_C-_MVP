using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using HIS.FunctionLibrary;

namespace HIS.Model
{
    public class ProfileRepository : AdoRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(string connectionString, IHISDataset hisDataSet)
            : base(connectionString, "PROFILE", hisDataSet)
        {
            allSimplifiedProfiles = this.GetAllSimplifiedProfiles();
            filteredSimplifiedProfiles = new List<ProfileSimplfied>(allSimplifiedProfiles);
        }
        #region Lists for filteredSimplifiedProfiles
        public List<String> genderList
        {
            get
            {
                var list =
                    (from p in filteredSimplifiedProfiles orderby p.Gender select p.Gender).Distinct().ToList();
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> villageList
        {
            get
            {
                var list =
                    (from p in filteredSimplifiedProfiles orderby p.Village select p.Village).Distinct().ToList();
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> hIslandList
        {
            get
            {
                var list =
                    (from p in filteredSimplifiedProfiles orderby p.HIsalnd select p.HIsalnd).Distinct().ToList();
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> religionList
        {
            get
            {
                var list =
                    (from p in filteredSimplifiedProfiles orderby p.Religion select p.Religion).Distinct().ToList();
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> contactList
        {
            get
            {
                var list = (from p in filteredSimplifiedProfiles orderby p.Contact select p.Contact).Distinct().ToList();
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> PIDList
        {
            get
            {
                var list = (from p in filteredSimplifiedProfiles select p.PID.ToString()).Distinct().ToList();
                return list;
            }
        }
        #endregion
        #region Menus
        private List<String> genders = new List<String>() { "Female", "Male" };
        private List<String> bYears = 
            (Enumerable.Range(DateTime.Now.AddYears(-120).Year, +120)).
            ToList().
            ConvertAll<string>(x => x.ToString());
        private List<String> maritals = 
            new List<String>() { "Married", "Single", "Widowed", "Divorced" };
        public List<String> genderMenu
        {
            get
            {
                var list = genders;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> bYearMenu
        {
            get
            {
                var list = bYears;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> villageMenu
        {
            get
            {
                var list = _hisDataset.villageRepository.villageNameList;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> hIslandMenu
        {
            get
            {
                var list = _hisDataset.hIslandRepository.hIslandNameList;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> maritalMenu
        {
            get
            {
                var list = maritals;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> religionMenu
        {
            get
            {
                var list = _hisDataset.religionRepository.religionNameList;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        public List<String> occupationMenu
        {
            get
            {
                var list = _hisDataset.occupationRepository.occupationNameList;
                list.Remove("");
                list.Insert(0, "");
                return list;
            }
        }
        #endregion
        #region Profiles Application
        public List<ProfileSimplfied> GetAllSimplifiedProfiles()
        {
            return
                    (
                        from pro in GetAll()
                        select  new ProfileSimplfied
                        {
                            PID = pro.PID,
                            FName = pro.FName == null ? null : pro.FName.ToLower(),
                            SName = pro.SName == null ? null : pro.SName.ToLower(),
                            Gender = pro.Gender == null ? null : pro.Gender.ToLower(),
                            BYear = pro.BYear,
                            Village = pro.Village == null ? null : pro.Village.ToLower(),
                            HIsalnd = pro.HIsland == null ? null : pro.HIsland.ToLower(),
                            Religion = pro.Religion == null ? null : pro.Religion.ToLower(),
                            Occupation = pro.Occupation == null ? null : pro.Occupation.ToLower(),
                            Contact = pro.Contact == null ? null : pro.Contact.ToLower()
                        })
                        .ToList();
        }
        private List<ProfileSimplfied> allSimplifiedProfiles{ get; set; }
        public List<ProfileSimplfied> filteredSimplifiedProfiles { get; set; }
        public void ReloadProfiles()
        {
            allSimplifiedProfiles = this.GetAllSimplifiedProfiles();
            FilterProfiles();
        }
        public void FilterProfiles(
            String fName=null, String sName=null, String gender = null, String village = null, 
            String hIsland = null, String religion = null, String contact = null)
        {
            filteredSimplifiedProfiles.Clear();
            filteredSimplifiedProfiles = new List<ProfileSimplfied>(allSimplifiedProfiles);
            if (!String.IsNullOrEmpty(gender)) FilterProfilesByGender(gender);
            if (!String.IsNullOrEmpty(village))  FilterProfilesByVillage(village);
            if (!String.IsNullOrEmpty(hIsland)) FilterProfilesByHIsland(hIsland);
            if (!String.IsNullOrEmpty(religion)) FilterProfilesByReligion(religion);
            if (!String.IsNullOrEmpty(contact)) FilterProfilesByContact(contact);
            if (!String.IsNullOrEmpty(sName)) FilterProfilesBySName(sName);
            if (!String.IsNullOrEmpty(fName)) FilterProfilesByFName(fName);
        }
        public void FilterProfilesByFName(String fName)
        {
            filteredSimplifiedProfiles = (
                from pro in filteredSimplifiedProfiles
                where
                (
                    pro.FName.StartsWith(fName.ToLower()) ||
                    LevenshteinDistance.Compute(pro.FName, fName.ToLower())<=2
                )
                orderby LevenshteinDistance.Compute(pro.FName, fName.ToLower())
                select pro).ToList();
        }
        public void FilterProfilesBySName(String sName)
        {
            filteredSimplifiedProfiles = (
                from pro in filteredSimplifiedProfiles
                where
                (
                    pro.SName.StartsWith(sName.ToLower()) ||
                    LevenshteinDistance.Compute(pro.SName, sName.ToLower()) <= 2
                )
                orderby LevenshteinDistance.Compute(pro.SName, sName.ToLower())
                select pro).ToList();
        }
        public void FilterProfilesByGender(String gender)
        {
            filteredSimplifiedProfiles = (
                from pro in filteredSimplifiedProfiles
                where pro.Gender == gender.ToLower()
                select pro).ToList();
        }
        public void FilterProfilesByVillage(String village)
        {
            filteredSimplifiedProfiles = (
                from pro in filteredSimplifiedProfiles
                where pro.Village == village.ToLower()
                select pro).ToList();
        }
        public void FilterProfilesByHIsland(String hIsland)
        {
            filteredSimplifiedProfiles = (
                from pro in filteredSimplifiedProfiles
                where pro.HIsalnd == hIsland.ToLower()
                select pro).ToList();
        }
        public void FilterProfilesByReligion(String religion)
        {
            filteredSimplifiedProfiles = (
                from pro in filteredSimplifiedProfiles
                where pro.Religion == religion.ToLower()
                select pro).ToList();
        }
        public void FilterProfilesByContact(String contact)
        {
            filteredSimplifiedProfiles = (
                from pro in filteredSimplifiedProfiles
                where pro.Contact == contact.ToLower()
                select pro).ToList();
        }
        #endregion
        # region Get
        public Double GetNewPid()
        {
            var maxId = GetAll().Max(x => x.PID);
            return maxId + 1;           
        }
        public Profile GetByID(Double ID)
        {
            var profile = from pro in GetAll()
                          where pro.PID == ID
                          select pro;
            if (profile.Count() == 0) { return null; }
            else { return profile.First(); }
        }
        public Profile GetNewProfile(
            Double pid, DateTime saveDate, String fName = null, String sName = null,
            String gender = null, Int32 bYear = 0, String village = null,
            String hIsland = null, String religion = null, String marital = null,
            String occupation = null, String contact = null, String allergy = null,
            Int32 enrollFingers = 0)
        {
            return new Profile
            {
                PID = pid,
                SaveDate = saveDate,
                FName = fName,
                SName = sName,
                Gender = gender,
                BYear = bYear,
                Village = village,
                HIsland = hIsland,
                Religion = religion,
                Marital = marital,
                Occupation = occupation,
                Contact = contact,
                Allergy = allergy,
                EnrollFingers = enrollFingers,
                Death = false,
                DeathTime = new DateTime(9999,12,31),
                DeathCause = null,
                InsertDate = DateTime.Today,
                IsPermanentPID = false
            };
        }
        public List<Profile> GetSimilarPros(Profile pro)
        {
            var profileList = (
                from e in GetAll()
                where
                (
                    LevenshteinDistance.Compute(e.FName.ToLower(), pro.FName.ToLower()) <= 2 &&
                    LevenshteinDistance.Compute(e.SName.ToLower(), pro.SName.ToLower()) <= 2 &&
                    e.BYear <= pro.BYear + 1 &&
                    e.BYear >= pro.BYear - 1 &&
                    e.Gender.ToLower() == pro.Gender.ToLower() &&
                    e.Village.ToLower() == pro.Village.ToLower() &&
                    e.HIsland.ToLower() == pro.HIsland.ToLower()
                )
                orderby LevenshteinDistance.Compute(e.FName, pro.FName.ToLower())
                select e).ToList();
            return profileList;
        }
        #endregion
        public override Profile PopulateRecord(OleDbDataReader reader)
        {
            return new Profile
            {
                PID = reader.GetDouble(0),
                SaveDate = reader.GetDateTime(1),
                FName = reader.IsDBNull(2) == true ? null : reader.GetString(2),
                SName = reader.IsDBNull(3) == true ? null : reader.GetString(3),
                Gender = reader.IsDBNull(4) == true ? null : reader.GetString(4),
                BYear = reader.GetInt32(5),
                Village = reader.IsDBNull(6) == true ? null : reader.GetString(6),
                HIsland = reader.IsDBNull(7) == true ? null : reader.GetString(7),
                Religion = reader.IsDBNull(8) == true ? null : reader.GetString(8),
                Marital = reader.IsDBNull(9) == true ? null : reader.GetString(9),
                Occupation = reader.IsDBNull(10) == true ? null : reader.GetString(10),
                Contact = reader.IsDBNull(11) == true ? null : reader.GetString(11),
                Allergy = reader.IsDBNull(12) == true ? null : reader.GetString(12),
                EnrollFingers = reader.GetInt32(13),
                Death = reader.GetBoolean(14),
                DeathTime = reader.IsDBNull(15) == true ? new DateTime(9999, 12, 31).Date : reader.GetDateTime(15),
                DeathCause = reader.IsDBNull(16) == true ? null : reader.GetString(16),
                InsertDate = reader.IsDBNull(17) == true ? DateTime.Today.Date : reader.GetDateTime(17),
                IsPermanentPID = reader.GetBoolean(18)
            };
        }


    }
}
