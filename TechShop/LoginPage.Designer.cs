namespace TechShop
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccountSettingsBtn = new System.Windows.Forms.Button();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UserAccountNumberLabel = new System.Windows.Forms.Label();
            this.RememberUserCheckbox = new System.Windows.Forms.CheckBox();
            this.LogUserInBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UserAccInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccountSettingsBtn
            // 
            this.AccountSettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.AccountSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountSettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSettingsBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccountSettingsBtn.Location = new System.Drawing.Point(304, 321);
            this.AccountSettingsBtn.Name = "AccountSettingsBtn";
            this.AccountSettingsBtn.Size = new System.Drawing.Size(92, 31);
            this.AccountSettingsBtn.TabIndex = 19;
            this.AccountSettingsBtn.Text = "Settings";
            this.AccountSettingsBtn.UseVisualStyleBackColor = false;
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserPasswordLabel.Location = new System.Drawing.Point(124, 147);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(111, 17);
            this.UserPasswordLabel.TabIndex = 18;
            this.UserPasswordLabel.Text = "User Password :";
            // 
            // UserAccountNumberLabel
            // 
            this.UserAccountNumberLabel.AutoSize = true;
            this.UserAccountNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserAccountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccountNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserAccountNumberLabel.Location = new System.Drawing.Point(124, 47);
            this.UserAccountNumberLabel.Name = "UserAccountNumberLabel";
            this.UserAccountNumberLabel.Size = new System.Drawing.Size(155, 17);
            this.UserAccountNumberLabel.TabIndex = 17;
            this.UserAccountNumberLabel.Text = "User Account Number :";
            // 
            // RememberUserCheckbox
            // 
            this.RememberUserCheckbox.AutoSize = true;
            this.RememberUserCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.RememberUserCheckbox.Checked = true;
            this.RememberUserCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RememberUserCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberUserCheckbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RememberUserCheckbox.Location = new System.Drawing.Point(127, 266);
            this.RememberUserCheckbox.Name = "RememberUserCheckbox";
            this.RememberUserCheckbox.Size = new System.Drawing.Size(127, 21);
            this.RememberUserCheckbox.TabIndex = 16;
            this.RememberUserCheckbox.Text = "Remember Me?";
            this.RememberUserCheckbox.UseVisualStyleBackColor = false;
            // 
            // LogUserInBtn
            // 
            this.LogUserInBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogUserInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogUserInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogUserInBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogUserInBtn.Location = new System.Drawing.Point(304, 266);
            this.LogUserInBtn.Name = "LogUserInBtn";
            this.LogUserInBtn.Size = new System.Drawing.Size(92, 31);
            this.LogUserInBtn.TabIndex = 15;
            this.LogUserInBtn.Text = "Log In";
            this.LogUserInBtn.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(127, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(269, 32);
            this.textBox2.TabIndex = 14;
            // 
            // UserAccInput
            // 
            this.UserAccInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserAccInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccInput.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UserAccInput.Location = new System.Drawing.Point(127, 81);
            this.UserAccInput.Name = "UserAccInput";
            this.UserAccInput.Size = new System.Drawing.Size(269, 32);
            this.UserAccInput.TabIndex = 13;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.AccountSettingsBtn);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserAccountNumberLabel);
            this.Controls.Add(this.RememberUserCheckbox);
            this.Controls.Add(this.LogUserInBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UserAccInput);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(521, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AccountSettingsBtn;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.Label UserAccountNumberLabel;
        private System.Windows.Forms.CheckBox RememberUserCheckbox;
        private System.Windows.Forms.Button LogUserInBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox UserAccInput;
    }
}
