namespace YumYard
{
    partial class YumYard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YumYard));
            this.btnDineIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDineIn
            // 
            this.btnDineIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnDineIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDineIn.BackgroundImage")));
            this.btnDineIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDineIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDineIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDineIn.Location = new System.Drawing.Point(83, 406);
            this.btnDineIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDineIn.Name = "btnDineIn";
            this.btnDineIn.Size = new System.Drawing.Size(157, 71);
            this.btnDineIn.TabIndex = 0;
            this.btnDineIn.UseVisualStyleBackColor = false;
            this.btnDineIn.Click += new System.EventHandler(this.btnDineIn_Click);
            // 
            // YumYard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.btnDineIn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "YumYard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yum Yard";
            this.Load += new System.EventHandler(this.YumYard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDineIn;
    }
}

