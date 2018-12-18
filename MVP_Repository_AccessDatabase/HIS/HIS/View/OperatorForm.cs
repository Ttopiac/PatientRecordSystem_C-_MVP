using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.View
{
    public partial class OperatorForm : Form, IOperatorView
    {
        public OperatorForm()
        {
            InitializeComponent();
        }
        #region parameters
        public Object profilesGridDataSource{ set { ProfilesDataGridView.DataSource = value; } }
        public Presenter.OperatorPresenter Presenter { private get; set; }
        public String searchedFName {
            get { return searchedFNameTextBox.Text; }
            set { searchedFNameTextBox.Text = value; }
        }
        public String searchedSName {
            get { return searchedSNameTextBox.Text; }
            set { searchedSNameTextBox.Text = value; }
        }
        public String searchedGender { get { return searchedGenderComboBox.Text; } }
        public String searchedVillage { get { return searchedVillageComboBox.Text; } }
        public String searchedHIsland { get { return searchedHIslandComboBox.Text; } }
        public String searchedReligion { get { return searchedReligionComboBox.Text; } }
        public String searchedContact { get { return searchedContactComboBox.Text; } }
        public String selectedPID
        {
            get { return selectedPIDComboBox.Text; }
            set { selectedPIDComboBox.Text = value.ToString(); }
        }
        public Int32 selectedIndex
        {
            get { return ProfilesDataGridView.CurrentCell.RowIndex; }
            set
            {
                ProfilesDataGridView.ClearSelection();
                ProfilesDataGridView.CurrentCell = ProfilesDataGridView.Rows[value].Cells[0];
                ProfilesDataGridView.Rows[value].Selected = true;
                ProfilesDataGridView.FirstDisplayedCell = ProfilesDataGridView.Rows[value].Cells[0]; 
            }
        }
        public Object selectedProfile
        {
            get { return ProfilesDataGridView.SelectedRows; }
        }
        public List<String> genderList { set { searchedGenderComboBox.DataSource = value.ToList(); } }
        public List<String> villageList { set { searchedVillageComboBox.DataSource = value.ToList(); } }
        public List<String> hIslandList { set { searchedHIslandComboBox.DataSource = value.ToList(); } }
        public List<String> religionList { set { searchedReligionComboBox.DataSource = value.ToList(); } }
        public List<String> contactList { set { searchedContactComboBox.DataSource = value.ToList(); } }
        public List<String> PIDList { set { selectedPIDComboBox.DataSource = value.ToList(); } }
        public Boolean infoChangedHandler {
            set {
                if (value)
                {
                    selectedPIDComboBox.SelectedIndexChanged += selectedPIDComboBox_SelectedIndexChanged;
                    searchedFNameTextBox.TextChanged += searchedOptions_TextChanged;
                    searchedSNameTextBox.TextChanged += searchedOptions_TextChanged;
                    searchedGenderComboBox.SelectedIndexChanged += searchedOptions_TextChanged;
                    searchedVillageComboBox.SelectedIndexChanged += searchedOptions_TextChanged;
                    searchedHIslandComboBox.SelectedIndexChanged += searchedOptions_TextChanged;
                    searchedReligionComboBox.SelectedIndexChanged += searchedOptions_TextChanged;
                    searchedContactComboBox.SelectedIndexChanged += searchedOptions_TextChanged;                    
                }
                else
                {
                    selectedPIDComboBox.SelectedIndexChanged -= selectedPIDComboBox_SelectedIndexChanged;
                    searchedFNameTextBox.TextChanged -= searchedOptions_TextChanged;
                    searchedSNameTextBox.TextChanged -= searchedOptions_TextChanged;
                    searchedGenderComboBox.SelectedIndexChanged -= searchedOptions_TextChanged;
                    searchedVillageComboBox.SelectedIndexChanged -= searchedOptions_TextChanged;
                    searchedHIslandComboBox.SelectedIndexChanged -= searchedOptions_TextChanged;
                    searchedReligionComboBox.SelectedIndexChanged -= searchedOptions_TextChanged;
                    searchedContactComboBox.SelectedIndexChanged -= searchedOptions_TextChanged;
                }
            }
        }
        #endregion
        #region Event Handler
        private void OperatorForm_Load(object sender, EventArgs e)
        {
            Presenter.OnOperatorFormLoad();
        }
        private void searchedOptions_TextChanged(object sender, EventArgs e)
        {
            Presenter.OnSearchedInformationChanged();
        }
        private void selectedPIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.OnSelectedPIDChanged();
        }
        private void ProfilesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Presenter.OnProfilesDataGridViewClick();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            Presenter.OnOperatorFormLoad();
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            Presenter.PatientRecord();
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            Presenter.PatientProfile();
        }
        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            Presenter.NewPatientProfile();
        }
        #endregion


    }
}
