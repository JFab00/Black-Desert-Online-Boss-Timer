
namespace WinFormsApp1
{
    partial class FormInterfaceNew
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bg = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimiseButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.bg.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bg.Controls.Add(this.panel1);
            this.bg.Location = new System.Drawing.Point(36, 22);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(322, 469);
            this.bg.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.minimiseButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 32);
            this.panel1.TabIndex = 0;
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.Transparent;
            this.minimiseButton.Font = new System.Drawing.Font("Proxima Nova Th", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimiseButton.ForeColor = System.Drawing.Color.White;
            this.minimiseButton.Location = new System.Drawing.Point(242, 0);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.minimiseButton.Size = new System.Drawing.Size(37, 32);
            this.minimiseButton.TabIndex = 0;
            this.minimiseButton.Text = "_";
            this.minimiseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Proxima Nova Th", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(285, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.closeButton.Size = new System.Drawing.Size(37, 32);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "×";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInterfaceNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 503);
            this.Controls.Add(this.bg);
            this.MinimizeBox = false;
            this.Name = "FormInterfaceNew";
            this.Text = "World Boss Timer | BDO";
            this.Load += new System.EventHandler(this.FormInterfaceNew_Load);
            this.bg.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label minimiseButton;
    }
}