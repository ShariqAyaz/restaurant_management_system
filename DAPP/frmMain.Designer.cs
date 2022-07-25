namespace DAPP
{
    partial class frmMain
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
            this.btnVPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVPay
            // 
            this.btnVPay.Location = new System.Drawing.Point(12, 12);
            this.btnVPay.Name = "btnVPay";
            this.btnVPay.Size = new System.Drawing.Size(141, 47);
            this.btnVPay.TabIndex = 0;
            this.btnVPay.Text = "Vendor Pay";
            this.btnVPay.UseVisualStyleBackColor = true;
            this.btnVPay.Click += new System.EventHandler(this.btnVPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 491);
            this.Controls.Add(this.btnVPay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVPay;
    }
}

