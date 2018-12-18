using HIS.View;
using HIS.Model;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HIS.Presenter
{
    public class PatientRegistryPresenter: IYesNoFormPresenter
    {
        private IPatientRegistryView _patientRegView;
        private IHISDataset _hisDataset;
        private IYesNoView _formCloser;
        private Boolean doCloserStart;
        private String _clinic;
        private Int32 _operator;
        private Profile _profile;
        private Profile newProfile;
        private Boolean IsFirstProfile;
        private Habit _habit;
        private Habit newHabit;
        private Boolean IsFirstHabit;
        private Family _family;
        private Family newFamily;
        private Boolean IsFirstFamily;
        public PatientRegistryPresenter(IPatientRegistryView patientRegView, IHISDataset hisDataset, Double pid, String clinic, Int32 oper)
        {
            _patientRegView = patientRegView;
            _patientRegView.Presenter = this;
            _hisDataset = hisDataset;
            _patientRegView.PID = pid;
            SetProfile(pid);
            SetHabit(pid);
            SetFamily(pid);
            _clinic = clinic;
            _operator = oper;
            doCloserStart = false;
        }
        #region Functions for event handlers on "PatientRegistry" view
        public void OnPatientRegistryFormLoad()
        {
            SetMenus();
            LoadProfile();
            LoadHabit();
            LoadFamily();
        }
        public void Save()
        {
            if (!SaveProfile()) return;
            else
            {
                _hisDataset.Commit();
                SetProfile(newProfile.PID);
            }
            if (!SaveHabit()) {; }
            else
            {
                _hisDataset.Commit();
                SetHabit(newProfile.PID);
            }
            if (!SaveFamily()) {; }
            else
            {
                _hisDataset.Commit();
                SetFamily(newProfile.PID);
            }
        }
        public Boolean Close()
        {
            if (doCloserStart == false)
            {
                _formCloser = new YesNoForm("closer");
                _formCloser.Presenter = this;
                _formCloser.Show();
                _formCloser.closerMessage = "Do you want to save data?";
                doCloserStart = true;
                _patientRegView.IsEnabled = false;
                return false;
            }
            else { return true; }
        }
        public void SetHabitYearMenu()
        {
            if (!String.IsNullOrEmpty(_patientRegView.BYear))
            {
                _hisDataset.habitRepository.SetYearMenu(Convert.ToInt32(_patientRegView.BYear));
                _patientRegView.yearMenu = _hisDataset.habitRepository.yearMenu;
            }
        }
        #endregion
        #region Closer actions
        public void YesActionByYNForm(String formName)
        {
            switch (formName)
            {
                case "closer":
                    Save();
                    _patientRegView.Close();
                    _formCloser.Close();
                    break;
                default:
                    break;
            }
        }
        public void NoActionByYNForm(String formName)
        {
            switch (formName)
            {
                case "closer":
                    _patientRegView.Close();
                    _formCloser.Close();
                    break;
                default:
                    break;
            }
        }
        public void CloseActionByYNForm(String formName)
        {            
            switch (formName)
            {       
                case "closer":
                    _patientRegView.IsEnabled = true;
                    doCloserStart = false;
                    break;
                default:
                    break;
            }    
        }
        #endregion
        private void SetProfile(Double pid)
        {
            _profile = _hisDataset.profileRepository.GetByID(pid);
            IsFirstProfile = (_profile == null) ? true : false;
            if (IsFirstProfile)
            { newProfile = _hisDataset.profileRepository.GetNewProfile(pid, DateTime.Today); }
            else
            { newProfile = _hisDataset.profileRepository.GetByID(pid); }
        }
        private void SetHabit(Double pid)
        {
            _habit = _hisDataset.habitRepository.GetByPidAndSavedate(pid, DateTime.Today);
            IsFirstHabit = (_habit == null) ? true : false;
            if (IsFirstHabit)
            {
                _habit = _hisDataset.habitRepository.GetNewestEntity(pid);
                if (_habit == null)
                {
                    _habit = _hisDataset.habitRepository.GetNewEntity(pid, DateTime.Today);
                    newHabit = _hisDataset.habitRepository.GetNewEntity(pid, DateTime.Today);
                }
                else
                {
                    newHabit = _hisDataset.habitRepository.GetNewestEntity(pid);
                }
            }
            else
            { newHabit = _hisDataset.habitRepository.GetByPidAndSavedate(pid, DateTime.Today); }
        }
        private void SetFamily(Double pid)
        {
            _family = _hisDataset.familyRepository.GetByPidAndSavedate(pid, DateTime.Today);
            IsFirstFamily = (_family == null) ? true : false;
            if (IsFirstFamily)
            {
                _family = _hisDataset.familyRepository.GetNewestEntity(pid);
                if (_family == null)
                {
                    _family = _hisDataset.familyRepository.GetNewEntity(pid, DateTime.Today);
                    newFamily = _hisDataset.familyRepository.GetNewEntity(pid, DateTime.Today);
                }
                else
                {
                    newFamily = _hisDataset.familyRepository.GetNewestEntity(pid);
                }
            }
            else
            { newFamily = _hisDataset.familyRepository.GetByPidAndSavedate(pid, DateTime.Today); }
        }
        private void SetMenus()
        {
            _patientRegView.genderMenu = _hisDataset.profileRepository.genderMenu;
            _patientRegView.bYearMenu = _hisDataset.profileRepository.bYearMenu;
            _patientRegView.villageMenu = _hisDataset.profileRepository.villageMenu;
            _patientRegView.hIslandMenu = _hisDataset.profileRepository.hIslandMenu;
            _patientRegView.maritalMenu = _hisDataset.profileRepository.maritalMenu;
            _patientRegView.religionMenu = _hisDataset.profileRepository.religionMenu;
            _patientRegView.occupationMenu = _hisDataset.profileRepository.hIslandMenu;
            _patientRegView.yearMenu = _hisDataset.habitRepository.yearMenu;
            _patientRegView.freqMenu = _hisDataset.habitRepository.freqMenu;
            _patientRegView.diabetesMenu = _hisDataset.familyRepository.diabetesMenu;
        }
        private void LoadProfile()
        {
            _patientRegView.PID = Convert.ToInt64(newProfile.PID);
            _patientRegView.FName = newProfile.FName;
            _patientRegView.SName = newProfile.SName;
            _patientRegView.Gender = newProfile.Gender;
            _patientRegView.BYear = newProfile.BYear.ToString();
            _patientRegView.Village = newProfile.Village;
            _patientRegView.HIsalnd = newProfile.HIsland;
            _patientRegView.Marital = newProfile.Marital;
            _patientRegView.Religion = newProfile.Religion;
            _patientRegView.Occupation = newProfile.Occupation;
            _patientRegView.Contact = newProfile.Contact;
            _patientRegView.Allergy = newProfile.Allergy;
        }
        private Boolean IsProfileCompleted()
        {
            _patientRegView.profileErrorMessage = "";
            String error = "";
            if (String.IsNullOrEmpty(_patientRegView.FName) ) { error += "FName, "; }
            if (String.IsNullOrEmpty(_patientRegView.SName) ) { error += "SName, "; }
            if (String.IsNullOrEmpty(_patientRegView.Gender) ) { error += "Gender, "; }
            if (String.IsNullOrEmpty(_patientRegView.BYear) ) { error += "Birth Year, "; }
            if (String.IsNullOrEmpty(_patientRegView.Village) ) { error += "Village, "; }
            if (String.IsNullOrEmpty(_patientRegView.HIsalnd) ) { error += "Home Island, "; }
            if (String.IsNullOrEmpty(error)){ return true; }
            else
            {
                // Remove substring  ", "
                error = error.Remove(error.Length - 2);
                error = error.Insert(0, "Error: ");
                error += " should be completed";
                _patientRegView.profileErrorMessage = error;
                return false;
            }
        }
        private Boolean SaveProfile()
        {
            if (IsProfileCompleted())
            {
                PopulateNewProfile();
                if (IsFirstProfile)
                {
                    return RecordNewProfile();
                }
                else
                {
                    RecordOldProfile();
                }
                return true;
            }
            else { return false; }
        }
        private Boolean RecordOldProfile()
        {
            if (!newProfile.IsEqual(_profile))
            {
                var similarPros = _hisDataset.profileRepository.GetSimilarPros(newProfile);
                if (similarPros.Count == 0 || (similarPros.Count == 1 && similarPros.First().PID == newProfile.PID))
                {
                    _hisDataset.profileRepository.Update(newProfile, _clinic, _operator);
                    return true;
                }
                else
                {
                    String err =
                        "This profile won't be record because we already got similar profiles : \n";
                    foreach (var e in similarPros)
                    {
                        if (e.PID != newProfile.PID)
                        {
                            err += e.PID.ToString() + " ";
                        }
                    }
                    _patientRegView.profileErrorMessage = err;
                    return false;
                }
            }
            return true;
        }
        private Boolean RecordNewProfile()
        {
            var similarPros = _hisDataset.profileRepository.GetSimilarPros(newProfile);
            if (similarPros.Count == 0)
            {
                _hisDataset.profileRepository.Create(newProfile, _clinic, _operator);
                return true;
            }
            else
            {
                String err =
                    "This profile won't be record because we already got similar profiles : \n";
                foreach (var e in similarPros)
                {
                    err += e.PID.ToString() + " ";
                }
                _patientRegView.profileErrorMessage = err;
                return false;
            }
        }
        private void PopulateNewProfile()
        {
            newProfile.FName = _patientRegView.FName;
            newProfile.SName = _patientRegView.SName;
            newProfile.SaveDate = DateTime.Today;
            newProfile.Gender = _patientRegView.Gender;
            newProfile.BYear = Convert.ToInt32(_patientRegView.BYear);
            newProfile.Village = _patientRegView.Village;
            newProfile.HIsland = _patientRegView.HIsalnd;
            newProfile.Marital = _patientRegView.Marital;
            newProfile.Religion = _patientRegView.Religion;
            newProfile.Occupation = _patientRegView.Occupation;
            newProfile.Contact = _patientRegView.Contact;
            newProfile.Allergy = _patientRegView.Allergy;
        }
        private void LoadHabit()
        {
            _patientRegView.Smoke_year = newHabit.Smoke_year;
            _patientRegView.Smoke_roll = newHabit.Smoke_roll;
            _patientRegView.Smoke_describe = newHabit.Smoke_describe;
            _patientRegView.Alcohol = newHabit.Alcohol;
            _patientRegView.Alcohol_year = newHabit.Alcohol_year;
            _patientRegView.Alcohol_bottle = newHabit.Alcohol_bottle;
            _patientRegView.Kava = newHabit.Kava;
            _patientRegView.Kava_year = newHabit.Kava_year;
            _patientRegView.Kava_bottle = newHabit.Kava_bottle;
            _patientRegView.HealthyDiet = newHabit.HealthyDiet;
            _patientRegView.Exercise = newHabit.Exercise;
        }
        private Boolean IsHabitCompleted()
        {
            _patientRegView.habitErrorMessage = "";
            String error = "";
            if (String.IsNullOrEmpty(_patientRegView.Smoke_describe)) { error += "Smoking Part, "; }
            if (String.IsNullOrEmpty(error)) { return true; }
            else
            {
                // Remove substring  ", "
                error = error.Remove(error.Length - 2);
                error = error.Insert(0, "Error: ");
                error += " should be completed";
                _patientRegView.habitErrorMessage = error;
                return false;
            }
        }
        private Boolean SaveHabit()
        {
            if (IsHabitCompleted())
            {
                PopulateNewHabit();
                if (IsFirstHabit)
                {
                    RecordNewHabit();
                }
                else
                {
                    RecordOldHabit();
                }
                return true;
            }
            else { return false; }
        }
        private Boolean RecordOldHabit()
        {
            if (!newHabit.IsEqual(_habit))
            {
                _hisDataset.habitRepository.Update(newHabit, _clinic, _operator);
                return true;
            }
            return true;
        }
        private Boolean RecordNewHabit()
        {
            if (!newHabit.IsEqual(_habit))
            {
                _hisDataset.habitRepository.Create(newHabit, _clinic, _operator);
                return true;
            }
            return true;
        }
        private void PopulateNewHabit()
        {
            newHabit.SaveDate = DateTime.Today;
            newHabit.Smoke_describe = newHabit.ConvertSmokeDescribeCode(_patientRegView.Smoke_describe);
            newHabit.Smoke = newHabit.ConvertSmokeStatus(newHabit.Smoke_describe);
            newHabit.Smoke_year = (newHabit.Smoke) ? _patientRegView.Smoke_year : null;
            newHabit.Smoke_roll = (newHabit.Smoke) ? _patientRegView.Smoke_roll : null;
            newHabit.Alcohol = _patientRegView.Alcohol;
            newHabit.Alcohol_year = (newHabit.Alcohol) ? _patientRegView.Alcohol_year : null;
            newHabit.Alcohol_bottle = (newHabit.Alcohol) ? _patientRegView.Alcohol_bottle : null;
            newHabit.Kava = _patientRegView.Kava;
            newHabit.Kava_year = (newHabit.Kava) ? _patientRegView.Kava_year: null;
            newHabit.Kava_bottle = (newHabit.Kava) ? _patientRegView.Kava_bottle: "";
            newHabit.HealthyDiet = _patientRegView.HealthyDiet;
            newHabit.Exercise = _patientRegView.Exercise;
        }
        private void LoadFamily()
        {
            _patientRegView.Stroke = newFamily.Stroke;
            _patientRegView.CAD = newFamily.CAD;
            _patientRegView.MI = newFamily.MI;
            _patientRegView.DiabetesType = newFamily.DiabetesType;
            _patientRegView.Breast = newFamily.Breast;
            _patientRegView.Liver = newFamily.Liver;
            _patientRegView.Gastric = newFamily.Gastric;
            _patientRegView.Colon = newFamily.Colon;
            _patientRegView.Skin = newFamily.Skin;
            _patientRegView.Lung = newFamily.Lung;
            _patientRegView.CancerOthers = newFamily.CancerOthers;
        }
        private Boolean IsFamilyCompleted()
        {
            _patientRegView.familyErrorMessage = "";
            String error = "";
            if (_patientRegView.Diabetes)
            {
                if (String.IsNullOrEmpty(_patientRegView.DiabetesType)) { error += "Diabetes Type, "; }
            }
            if (_patientRegView.Others)
            {
                if (String.IsNullOrEmpty(_patientRegView.CancerOthers)) { error += "Textbox(Others), "; };
            }
            if (String.IsNullOrEmpty(error)) { return true; }
            else
            {
                // Remove substring  ", "
                error = error.Remove(error.Length - 2);
                error = error.Insert(0, "Error: ");
                error += " should be completed";
                _patientRegView.familyErrorMessage = error;
                return false;
            }
        }
        private Boolean SaveFamily()
        {
            if (IsFamilyCompleted())
            {
                PopulateNewFamily();
                if (IsFirstFamily)
                {
                    RecordNewFamily();
                }
                else
                {
                    RecordOldFamily();
                }
                return true;
            }
            else { return false; }
        }
        private Boolean RecordOldFamily()
        {
            if (!newFamily.IsEqual(_family))
            {
                _hisDataset.familyRepository.Update(newFamily, _clinic, _operator);
                return true;
            }
            return true;
        }
        private Boolean RecordNewFamily()
        {
            if (!newFamily.IsEqual(_family))
            {
                _hisDataset.familyRepository.Create(newFamily, _clinic, _operator);
                return true;
            }
            return true;
        }
        private void PopulateNewFamily()
        {
            newFamily.SaveDate = DateTime.Today;
            newFamily.Stroke = _patientRegView.Stroke;
            newFamily.CAD = _patientRegView.CAD;
            newFamily.MI = _patientRegView.MI;
            newFamily.DiabetesType = _patientRegView.DiabetesType;
            newFamily.Breast = _patientRegView.Breast;
            newFamily.Liver = _patientRegView.Liver;
            newFamily.Gastric = _patientRegView.Gastric;
            newFamily.Colon = _patientRegView.Colon;
            newFamily.Skin = _patientRegView.Skin;
            newFamily.Lung = _patientRegView.Lung;
            newFamily.CancerOthers = _patientRegView.CancerOthers;
        }
    }
}
