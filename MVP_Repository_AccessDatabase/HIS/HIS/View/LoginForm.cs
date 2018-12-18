using System;
using System.Collections.Generic;
using HIS.CustomizedToolbox;
using System.Windows.Forms;
using System.Linq;

namespace HIS.View
{
    internal partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public List<String> clinicList
        {
            set { ClinicComboBox.DataSource = value.ToList(); }
        }
        public String clinic { get { return ClinicComboBox.Text; } set { ClinicComboBox.Text = value; } }
        public String searchedUsername { get { return searchedUsernameTextBox.Text; } }
        public String searchedPswd { get { return searchedPswdTextBox.Text; } }
        public String loginMessage { set {loginMessagelabel.Text = value; }}
        public Presenter.LoginPresenter Presenter { private get; set; }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Presenter.UserLogin();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            Presenter.OnLoginFromLoad();
        }

        private void ClinicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.OnClinicIndexChanged();
        }
    }
}
