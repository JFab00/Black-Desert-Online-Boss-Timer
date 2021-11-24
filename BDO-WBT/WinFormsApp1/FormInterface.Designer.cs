
namespace WinFormsApp1
{
    partial class FormInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInterface));
            this.lbWorldBoss = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.pbBossImage = new System.Windows.Forms.PictureBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbConsole = new System.Windows.Forms.Label();
            this.movObj = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.Reverse = new System.Windows.Forms.Label();
            this.lbJFab = new System.Windows.Forms.Label();
            this.poweredBy = new System.Windows.Forms.Label();
            this.dragControl1 = new WinFormsApp1.DragControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBossImage)).BeginInit();
            this.movObj.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWorldBoss
            // 
            this.lbWorldBoss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWorldBoss.BackColor = System.Drawing.Color.Transparent;
            this.lbWorldBoss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbWorldBoss.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWorldBoss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWorldBoss.Location = new System.Drawing.Point(58, 318);
            this.lbWorldBoss.Name = "lbWorldBoss";
            this.lbWorldBoss.Size = new System.Drawing.Size(281, 28);
            this.lbWorldBoss.TabIndex = 0;
            this.lbWorldBoss.Tag = "WorldBossNameTag";
            this.lbWorldBoss.Text = "<World Boss Name>";
            this.lbWorldBoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWorldBoss.Click += new System.EventHandler(this.lbWorldBoss_Click);
            this.lbWorldBoss.MouseHover += new System.EventHandler(this.lbWorldBoss_MouseHover);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(312, 38);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(5, 2, 3, 5);
            this.closeButton.Size = new System.Drawing.Size(33, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Tag = "closeTag";
            this.closeButton.Text = "×";
            this.closeButton.Click += new System.EventHandler(this.close_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // pbBossImage
            // 
            this.pbBossImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBossImage.BackColor = System.Drawing.Color.Transparent;
            this.pbBossImage.Image = global::WinFormsApp1.Properties.Resources.loading;
            this.pbBossImage.Location = new System.Drawing.Point(124, 114);
            this.pbBossImage.Name = "pbBossImage";
            this.pbBossImage.Size = new System.Drawing.Size(151, 142);
            this.pbBossImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBossImage.TabIndex = 2;
            this.pbBossImage.TabStop = false;
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(110, 388);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(183, 54);
            this.lbTimer.TabIndex = 3;
            this.lbTimer.Text = "00:00:00";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbConsole
            // 
            this.lbConsole.AutoSize = true;
            this.lbConsole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbConsole.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConsole.Location = new System.Drawing.Point(47, 336);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(0, 19);
            this.lbConsole.TabIndex = 4;
            // 
            // movObj
            // 
            this.movObj.BackgroundImage = global::WinFormsApp1.Properties.Resources.boss_ui;
            this.movObj.Controls.Add(this.minimizeButton);
            this.movObj.Controls.Add(this.Reverse);
            this.movObj.Controls.Add(this.lbJFab);
            this.movObj.Controls.Add(this.poweredBy);
            this.movObj.Controls.Add(this.lbWorldBoss);
            this.movObj.Controls.Add(this.lbTimer);
            this.movObj.Controls.Add(this.closeButton);
            this.movObj.Controls.Add(this.pbBossImage);
            this.movObj.Dock = System.Windows.Forms.DockStyle.Top;
            this.movObj.Location = new System.Drawing.Point(0, 0);
            this.movObj.Name = "movObj";
            this.movObj.Size = new System.Drawing.Size(393, 505);
            this.movObj.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(56, 38);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(9, 2, 7, 5);
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.TabIndex = 7;
            this.minimizeButton.Tag = "minimizeTag";
            this.minimizeButton.Text = "_";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            // 
            // Reverse
            // 
            this.Reverse.BackColor = System.Drawing.Color.Transparent;
            this.Reverse.Image = global::WinFormsApp1.Properties.Resources.reverse;
            this.Reverse.Location = new System.Drawing.Point(63, 120);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(37, 34);
            this.Reverse.TabIndex = 6;
            this.Reverse.Tag = "ReverseTag";
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            this.Reverse.MouseHover += new System.EventHandler(this.Reverse_MouseHover);
            // 
            // lbJFab
            // 
            this.lbJFab.AutoSize = true;
            this.lbJFab.BackColor = System.Drawing.Color.Transparent;
            this.lbJFab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbJFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbJFab.ForeColor = System.Drawing.Color.White;
            this.lbJFab.Location = new System.Drawing.Point(209, 460);
            this.lbJFab.Name = "lbJFab";
            this.lbJFab.Size = new System.Drawing.Size(38, 15);
            this.lbJFab.TabIndex = 5;
            this.lbJFab.Text = "JFab";
            this.lbJFab.Click += new System.EventHandler(this.lbJFab_Click);
            // 
            // poweredBy
            // 
            this.poweredBy.AutoSize = true;
            this.poweredBy.BackColor = System.Drawing.Color.Transparent;
            this.poweredBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.poweredBy.ForeColor = System.Drawing.Color.White;
            this.poweredBy.Location = new System.Drawing.Point(141, 460);
            this.poweredBy.Name = "poweredBy";
            this.poweredBy.Size = new System.Drawing.Size(70, 15);
            this.poweredBy.TabIndex = 4;
            this.poweredBy.Text = "powered by";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.movObj;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 503);
            this.Controls.Add(this.lbConsole);
            this.Controls.Add(this.movObj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormInterface";
            this.Text = "World Boss Timer | BDO";
            this.Resize += new System.EventHandler(this.FormInterface_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbBossImage)).EndInit();
            this.movObj.ResumeLayout(false);
            this.movObj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbWorldBoss;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox pbBossImage;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbConsole;
        private System.Windows.Forms.Panel movObj;
        private DragControl dragControl1;
        private System.Windows.Forms.Label lbJFab;
        private System.Windows.Forms.Label poweredBy;
        private System.Windows.Forms.Label Reverse;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

