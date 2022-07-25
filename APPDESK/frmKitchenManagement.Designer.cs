namespace APPDESK
{
    partial class frmKitchenManagement
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbProcess = new System.Windows.Forms.TabPage();
            this.flpInProcess = new System.Windows.Forms.FlowLayoutPanel();
            this.tbComplete = new System.Windows.Forms.TabPage();
            this.flpCompleted = new System.Windows.Forms.FlowLayoutPanel();
            this.flpNew = new System.Windows.Forms.FlowLayoutPanel();
            this.tbNEW = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbProcess.SuspendLayout();
            this.tbComplete.SuspendLayout();
            this.tbNEW.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbNEW);
            this.tabControl1.Controls.Add(this.tbProcess);
            this.tabControl1.Controls.Add(this.tbComplete);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(987, 448);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tbProcess
            // 
            this.tbProcess.AutoScroll = true;
            this.tbProcess.BackColor = System.Drawing.Color.White;
            this.tbProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcess.Controls.Add(this.flpInProcess);
            this.tbProcess.Location = new System.Drawing.Point(4, 42);
            this.tbProcess.Name = "tbProcess";
            this.tbProcess.Padding = new System.Windows.Forms.Padding(1);
            this.tbProcess.Size = new System.Drawing.Size(979, 402);
            this.tbProcess.TabIndex = 0;
            this.tbProcess.Text = "IN PROCESS";
            // 
            // flpInProcess
            // 
            this.flpInProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpInProcess.AutoScroll = true;
            this.flpInProcess.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.flpInProcess.AutoScrollMinSize = new System.Drawing.Size(200, 200);
            this.flpInProcess.AutoSize = true;
            this.flpInProcess.BackColor = System.Drawing.Color.White;
            this.flpInProcess.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInProcess.Location = new System.Drawing.Point(1, 1);
            this.flpInProcess.Name = "flpInProcess";
            this.flpInProcess.Size = new System.Drawing.Size(975, 398);
            this.flpInProcess.TabIndex = 0;
            this.flpInProcess.SizeChanged += new System.EventHandler(this.flpInProcess_SizeChanged);
            // 
            // tbComplete
            // 
            this.tbComplete.AutoScroll = true;
            this.tbComplete.BackColor = System.Drawing.Color.White;
            this.tbComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbComplete.Controls.Add(this.flpCompleted);
            this.tbComplete.Location = new System.Drawing.Point(4, 42);
            this.tbComplete.Name = "tbComplete";
            this.tbComplete.Padding = new System.Windows.Forms.Padding(1);
            this.tbComplete.Size = new System.Drawing.Size(979, 402);
            this.tbComplete.TabIndex = 1;
            this.tbComplete.Text = "COMPLETED";
            // 
            // flpCompleted
            // 
            this.flpCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCompleted.AutoScroll = true;
            this.flpCompleted.BackColor = System.Drawing.Color.White;
            this.flpCompleted.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCompleted.Location = new System.Drawing.Point(1, 1);
            this.flpCompleted.Name = "flpCompleted";
            this.flpCompleted.Size = new System.Drawing.Size(975, 398);
            this.flpCompleted.TabIndex = 1;
            // 
            // flpNew
            // 
            this.flpNew.AutoScroll = true;
            this.flpNew.AutoSize = true;
            this.flpNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpNew.BackColor = System.Drawing.Color.White;
            this.flpNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNew.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNew.Location = new System.Drawing.Point(1, 1);
            this.flpNew.Name = "flpNew";
            this.flpNew.Size = new System.Drawing.Size(977, 400);
            this.flpNew.TabIndex = 1;
            // 
            // tbNEW
            // 
            this.tbNEW.AutoScroll = true;
            this.tbNEW.BackColor = System.Drawing.Color.White;
            this.tbNEW.Controls.Add(this.flpNew);
            this.tbNEW.Location = new System.Drawing.Point(4, 42);
            this.tbNEW.Name = "tbNEW";
            this.tbNEW.Padding = new System.Windows.Forms.Padding(1);
            this.tbNEW.Size = new System.Drawing.Size(979, 402);
            this.tbNEW.TabIndex = 2;
            this.tbNEW.Text = "NEW ORDERS";
            // 
            // frmKitchenManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmKitchenManagement";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "KITCHEN ORDER MANAGER";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKitchenManagement_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tbProcess.ResumeLayout(false);
            this.tbProcess.PerformLayout();
            this.tbComplete.ResumeLayout(false);
            this.tbNEW.ResumeLayout(false);
            this.tbNEW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbProcess;
        private System.Windows.Forms.TabPage tbComplete;
        private System.Windows.Forms.FlowLayoutPanel flpInProcess;
        private System.Windows.Forms.FlowLayoutPanel flpCompleted;
        private System.Windows.Forms.TabPage tbNEW;
        private System.Windows.Forms.FlowLayoutPanel flpNew;
    }
}