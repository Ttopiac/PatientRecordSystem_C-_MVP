namespace HIS.View
{
    partial class OperatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OperatortabControl = new System.Windows.Forms.TabControl();
            this.PatientSearchTabPage = new System.Windows.Forms.TabPage();
            this.NewPatientButton = new System.Windows.Forms.Button();
            this.ProfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.profileButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.selectedPIDComboBox = new System.Windows.Forms.ComboBox();
            this.PIDLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.religionLabel = new System.Windows.Forms.Label();
            this.HIslandLabel = new System.Windows.Forms.Label();
            this.villageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.searchedContactComboBox = new System.Windows.Forms.ComboBox();
            this.searchedReligionComboBox = new System.Windows.Forms.ComboBox();
            this.searchedHIslandComboBox = new System.Windows.Forms.ComboBox();
            this.searchedVillageComboBox = new System.Windows.Forms.ComboBox();
            this.searchedGenderComboBox = new System.Windows.Forms.ComboBox();
            this.searchedSNameTextBox = new CueTextBox();
            this.searchedFNameTextBox = new CueTextBox();
            this.ReportTabPage = new System.Windows.Forms.TabPage();
            this.OperatortabControl.SuspendLayout();
            this.PatientSearchTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilesDataGridView)).BeginInit();
            this.SearchOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperatortabControl
            // 
            this.OperatortabControl.Controls.Add(this.PatientSearchTabPage);
            this.OperatortabControl.Controls.Add(this.ReportTabPage);
            this.OperatortabControl.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatortabControl.ItemSize = new System.Drawing.Size(670, 42);
            this.OperatortabControl.Location = new System.Drawing.Point(-5, 0);
            this.OperatortabControl.Margin = new System.Windows.Forms.Padding(0);
            this.OperatortabControl.Name = "OperatortabControl";
            this.OperatortabControl.Padding = new System.Drawing.Point(0, 0);
            this.OperatortabControl.SelectedIndex = 0;
            this.OperatortabControl.Size = new System.Drawing.Size(1354, 690);
            this.OperatortabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.OperatortabControl.TabIndex = 0;
            // 
            // PatientSearchTabPage
            // 
            this.PatientSearchTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PatientSearchTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PatientSearchTabPage.Controls.Add(this.NewPatientButton);
            this.PatientSearchTabPage.Controls.Add(this.ProfilesDataGridView);
            this.PatientSearchTabPage.Controls.Add(this.SearchOptionsGroupBox);
            this.PatientSearchTabPage.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientSearchTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PatientSearchTabPage.Location = new System.Drawing.Point(4, 46);
            this.PatientSearchTabPage.Name = "PatientSearchTabPage";
            this.PatientSearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PatientSearchTabPage.Size = new System.Drawing.Size(1346, 640);
            this.PatientSearchTabPage.TabIndex = 0;
            this.PatientSearchTabPage.Text = "Patient Search";
            // 
            // NewPatientButton
            // 
            this.NewPatientButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewPatientButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewPatientButton.FlatAppearance.BorderSize = 2;
            this.NewPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPatientButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPatientButton.ForeColor = System.Drawing.Color.White;
            this.NewPatientButton.Location = new System.Drawing.Point(955, 195);
            this.NewPatientButton.Name = "NewPatientButton";
            this.NewPatientButton.Size = new System.Drawing.Size(147, 40);
            this.NewPatientButton.TabIndex = 118;
            this.NewPatientButton.Text = "New Patient";
            this.NewPatientButton.UseVisualStyleBackColor = false;
            this.NewPatientButton.Click += new System.EventHandler(this.NewPatientButton_Click);
            // 
            // ProfilesDataGridView
            // 
            this.ProfilesDataGridView.AllowUserToAddRows = false;
            this.ProfilesDataGridView.AllowUserToDeleteRows = false;
            this.ProfilesDataGridView.AllowUserToOrderColumns = true;
            this.ProfilesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ProfilesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProfilesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfilesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProfilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProfilesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProfilesDataGridView.Location = new System.Drawing.Point(6, 248);
            this.ProfilesDataGridView.Name = "ProfilesDataGridView";
            this.ProfilesDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfilesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProfilesDataGridView.RowHeadersVisible = false;
            this.ProfilesDataGridView.Size = new System.Drawing.Size(1096, 379);
            this.ProfilesDataGridView.TabIndex = 1;
            this.ProfilesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfilesDataGridView_CellClick);
            // 
            // SearchOptionsGroupBox
            // 
            this.SearchOptionsGroupBox.Controls.Add(this.profileButton);
            this.SearchOptionsGroupBox.Controls.Add(this.clearButton);
            this.SearchOptionsGroupBox.Controls.Add(this.goButton);
            this.SearchOptionsGroupBox.Controls.Add(this.selectedPIDComboBox);
            this.SearchOptionsGroupBox.Controls.Add(this.PIDLabel);
            this.SearchOptionsGroupBox.Controls.Add(this.contactLabel);
            this.SearchOptionsGroupBox.Controls.Add(this.religionLabel);
            this.SearchOptionsGroupBox.Controls.Add(this.HIslandLabel);
            this.SearchOptionsGroupBox.Controls.Add(this.villageLabel);
            this.SearchOptionsGroupBox.Controls.Add(this.genderLabel);
            this.SearchOptionsGroupBox.Controls.Add(this.searchedContactComboBox);
            this.SearchOptionsGroupBox.Controls.Add(this.searchedReligionComboBox);
            this.SearchOptionsGroupBox.Controls.Add(this.searchedHIslandComboBox);
            this.SearchOptionsGroupBox.Controls.Add(this.searchedVillageComboBox);
            this.SearchOptionsGroupBox.Controls.Add(this.searchedGenderComboBox);
            this.SearchOptionsGroupBox.Controls.Add(this.searchedSNameTextBox);
            this.SearchOptionsGroupBox.Controls.Add(this.searchedFNameTextBox);
            this.SearchOptionsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.SearchOptionsGroupBox.Name = "SearchOptionsGroupBox";
            this.SearchOptionsGroupBox.Size = new System.Drawing.Size(917, 236);
            this.SearchOptionsGroupBox.TabIndex = 0;
            this.SearchOptionsGroupBox.TabStop = false;
            this.SearchOptionsGroupBox.Text = "Searched Options";
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.profileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileButton.FlatAppearance.BorderSize = 2;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.Navy;
            this.profileButton.Location = new System.Drawing.Point(741, 189);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(81, 40);
            this.profileButton.TabIndex = 118;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Navy;
            this.clearButton.Location = new System.Drawing.Point(666, 189);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(69, 40);
            this.clearButton.TabIndex = 117;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.goButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.goButton.FlatAppearance.BorderSize = 2;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.ForeColor = System.Drawing.Color.Navy;
            this.goButton.Location = new System.Drawing.Point(828, 189);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(80, 40);
            this.goButton.TabIndex = 116;
            this.goButton.Text = "GO !";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // selectedPIDComboBox
            // 
            this.selectedPIDComboBox.BackColor = System.Drawing.Color.Silver;
            this.selectedPIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedPIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedPIDComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPIDComboBox.ForeColor = System.Drawing.Color.Black;
            this.selectedPIDComboBox.FormattingEnabled = true;
            this.selectedPIDComboBox.Location = new System.Drawing.Point(638, 27);
            this.selectedPIDComboBox.Name = "selectedPIDComboBox";
            this.selectedPIDComboBox.Size = new System.Drawing.Size(270, 30);
            this.selectedPIDComboBox.TabIndex = 115;
            this.selectedPIDComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedPIDComboBox_SelectedIndexChanged);
            // 
            // PIDLabel
            // 
            this.PIDLabel.BackColor = System.Drawing.Color.Salmon;
            this.PIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIDLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDLabel.Location = new System.Drawing.Point(581, 27);
            this.PIDLabel.Name = "PIDLabel";
            this.PIDLabel.Size = new System.Drawing.Size(51, 30);
            this.PIDLabel.TabIndex = 114;
            this.PIDLabel.Text = "PID";
            this.PIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactLabel
            // 
            this.contactLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.contactLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(394, 170);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(180, 26);
            this.contactLabel.TabIndex = 113;
            this.contactLabel.Text = "Contact Number";
            this.contactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // religionLabel
            // 
            this.religionLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.religionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.religionLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.religionLabel.Location = new System.Drawing.Point(20, 170);
            this.religionLabel.Name = "religionLabel";
            this.religionLabel.Size = new System.Drawing.Size(112, 26);
            this.religionLabel.TabIndex = 112;
            this.religionLabel.Text = "Religion";
            this.religionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HIslandLabel
            // 
            this.HIslandLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.HIslandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HIslandLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HIslandLabel.Location = new System.Drawing.Point(488, 91);
            this.HIslandLabel.Name = "HIslandLabel";
            this.HIslandLabel.Size = new System.Drawing.Size(145, 26);
            this.HIslandLabel.TabIndex = 111;
            this.HIslandLabel.Text = "Home Island";
            this.HIslandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // villageLabel
            // 
            this.villageLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.villageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.villageLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villageLabel.Location = new System.Drawing.Point(157, 91);
            this.villageLabel.Name = "villageLabel";
            this.villageLabel.Size = new System.Drawing.Size(99, 26);
            this.villageLabel.TabIndex = 110;
            this.villageLabel.Text = "Village";
            this.villageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderLabel
            // 
            this.genderLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.genderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genderLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(20, 91);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(87, 26);
            this.genderLabel.TabIndex = 108;
            this.genderLabel.Text = "Gender";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchedContactComboBox
            // 
            this.searchedContactComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchedContactComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchedContactComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedContactComboBox.ForeColor = System.Drawing.Color.Black;
            this.searchedContactComboBox.FormattingEnabled = true;
            this.searchedContactComboBox.Location = new System.Drawing.Point(394, 199);
            this.searchedContactComboBox.Name = "searchedContactComboBox";
            this.searchedContactComboBox.Size = new System.Drawing.Size(266, 30);
            this.searchedContactComboBox.TabIndex = 107;
            this.searchedContactComboBox.SelectedIndexChanged += new System.EventHandler(this.searchedOptions_TextChanged);
            // 
            // searchedReligionComboBox
            // 
            this.searchedReligionComboBox.BackColor = System.Drawing.Color.Silver;
            this.searchedReligionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchedReligionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchedReligionComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedReligionComboBox.ForeColor = System.Drawing.Color.Black;
            this.searchedReligionComboBox.FormattingEnabled = true;
            this.searchedReligionComboBox.Location = new System.Drawing.Point(20, 199);
            this.searchedReligionComboBox.Name = "searchedReligionComboBox";
            this.searchedReligionComboBox.Size = new System.Drawing.Size(364, 30);
            this.searchedReligionComboBox.TabIndex = 106;
            this.searchedReligionComboBox.SelectedIndexChanged += new System.EventHandler(this.searchedOptions_TextChanged);
            // 
            // searchedHIslandComboBox
            // 
            this.searchedHIslandComboBox.BackColor = System.Drawing.Color.Silver;
            this.searchedHIslandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchedHIslandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchedHIslandComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedHIslandComboBox.ForeColor = System.Drawing.Color.Black;
            this.searchedHIslandComboBox.FormattingEnabled = true;
            this.searchedHIslandComboBox.Location = new System.Drawing.Point(488, 120);
            this.searchedHIslandComboBox.Name = "searchedHIslandComboBox";
            this.searchedHIslandComboBox.Size = new System.Drawing.Size(420, 30);
            this.searchedHIslandComboBox.TabIndex = 105;
            this.searchedHIslandComboBox.SelectedIndexChanged += new System.EventHandler(this.searchedOptions_TextChanged);
            // 
            // searchedVillageComboBox
            // 
            this.searchedVillageComboBox.BackColor = System.Drawing.Color.Silver;
            this.searchedVillageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchedVillageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchedVillageComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedVillageComboBox.ForeColor = System.Drawing.Color.Black;
            this.searchedVillageComboBox.FormattingEnabled = true;
            this.searchedVillageComboBox.Location = new System.Drawing.Point(157, 120);
            this.searchedVillageComboBox.Name = "searchedVillageComboBox";
            this.searchedVillageComboBox.Size = new System.Drawing.Size(321, 30);
            this.searchedVillageComboBox.TabIndex = 104;
            this.searchedVillageComboBox.SelectedIndexChanged += new System.EventHandler(this.searchedOptions_TextChanged);
            // 
            // searchedGenderComboBox
            // 
            this.searchedGenderComboBox.BackColor = System.Drawing.Color.Silver;
            this.searchedGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchedGenderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchedGenderComboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedGenderComboBox.ForeColor = System.Drawing.Color.Black;
            this.searchedGenderComboBox.FormattingEnabled = true;
            this.searchedGenderComboBox.Location = new System.Drawing.Point(20, 120);
            this.searchedGenderComboBox.Name = "searchedGenderComboBox";
            this.searchedGenderComboBox.Size = new System.Drawing.Size(127, 30);
            this.searchedGenderComboBox.TabIndex = 103;
            this.searchedGenderComboBox.SelectedIndexChanged += new System.EventHandler(this.searchedOptions_TextChanged);
            // 
            // searchedSNameTextBox
            // 
            this.searchedSNameTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchedSNameTextBox.Cue = "Surname";
            this.searchedSNameTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F);
            this.searchedSNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchedSNameTextBox.Location = new System.Drawing.Point(300, 25);
            this.searchedSNameTextBox.Name = "searchedSNameTextBox";
            this.searchedSNameTextBox.Size = new System.Drawing.Size(274, 47);
            this.searchedSNameTextBox.TabIndex = 4;
            this.searchedSNameTextBox.TextChanged += new System.EventHandler(this.searchedOptions_TextChanged);
            // 
            // searchedFNameTextBox
            // 
            this.searchedFNameTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchedFNameTextBox.Cue = "First Name";
            this.searchedFNameTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F);
            this.searchedFNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchedFNameTextBox.Location = new System.Drawing.Point(20, 25);
            this.searchedFNameTextBox.Name = "searchedFNameTextBox";
            this.searchedFNameTextBox.Size = new System.Drawing.Size(274, 47);
            this.searchedFNameTextBox.TabIndex = 3;
            this.searchedFNameTextBox.TextChanged += new System.EventHandler(this.searchedOptions_TextChanged);
            // 
            // ReportTabPage
            // 
            this.ReportTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReportTabPage.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTabPage.Location = new System.Drawing.Point(4, 46);
            this.ReportTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.ReportTabPage.Name = "ReportTabPage";
            this.ReportTabPage.Size = new System.Drawing.Size(1346, 640);
            this.ReportTabPage.TabIndex = 1;
            this.ReportTabPage.Text = "Report";
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 692);
            this.Controls.Add(this.OperatortabControl);
            this.Name = "OperatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperatorForm";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.OperatortabControl.ResumeLayout(false);
            this.PatientSearchTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilesDataGridView)).EndInit();
            this.SearchOptionsGroupBox.ResumeLayout(false);
            this.SearchOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OperatortabControl;
        private System.Windows.Forms.TabPage PatientSearchTabPage;
        private System.Windows.Forms.TabPage ReportTabPage;
        private System.Windows.Forms.GroupBox SearchOptionsGroupBox;
        private System.Windows.Forms.DataGridView ProfilesDataGridView;
        private CueTextBox searchedFNameTextBox;
        private CueTextBox searchedSNameTextBox;
        private System.Windows.Forms.ComboBox searchedReligionComboBox;
        private System.Windows.Forms.ComboBox searchedHIslandComboBox;
        private System.Windows.Forms.ComboBox searchedVillageComboBox;
        private System.Windows.Forms.ComboBox searchedGenderComboBox;
        private System.Windows.Forms.ComboBox searchedContactComboBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label religionLabel;
        private System.Windows.Forms.Label HIslandLabel;
        private System.Windows.Forms.Label villageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label PIDLabel;
        private System.Windows.Forms.ComboBox selectedPIDComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button NewPatientButton;
        private System.Windows.Forms.Button profileButton;
    }
}