using System;
using System.Collections.Generic;

namespace HIS.View
{
    public interface IPatientRegistryView
    {
        Presenter.PatientRegistryPresenter Presenter { set; }
        #region Profile Information
        Double PID { set; }
        String FName { get; set; }
        String SName { get; set; }
        String Gender { get; set; }
        String BYear { get; set; }
        String Village { get; set; }
        String HIsalnd { get; set; }
        String Religion { get; set; }
        String Marital { get; set; }
        String Occupation { get; set; }
        String Contact { get; set; }
        String Allergy { get; set; }
        List<String> genderMenu { set; }
        List<String> bYearMenu { set; }
        List<String> villageMenu { set; }
        List<String> hIslandMenu { set; }
        List<String> maritalMenu { set; }
        List<String> religionMenu { set; }
        List<String> occupationMenu { set; }
        #endregion
        #region Habit Information
        String Smoke_year { get; set; }
        String Smoke_roll { get; set; }
        String Smoke_describe { get; set; }
        Boolean Alcohol { get; set; }
        String Alcohol_year { get; set; }
        String Alcohol_bottle { get; set; }
        Boolean Kava { get; set; }
        String Kava_year { get; set; }
        String Kava_bottle { get; set; }        
        Boolean HealthyDiet { get; set; }
        Boolean Exercise { get; set; }
        List<String> yearMenu { set; }
        List<String> freqMenu { set; }
        #endregion
        #region Family Information
        Boolean Stroke { get; set; }
        Boolean CAD { get; set; }
        Boolean MI { get; set; }
        Boolean Diabetes { get; }
        String DiabetesType { get; set; }
        Boolean Breast { get; set; }
        Boolean Liver { get; set; }
        Boolean Gastric { get; set; }
        Boolean Colon { get; set; }
        Boolean Skin { get; set; }
        Boolean Lung { get; set; }
        Boolean Others { get; }
        String CancerOthers { get; set; }
        List<String> diabetesMenu { set; }
        #endregion
        #region registry message
        String profileErrorMessage { set; }
        String habitErrorMessage { set; }
        String familyErrorMessage { set; }
        #endregion
        void Close();
        Boolean IsEnabled { get; set; }
    }
}

