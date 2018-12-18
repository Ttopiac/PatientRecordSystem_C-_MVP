using HIS.View;
using HIS.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HIS.Presenter
{
    public class LoginPresenter
    {
        private ILoginView _loginView;
        private IHISDataset _hisDataset;
        public LoginPresenter(ILoginView loginView, IHISDataset hisDataset)
        {
            _loginView = loginView;
            _loginView.Presenter = this;
            _hisDataset = hisDataset;
        }
        #region Functions for event handlers on the view
        public void OnLoginFromLoad()
        {
            String originalClinic = _hisDataset.system_InfoRepository.GetById(0).Clinic;
            List<String> _clinicList = _hisDataset.clinicRepository.clinicNameList;
            _clinicList.Add("");
            _loginView.clinicList = _clinicList;
            _loginView.clinic = originalClinic;
        }
        public void OnClinicIndexChanged()
        {
            System_Info sys_Info = _hisDataset.system_InfoRepository.GetById(0);
            sys_Info.Clinic = _loginView.clinic;
            _hisDataset.system_InfoRepository.Update(sys_Info);
            _hisDataset.Commit();
        }
        public void UserLogin()
        {
            if (_loginView.clinic == "")
            {
                _loginView.loginMessage = "Please Choose The Clinic You Want To LOGIN";
                return;
            }
            if (String.IsNullOrEmpty(_loginView.searchedUsername) || String.IsNullOrEmpty(_loginView.searchedPswd))
            {
                _loginView.loginMessage = "Need More Infomation To LOGIN";
                return;
            }
            Operator op = (_hisDataset.operatorRepository).GetByUsernameAndPswd(_loginView.searchedUsername, _loginView.searchedPswd);
            if (op == null)
            {
                _loginView.loginMessage = "LOGIN Failure";
                return;
            }
            op.LastLogin = DateTime.Today;
            _hisDataset.operatorRepository.Update(op);
            _hisDataset.Commit();
            op = _hisDataset.operatorRepository.GetById(op.OID);
            _loginView.loginMessage = "";
            var view = new View.OperatorForm();
            var presenter = new OperatorPresenter(view, _hisDataset, op, _loginView.clinic);
            view.FormClosed += delegate { _loginView.Show(); };
            view.Show();
            _loginView.Hide();
        }
        #endregion
    }
}
