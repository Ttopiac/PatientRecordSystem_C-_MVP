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
    public partial class PatientRegistryForm : Form, IPatientRegistryView
    {
        public PatientRegistryForm()
        {
            InitializeComponent();
        }
        public Presenter.PatientRegistryPresenter Presenter { private get; set; }
        public Boolean IsEnabled { get { return this.Enabled; } set { this.Enabled = value; } }
        #region Profile Information
        public Double PID { set { PIDTextBox.Text = value.ToString(); } }
        public String FName { get { return FNameTextBox.Text; } set { FNameTextBox.Text = value; } }
        public String SName { get { return SNameTextBox.Text; } set { SNameTextBox.Text = value; } }
        public String Gender { get { return genderComboBox.Text; } set { genderComboBox.Text = value; } }
        public String BYear { get { return BYearComboBox.Text; } set { BYearComboBox.Text = value; } }
        public String Village { get { return villageComboBox.Text; } set { villageComboBox.Text = value; } }
        public String HIsalnd { get { return HIslandComboBox.Text; } set { HIslandComboBox.Text = value; } }
        public String Religion { get { return religionComboBox.Text; } set { religionComboBox.Text = value; } }
        public String Marital { get { return maritalComboBox.Text; } set { maritalComboBox.Text = value; } }
        public String Occupation { get { return occupationComboBox.Text; } set { occupationComboBox.Text = value; } }
        public String Contact { get { return contactTextBox.Text; } set { contactTextBox.Text = value; } }
        public String Allergy { get { return allergyTextBox.Text; } set { allergyTextBox.Text = value; } }
        public List<String> genderMenu { set { genderComboBox.DataSource = value.ToList(); } }
        public List<String> bYearMenu { set { BYearComboBox.DataSource = value.ToList(); } }
        public List<String> villageMenu { set { villageComboBox.DataSource = value.ToList(); } }
        public List<String> hIslandMenu { set { HIslandComboBox.DataSource = value.ToList(); } }
        public List<String> maritalMenu { set { maritalComboBox.DataSource = value.ToList(); } }
        public List<String> religionMenu { set { religionComboBox.DataSource = value.ToList(); } }
        public List<String> occupationMenu { set { occupationComboBox.DataSource = value.ToList(); } }
        #endregion
        #region Habit Information
        public String Smoke_year { get { return SmokingYearComboBox.Text; } set { SmokingYearComboBox.Text = value; } }
        public String Smoke_roll { get { return SmokingFreqComboBox.Text; } set { SmokingFreqComboBox.Text = value; } }
        public String Smoke_describe
        {
            get
            {
                var checkedButton = SmokingFlowLayoutPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                if (checkedButton != null) { return checkedButton.Text; }
                else { return null; }
            }
            set
            {
                switch (value)
                {
                    case "A":
                        smokingARadioButton.Checked = true;
                        break;
                    case "B":
                        smokingBRadioButton.Checked = true;
                        break;
                    case "C":
                        smokingCRadioButton.Checked = true;
                        break;
                    case "D":
                        smokingDRadioButton.Checked = true;
                        break;
                    case "E":
                        smokingERadioButton.Checked = true;
                        break;
                }
            }
        }
        public Boolean Alcohol { get { return AlcoholIntakeCheckBox.Checked; } set { AlcoholIntakeCheckBox.Checked = value; } }
        public String Alcohol_year { get { return AlcoholYearComboBox.Text; } set { AlcoholYearComboBox.Text = value; } }
        public String Alcohol_bottle { get { return AlcoholFreqComboBox.Text; } set { AlcoholFreqComboBox.Text = value; } }
        public Boolean Kava { get { return KavaIntakeCheckBox.Checked; } set { KavaIntakeCheckBox.Checked = value; } }
        public String Kava_year { get { return KavaYearComboBox.Text; } set { KavaYearComboBox.Text = value; } }
        public String Kava_bottle { get { return KavaFreqComboBox.Text; } set { KavaFreqComboBox.Text = value; } }
        public Boolean HealthyDiet { get { return HealthyDietCheckBox.Checked; } set { HealthyDietCheckBox.Checked = value; } }
        public Boolean Exercise { get { return ExerciseCheckBox.Checked; } set { ExerciseCheckBox.Checked = value; } }
        public List<String> yearMenu
        {
            set
            {
                SmokingYearComboBox.DataSource = value.ToList();
                AlcoholYearComboBox.DataSource = value.ToList();
                KavaYearComboBox.DataSource = value.ToList();
            }
        }
        public List<String> freqMenu
        {
            set
            {
                SmokingFreqComboBox.DataSource = value.ToList();
                AlcoholFreqComboBox.DataSource = value.ToList();
                KavaFreqComboBox.DataSource = value.ToList();
            }
        }
        #endregion
        #region Family Information
        public Boolean Stroke { get{ return StrokeCheckBox.Checked; } set { StrokeCheckBox.Checked = value; } }
        public Boolean CAD { get { return CADCheckBox.Checked; } set { CADCheckBox.Checked = value; } }
        public Boolean MI { get { return MICheckBox.Checked; } set { MICheckBox.Checked = value; } }
        public Boolean Diabetes { get { return diabetesCheckBox.Checked; } }
        public String DiabetesType
        {
            get { return diabtesTypeComboBox.Text; }
            set
            {
                diabetesCheckBox.Checked = !(String.IsNullOrEmpty(value));
                diabtesTypeComboBox.Text = value;
            }
        }
        public Boolean Breast { get { return breastCheckBox.Checked; } set { breastCheckBox.Checked = value; } }
        public Boolean Liver { get { return liverCheckBox.Checked; } set { breastCheckBox.Checked = value; } }
        public Boolean Gastric { get { return gastricCheckBox.Checked; } set { gastricCheckBox.Checked = value; } }
        public Boolean Colon { get { return colonCheckBox.Checked; } set { colonCheckBox.Checked = value; } }
        public Boolean Skin { get { return skinCheckBox.Checked; } set { skinCheckBox.Checked = value; } }
        public Boolean Lung { get { return lungCheckBox.Checked; } set { lungCheckBox.Checked = value; } }
        public Boolean Others { get { return othersCheckBox.Checked; } } 
        public String CancerOthers
        {
            get { return othersTextBox.Text; }
            set
            {
                othersCheckBox.Checked = !String.IsNullOrEmpty(value);
                othersTextBox.Text = value;
            }
        }
        public List<String> diabetesMenu { set { diabtesTypeComboBox.DataSource = value.ToList(); } }
        #endregion
        #region registry message
        public String profileErrorMessage
        {
            set
            {
                ProfileErrorMessageLabel.Text = value;
                if (String.IsNullOrEmpty(value)){ ProfileErrorMessageLabel.Visible = false; }
                else { ProfileErrorMessageLabel.Visible = true; }
            }
        }
        public String habitErrorMessage
        {
            set
            {
                HabitErrorMessageLabel.Text = value;
                if (String.IsNullOrEmpty(value)) { HabitErrorMessageLabel.Visible = false; }
                else { HabitErrorMessageLabel.Visible = true; }
            }
        }
        public String familyErrorMessage
        {
            set
            {
                FamilyErrorMessageLabel.Text = value;
                if (String.IsNullOrEmpty(value)) { FamilyErrorMessageLabel.Visible = false; }
                else { FamilyErrorMessageLabel.Visible = true; }
            }
        }
        #endregion
        private void PatientRegistryForm_Load(object sender, EventArgs e)
        {
            Presenter.OnPatientRegistryFormLoad();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Presenter.Save();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Presenter.Close();
        }

        private void PatientRegistryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(Presenter.Close());
        }

        private void smokingNo_CheckedChanged(object sender, EventArgs e)
        {
            smokeDetailPanel.Visible = false;
        }

        private void smokingYes_CheckedChanged(object sender, EventArgs e)
        {
            smokeDetailPanel.Visible = true;
        }

        private void AlcoholIntakeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            alcoholDetailPanel.Visible = AlcoholIntakeCheckBox.Checked;
        }

        private void KavaIntakeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            KavaDetailPanel.Visible = KavaIntakeCheckBox.Checked;
        }

        private void BYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.SetHabitYearMenu();
        }

        private void diabetesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (! diabetesCheckBox.Checked){ diabtesTypeComboBox.Text = ""; }
            diabetesPanel.Visible = diabetesCheckBox.Checked;
        }

        private void othersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!othersCheckBox.Checked) { othersTextBox.Text = ""; }
            othersTextBox.Visible = othersCheckBox.Checked;
        }
    }
}
