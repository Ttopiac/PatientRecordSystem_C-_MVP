using HIS.View;
using HIS.Model;
using System;
using System.Collections.Generic;

namespace HIS.Presenter
{
    public class RecordPresenter
    {
        private IRecordView _recordView;
        private IHISDataset _hisDataset;   
        private String _clinic;
        private Int32 _operator;
        private Profile _profile;
        public RecordPresenter(IRecordView recordView, IHISDataset hisDataset, Double pid, String clinic, Int32 oper)
        {
            _recordView = recordView;
            _recordView.Presenter = this;
            _hisDataset = hisDataset;
            SetProfile(pid);
        }
        #region Functions for event handlers on the view
        public void OnLoginFromLoad()
        {
            
        }
        #endregion
        #region Presenter Actions
        private void SetProfile(Double pid)
        {
            _profile = _hisDataset.profileRepository.GetByID(pid);
        }
        private void LoadProfile()
        {
            _recordView.PID = _profile.PID;
            _recordView.FullName = _profile.FName + " " + _profile.SName;
            _recordView.Gender = _profile.Gender;
            _recordView.age = Convert.ToUInt16(DateTime.Today.Year - _profile.BYear);
            _recordView.Allergy = _profile.Allergy;
        }
        #endregion
    }
}
