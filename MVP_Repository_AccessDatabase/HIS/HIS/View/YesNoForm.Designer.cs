namespace HIS.View
{
    partial class YesNoForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Black;
            this.messageLabel.Location = new System.Drawing.Point(3, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(447, 48);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Do you want to Save Data?";
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yesButton.FlatAppearance.BorderSize = 2;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F);
            this.yesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yesButton.Location = new System.Drawing.Point(262, 60);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(86, 48);
            this.yesButton.TabIndex = 117;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noButton.FlatAppearance.BorderSize = 2;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F);
            this.noButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.noButton.Location = new System.Drawing.Point(354, 60);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(86, 48);
            this.noButton.TabIndex = 118;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // YesNoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(452, 119);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.messageLabel);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "YesNoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YesNoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}