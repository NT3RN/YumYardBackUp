namespace YumYard.Customer.Forms
{
    partial class UserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnHidePass = new System.Windows.Forms.Button();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblWarnNPass = new System.Windows.Forms.Label();
            this.lblWarnCPass = new System.Windows.Forms.Label();
            this.lblWarnEmail = new System.Windows.Forms.Label();
            this.lblWarnUN = new System.Windows.Forms.Label();
            this.lblWarnID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbCurrPass = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(391, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 35);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPass.Location = new System.Drawing.Point(601, 220);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(75, 23);
            this.btnShowPass.TabIndex = 45;
            this.btnShowPass.Text = "Show";
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnHidePass
            // 
            this.btnHidePass.BackColor = System.Drawing.SystemColors.Control;
            this.btnHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHidePass.Location = new System.Drawing.Point(601, 220);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(75, 23);
            this.btnHidePass.TabIndex = 44;
            this.btnHidePass.Text = "Hide";
            this.btnHidePass.UseVisualStyleBackColor = false;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFemale.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.rbtnFemale.Location = new System.Drawing.Point(491, 183);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(78, 22);
            this.rbtnFemale.TabIndex = 43;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = false;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMale.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(386, 183);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(60, 22);
            this.rbtnMale.TabIndex = 42;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = false;
            // 
            // lblWarnNPass
            // 
            this.lblWarnNPass.AutoSize = true;
            this.lblWarnNPass.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnNPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnNPass.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnNPass.Location = new System.Drawing.Point(383, 301);
            this.lblWarnNPass.Name = "lblWarnNPass";
            this.lblWarnNPass.Size = new System.Drawing.Size(39, 15);
            this.lblWarnNPass.TabIndex = 41;
            this.lblWarnNPass.Text = "label1";
            // 
            // lblWarnCPass
            // 
            this.lblWarnCPass.AutoSize = true;
            this.lblWarnCPass.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnCPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnCPass.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnCPass.Location = new System.Drawing.Point(383, 246);
            this.lblWarnCPass.Name = "lblWarnCPass";
            this.lblWarnCPass.Size = new System.Drawing.Size(39, 15);
            this.lblWarnCPass.TabIndex = 40;
            this.lblWarnCPass.Text = "label1";
            // 
            // lblWarnEmail
            // 
            this.lblWarnEmail.AutoSize = true;
            this.lblWarnEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnEmail.Location = new System.Drawing.Point(383, 158);
            this.lblWarnEmail.Name = "lblWarnEmail";
            this.lblWarnEmail.Size = new System.Drawing.Size(39, 15);
            this.lblWarnEmail.TabIndex = 39;
            this.lblWarnEmail.Text = "label1";
            // 
            // lblWarnUN
            // 
            this.lblWarnUN.AutoSize = true;
            this.lblWarnUN.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnUN.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnUN.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnUN.Location = new System.Drawing.Point(383, 108);
            this.lblWarnUN.Name = "lblWarnUN";
            this.lblWarnUN.Size = new System.Drawing.Size(39, 15);
            this.lblWarnUN.TabIndex = 38;
            this.lblWarnUN.Text = "label1";
            // 
            // lblWarnID
            // 
            this.lblWarnID.AutoSize = true;
            this.lblWarnID.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnID.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnID.Location = new System.Drawing.Point(383, 62);
            this.lblWarnID.Name = "lblWarnID";
            this.lblWarnID.Size = new System.Drawing.Size(39, 15);
            this.lblWarnID.TabIndex = 37;
            this.lblWarnID.Text = "label1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(228, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 35);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(386, 278);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(183, 20);
            this.tbNewPass.TabIndex = 35;
            // 
            // tbCurrPass
            // 
            this.tbCurrPass.Location = new System.Drawing.Point(386, 223);
            this.tbCurrPass.Name = "tbCurrPass";
            this.tbCurrPass.PasswordChar = '*';
            this.tbCurrPass.Size = new System.Drawing.Size(183, 20);
            this.tbCurrPass.TabIndex = 34;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(386, 135);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(183, 20);
            this.tbEmail.TabIndex = 33;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(386, 85);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(183, 20);
            this.tbUserName.TabIndex = 32;
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.Color.Khaki;
            this.tbUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserID.Enabled = false;
            this.tbUserID.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.Location = new System.Drawing.Point(386, 35);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.ReadOnly = true;
            this.tbUserID.Size = new System.Drawing.Size(183, 17);
            this.tbUserID.TabIndex = 31;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(160, 183);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 23);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(160, 273);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(157, 23);
            this.lblNewPass.TabIndex = 29;
            this.lblNewPass.Text = "New Password";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPass.Location = new System.Drawing.Point(160, 220);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(192, 23);
            this.lblCurrentPass.TabIndex = 28;
            this.lblCurrentPass.Text = "Current Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(160, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(119, 23);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "User Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(160, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 23);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "User Name";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(160, 32);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(84, 23);
            this.lblUserID.TabIndex = 25;
            this.lblUserID.Text = "User ID";
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(840, 455);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnHidePass);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.lblWarnNPass);
            this.Controls.Add(this.lblWarnCPass);
            this.Controls.Add(this.lblWarnEmail);
            this.Controls.Add(this.lblWarnUN);
            this.Controls.Add(this.lblWarnID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbCurrPass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnHidePass;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblWarnNPass;
        private System.Windows.Forms.Label lblWarnCPass;
        private System.Windows.Forms.Label lblWarnEmail;
        private System.Windows.Forms.Label lblWarnUN;
        private System.Windows.Forms.Label lblWarnID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbCurrPass;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserID;
    }
}