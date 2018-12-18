namespace HIS.View
{
    partial class LoginForm
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
            this.searchedUsernameTextBox = new CueTextBox();
            this.searchedPswdTextBox = new CueTextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.loginMessagelabel = new System.Windows.Forms.Label();
            this.ClinicComboBox = new System.Windows.Forms.ComboBox();
            this.ClinicLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchedUsernameTextBox
            // 
            this.searchedUsernameTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchedUsernameTextBox.Cue = "Username";
            this.searchedUsernameTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedUsernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchedUsernameTextBox.Location = new System.Drawing.Point(354, 356);
            this.searchedUsernameTextBox.Name = "searchedUsernameTextBox";
            this.searchedUsernameTextBox.Size = new System.Drawing.Size(559, 47);
            this.searchedUsernameTextBox.TabIndex = 2;
            // 
            // searchedPswdTextBox
            // 
            this.searchedPswdTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchedPswdTextBox.Cue = "Password";
            this.searchedPswdTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedPswdTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchedPswdTextBox.Location = new System.Drawing.Point(354, 428);
            this.searchedPswdTextBox.Name = "searchedPswdTextBox";
            this.searchedPswdTextBox.PasswordChar = '*';
            this.searchedPswdTextBox.Size = new System.Drawing.Size(559, 47);
            this.searchedPswdTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Coral;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.BorderSize = 2;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(354, 500);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(560, 48);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(88, 100);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1191, 109);
            this.TitleLabel.TabIndex = 100;
            this.TitleLabel.Text = "Health Information System";
            // 
            // loginMessagelabel
            // 
            this.loginMessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMessagelabel.ForeColor = System.Drawing.Color.Red;
            this.loginMessagelabel.Location = new System.Drawing.Point(933, 517);
            this.loginMessagelabel.Name = "loginMessagelabel";
            this.loginMessagelabel.Size = new System.Drawing.Size(314, 130);
            this.loginMessagelabel.TabIndex = 101;
            this.loginMessagelabel.Text = "                    ";
            // 
            // ClinicComboBox
            // 
            this.ClinicComboBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClinicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClinicComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClinicComboBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F);
            this.ClinicComboBox.ForeColor = System.Drawing.Color.Black;
            this.ClinicComboBox.FormattingEnabled = true;
            this.ClinicComboBox.Location = new System.Drawing.Point(498, 284);
            this.ClinicComboBox.Name = "ClinicComboBox";
            this.ClinicComboBox.Size = new System.Drawing.Size(415, 49);
            this.ClinicComboBox.TabIndex = 102;
            this.ClinicComboBox.SelectedIndexChanged += new System.EventHandler(this.ClinicComboBox_SelectedIndexChanged);
            // 
            // ClinicLabel
            // 
            this.ClinicLabel.AutoSize = true;
            this.ClinicLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClinicLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClinicLabel.Location = new System.Drawing.Point(355, 286);
            this.ClinicLabel.Name = "ClinicLabel";
            this.ClinicLabel.Size = new System.Drawing.Size(137, 47);
            this.ClinicLabel.TabIndex = 103;
            this.ClinicLabel.Text = "Clinic:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 692);
            this.Controls.Add(this.ClinicLabel);
            this.Controls.Add(this.ClinicComboBox);
            this.Controls.Add(this.loginMessagelabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.searchedPswdTextBox);
            this.Controls.Add(this.searchedUsernameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox searchedUsernameTextBox;
        private CueTextBox searchedPswdTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label loginMessagelabel;
        private System.Windows.Forms.ComboBox ClinicComboBox;
        private System.Windows.Forms.Label ClinicLabel;
    }
}