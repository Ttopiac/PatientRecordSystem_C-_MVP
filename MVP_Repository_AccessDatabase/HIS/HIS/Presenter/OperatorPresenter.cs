using HIS.View;
using HIS.Model;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HIS.Presenter
{
    public class OperatorPresenter
    {
        private IOperatorView _operatorView;
        private IHISDataset _hisDataset;
        private Operator _operator;
        private String _clinic;
        public OperatorPresenter(IOperatorView operatorView, IHISDataset hisDataset, Operator oper, String clinic)
        {
            _operatorView = operatorView;
            _operatorView.Presenter = this;
            _hisDataset = hisDataset;
            _operator = oper;
            _clinic = clinic;
        }
        #region Functions for event handlers on the view
        public void OnOperatorFormLoad()
        {
            _operatorView.infoChangedHandler = false;
            _hisDataset.profileRepository.ReloadProfiles();
            //_hisDataset.profileRepository.FilterProfiles();
            _operatorView.profilesGridDataSource =
                _hisDataset.profileRepository.filteredSimplifiedProfiles;
            SetLists();
            _operatorView.searchedFName = "";
            _operatorView.searchedSName = "";
            _operatorView.infoChangedHandler = true;
        }
        public void OnSearchedInformationChanged()
        {
            String insC = "-clear";
            if (_operatorView.searchedFName == insC ||
                _operatorView.searchedSName == insC ||
                _operatorView.searchedContact == insC)
            {
                OnOperatorFormLoad();
            }
            else
            {
                _hisDataset.profileRepository.FilterProfiles(
                   _operatorView.searchedFName,
                   _operatorView.searchedSName,
                   _operatorView.searchedGender,
                   _operatorView.searchedVillage,
                   _operatorView.searchedHIsland,
                   _operatorView.searchedReligion,
                   _operatorView.searchedContact);
                _operatorView.profilesGridDataSource = 
                    _hisDataset.profileRepository.filteredSimplifiedProfiles;
                _operatorView.PIDList = _hisDataset.profileRepository.PIDList;
                _operatorView.selectedPID = 
                    _hisDataset.profileRepository.PIDList.Count==0?
                    "" : _hisDataset.profileRepository.PIDList[0];
            }
        }
        public void OnSelectedPIDChanged()
        {
            _operatorView.selectedIndex = _hisDataset.profileRepository.PIDList.IndexOf(_operatorView.selectedPID.ToString());
        }
        public void OnProfilesDataGridViewClick()
        {
            _operatorView.selectedPID = _hisDataset.profileRepository.PIDList[_operatorView.selectedIndex];
        }
        public void PatientProfile()
        {
            var profile =
                _hisDataset.profileRepository.GetByID(Convert.ToInt64(_operatorView.selectedPID));
            var view = new View.PatientRegistryForm();
            var presenter = 
                new PatientRegistryPresenter(
                    view, _hisDataset, 
                    Convert.ToInt64(_operatorView.selectedPID), 
                    _clinic, _operator.OID);
            view.FormClosed += delegate { OnOperatorFormLoad(); };
            view.Show();
        }
        public void NewPatientProfile()
        {
            var view = new View.PatientRegistryForm();
            var presenter = 
                new PatientRegistryPresenter(
                    view, _hisDataset, _hisDataset.profileRepository.GetNewPid(),
                    _clinic, _operator.OID);
            view.FormClosed += delegate { OnOperatorFormLoad(); };
            view.Show();
        }
        public void PatientRecord()
        {
            var view = new View.RecordForm();
            view.Show();
        }
        #endregion
        private void SetLists()
        {
            _operatorView.genderList = _hisDataset.profileRepository.genderList;
            _operatorView.villageList = _hisDataset.profileRepository.villageList;
            _operatorView.hIslandList = _hisDataset.profileRepository.hIslandList;
            _operatorView.religionList = _hisDataset.profileRepository.religionList;
            _operatorView.contactList = _hisDataset.profileRepository.contactList;
            _operatorView.PIDList = _hisDataset.profileRepository.PIDList;
        }
    }
}
