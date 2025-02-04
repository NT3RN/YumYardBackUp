namespace YumYard.Resowner
{
    partial class Owner1menu
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
            this.Menupanel = new System.Windows.Forms.Panel();
            this.btnmenurefresh = new System.Windows.Forms.Button();
            this.btnmenuupdate = new System.Windows.Forms.Button();
            this.btnmenudelete = new System.Windows.Forms.Button();
            this.btnmenuadd = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Menupanel.Location = new System.Drawing.Point(6, 575);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(10, 10);
            this.Menupanel.TabIndex = 0;
            // 
            // btnmenurefresh
            // 
            this.btnmenurefresh.BackColor = System.Drawing.Color.Blue;
            this.btnmenurefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenurefresh.Location = new System.Drawing.Point(911, 490);
            this.btnmenurefresh.Name = "btnmenurefresh";
            this.btnmenurefresh.Size = new System.Drawing.Size(72, 26);
            this.btnmenurefresh.TabIndex = 3;
            this.btnmenurefresh.Text = "Refresh ";
            this.btnmenurefresh.UseVisualStyleBackColor = false;
            this.btnmenurefresh.Visible = false;
            // 
            // btnmenuupdate
            // 
            this.btnmenuupdate.BackColor = System.Drawing.Color.Blue;
            this.btnmenuupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuupdate.Location = new System.Drawing.Point(911, 427);
            this.btnmenuupdate.Name = "btnmenuupdate";
            this.btnmenuupdate.Size = new System.Drawing.Size(72, 26);
            this.btnmenuupdate.TabIndex = 2;
            this.btnmenuupdate.Text = "Update";
            this.btnmenuupdate.UseVisualStyleBackColor = false;
            this.btnmenuupdate.Visible = false;
            // 
            // btnmenudelete
            // 
            this.btnmenudelete.BackColor = System.Drawing.Color.Blue;
            this.btnmenudelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenudelete.Location = new System.Drawing.Point(911, 348);
            this.btnmenudelete.Name = "btnmenudelete";
            this.btnmenudelete.Size = new System.Drawing.Size(72, 26);
            this.btnmenudelete.TabIndex = 1;
            this.btnmenudelete.Text = "Delete";
            this.btnmenudelete.UseVisualStyleBackColor = false;
            this.btnmenudelete.Visible = false;
            // 
            // btnmenuadd
            // 
            this.btnmenuadd.BackColor = System.Drawing.Color.Blue;
            this.btnmenuadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuadd.Location = new System.Drawing.Point(911, 281);
            this.btnmenuadd.Name = "btnmenuadd";
            this.btnmenuadd.Size = new System.Drawing.Size(72, 26);
            this.btnmenuadd.TabIndex = 0;
            this.btnmenuadd.Text = "Add ";
            this.btnmenuadd.UseVisualStyleBackColor = false;
            this.btnmenuadd.Visible = false;
            this.btnmenuadd.Click += new System.EventHandler(this.btnmenuadd_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(214, 95);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(619, 377);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.Location = new System.Drawing.Point(412, 23);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(286, 42);
            this.lblProductDetails.TabIndex = 4;
            this.lblProductDetails.Text = "Product Details";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(494, 516);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(119, 41);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // Owner1menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::YumYard.Properties.Resources.foodowner1;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.btnmenurefresh);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnmenuupdate);
            this.Controls.Add(this.Menupanel);
            this.Controls.Add(this.btnmenudelete);
            this.Controls.Add(this.btnmenuadd);
            this.Name = "Owner1menu";
            this.Text = "Owner1menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Menupanel;
        private System.Windows.Forms.Button btnmenurefresh;
        private System.Windows.Forms.Button btnmenuupdate;
        private System.Windows.Forms.Button btnmenudelete;
        private System.Windows.Forms.Button btnmenuadd;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Button btnDashboard;
    }
}