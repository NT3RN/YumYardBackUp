namespace YumYard.Payment
{
    partial class CardPayment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCardHolder = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.tbCVV = new System.Windows.Forms.TextBox();
            this.tbExpDate = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblWcardholder = new System.Windows.Forms.Label();
            this.lblWcardNumber = new System.Windows.Forms.Label();
            this.lblWexpdate = new System.Windows.Forms.Label();
            this.lblWcvv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cardholder Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exp Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(822, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CVV";
            // 
            // tbCardHolder
            // 
            this.tbCardHolder.Location = new System.Drawing.Point(673, 153);
            this.tbCardHolder.Name = "tbCardHolder";
            this.tbCardHolder.Size = new System.Drawing.Size(214, 24);
            this.tbCardHolder.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(673, 232);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(214, 24);
            this.tbCardNumber.TabIndex = 6;
            // 
            // tbCVV
            // 
            this.tbCVV.Location = new System.Drawing.Point(825, 314);
            this.tbCVV.Name = "tbCVV";
            this.tbCVV.Size = new System.Drawing.Size(60, 24);
            this.tbCVV.TabIndex = 8;
            // 
            // tbExpDate
            // 
            this.tbExpDate.Location = new System.Drawing.Point(673, 314);
            this.tbExpDate.Name = "tbExpDate";
            this.tbExpDate.Size = new System.Drawing.Size(77, 24);
            this.tbExpDate.TabIndex = 9;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPay.Location = new System.Drawing.Point(698, 387);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(161, 41);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Make Payment";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblWcardholder
            // 
            this.lblWcardholder.AutoSize = true;
            this.lblWcardholder.BackColor = System.Drawing.Color.Transparent;
            this.lblWcardholder.ForeColor = System.Drawing.Color.Crimson;
            this.lblWcardholder.Location = new System.Drawing.Point(670, 180);
            this.lblWcardholder.Name = "lblWcardholder";
            this.lblWcardholder.Size = new System.Drawing.Size(39, 15);
            this.lblWcardholder.TabIndex = 12;
            this.lblWcardholder.Text = "label6";
            // 
            // lblWcardNumber
            // 
            this.lblWcardNumber.AutoSize = true;
            this.lblWcardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblWcardNumber.ForeColor = System.Drawing.Color.Crimson;
            this.lblWcardNumber.Location = new System.Drawing.Point(670, 259);
            this.lblWcardNumber.Name = "lblWcardNumber";
            this.lblWcardNumber.Size = new System.Drawing.Size(39, 15);
            this.lblWcardNumber.TabIndex = 13;
            this.lblWcardNumber.Text = "label6";
            // 
            // lblWexpdate
            // 
            this.lblWexpdate.AutoSize = true;
            this.lblWexpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblWexpdate.ForeColor = System.Drawing.Color.Crimson;
            this.lblWexpdate.Location = new System.Drawing.Point(670, 341);
            this.lblWexpdate.Name = "lblWexpdate";
            this.lblWexpdate.Size = new System.Drawing.Size(39, 15);
            this.lblWexpdate.TabIndex = 14;
            this.lblWexpdate.Text = "label6";
            // 
            // lblWcvv
            // 
            this.lblWcvv.AutoSize = true;
            this.lblWcvv.BackColor = System.Drawing.Color.Transparent;
            this.lblWcvv.ForeColor = System.Drawing.Color.Crimson;
            this.lblWcvv.Location = new System.Drawing.Point(822, 341);
            this.lblWcvv.Name = "lblWcvv";
            this.lblWcvv.Size = new System.Drawing.Size(39, 15);
            this.lblWcvv.TabIndex = 15;
            this.lblWcvv.Text = "label6";
            // 
            // CardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::YumYard.Properties.Resources.payment_page_bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.lblWcvv);
            this.Controls.Add(this.lblWexpdate);
            this.Controls.Add(this.lblWcardNumber);
            this.Controls.Add(this.lblWcardholder);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.tbExpDate);
            this.Controls.Add(this.tbCVV);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.tbCardHolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CardPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCardHolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.TextBox tbCVV;
        private System.Windows.Forms.TextBox tbExpDate;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblWcardholder;
        private System.Windows.Forms.Label lblWcardNumber;
        private System.Windows.Forms.Label lblWexpdate;
        private System.Windows.Forms.Label lblWcvv;
    }
}