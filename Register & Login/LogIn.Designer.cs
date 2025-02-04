namespace YumYard.Register___Login
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.btnClickHere = new System.Windows.Forms.Button();
            this.btnHidePass = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.lblWarnEmail = new System.Windows.Forms.Label();
            this.lblWarnPass = new System.Windows.Forms.Label();
            this.lblF_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(120, 215);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(120, 277);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(107, 23);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmail.Location = new System.Drawing.Point(259, 218);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(187, 20);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(259, 277);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(187, 20);
            this.tbPass.TabIndex = 3;
            this.tbPass.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Location = new System.Drawing.Point(234, 364);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(142, 41);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.Location = new System.Drawing.Point(120, 469);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(153, 23);
            this.lblReg.TabIndex = 6;
            this.lblReg.Text = "Not registered?";
            // 
            // btnClickHere
            // 
            this.btnClickHere.BackColor = System.Drawing.Color.SpringGreen;
            this.btnClickHere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClickHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClickHere.FlatAppearance.BorderSize = 0;
            this.btnClickHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickHere.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickHere.Location = new System.Drawing.Point(279, 464);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(115, 35);
            this.btnClickHere.TabIndex = 7;
            this.btnClickHere.Text = "Click Here";
            this.btnClickHere.UseVisualStyleBackColor = false;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // btnHidePass
            // 
            this.btnHidePass.BackColor = System.Drawing.SystemColors.Control;
            this.btnHidePass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHidePass.Location = new System.Drawing.Point(465, 275);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(75, 23);
            this.btnHidePass.TabIndex = 18;
            this.btnHidePass.Text = "Hide";
            this.btnHidePass.UseVisualStyleBackColor = false;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPass.Location = new System.Drawing.Point(465, 274);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(75, 23);
            this.btnShowPass.TabIndex = 19;
            this.btnShowPass.Text = "Show";
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // lblWarnEmail
            // 
            this.lblWarnEmail.AutoSize = true;
            this.lblWarnEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnEmail.Location = new System.Drawing.Point(256, 250);
            this.lblWarnEmail.Name = "lblWarnEmail";
            this.lblWarnEmail.Size = new System.Drawing.Size(39, 15);
            this.lblWarnEmail.TabIndex = 20;
            this.lblWarnEmail.Text = "label1";
            // 
            // lblWarnPass
            // 
            this.lblWarnPass.AutoSize = true;
            this.lblWarnPass.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnPass.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnPass.Location = new System.Drawing.Point(256, 309);
            this.lblWarnPass.Name = "lblWarnPass";
            this.lblWarnPass.Size = new System.Drawing.Size(39, 15);
            this.lblWarnPass.TabIndex = 21;
            this.lblWarnPass.Text = "label2";
            // 
            // lblF_pass
            // 
            this.lblF_pass.AutoSize = true;
            this.lblF_pass.BackColor = System.Drawing.Color.Transparent;
            this.lblF_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblF_pass.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF_pass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblF_pass.Location = new System.Drawing.Point(230, 419);
            this.lblF_pass.Name = "lblF_pass";
            this.lblF_pass.Size = new System.Drawing.Size(164, 20);
            this.lblF_pass.TabIndex = 22;
            this.lblF_pass.Text = "Forgot password?";
            this.lblF_pass.Click += new System.EventHandler(this.lblF_pass_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.lblF_pass);
            this.Controls.Add(this.lblWarnPass);
            this.Controls.Add(this.lblWarnEmail);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnHidePass);
            this.Controls.Add(this.btnClickHere);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Button btnHidePass;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Label lblWarnEmail;
        private System.Windows.Forms.Label lblWarnPass;
        private System.Windows.Forms.Label lblF_pass;
    }
}