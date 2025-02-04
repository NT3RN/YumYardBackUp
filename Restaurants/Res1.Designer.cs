namespace YumYard.Restaurants
{
    partial class Res1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Res1));
            this.panelCustomerSide = new System.Windows.Forms.Panel();
            this.btnOrderInfo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelRes = new System.Windows.Forms.Panel();
            this.panelCustomerSide.SuspendLayout();
            this.panelTopbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCustomerSide
            // 
            this.panelCustomerSide.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panelCustomerSide.Controls.Add(this.btnOrderInfo);
            this.panelCustomerSide.Controls.Add(this.btnHome);
            this.panelCustomerSide.Controls.Add(this.panelLogo);
            this.panelCustomerSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCustomerSide.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCustomerSide.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerSide.Name = "panelCustomerSide";
            this.panelCustomerSide.Size = new System.Drawing.Size(200, 594);
            this.panelCustomerSide.TabIndex = 51;
            // 
            // btnOrderInfo
            // 
            this.btnOrderInfo.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrderInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOrderInfo.Image = global::YumYard.Properties.Resources.icons8_shopping_cart_48;
            this.btnOrderInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderInfo.Location = new System.Drawing.Point(0, 201);
            this.btnOrderInfo.Name = "btnOrderInfo";
            this.btnOrderInfo.Size = new System.Drawing.Size(200, 101);
            this.btnOrderInfo.TabIndex = 2;
            this.btnOrderInfo.Text = "Orders";
            this.btnOrderInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderInfo.UseVisualStyleBackColor = false;
            this.btnOrderInfo.Click += new System.EventHandler(this.btnOrderInfo_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Goldenrod;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHome.Image = global::YumYard.Properties.Resources.icons8_home_50;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 101);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Gray;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTopbar
            // 
            this.panelTopbar.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTopbar.Controls.Add(this.lblTitle);
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopbar.Location = new System.Drawing.Point(200, 0);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(856, 100);
            this.panelTopbar.TabIndex = 52;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Linen;
            this.lblTitle.Location = new System.Drawing.Point(323, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // panelRes
            // 
            this.panelRes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelRes.Location = new System.Drawing.Point(202, 104);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(853, 489);
            this.panelRes.TabIndex = 53;
            // 
            // Res1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.panelTopbar);
            this.Controls.Add(this.panelCustomerSide);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Res1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salsa n Spice";
            this.panelCustomerSide.ResumeLayout(false);
            this.panelTopbar.ResumeLayout(false);
            this.panelTopbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCustomerSide;
        private System.Windows.Forms.Button btnOrderInfo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelRes;
    }
}