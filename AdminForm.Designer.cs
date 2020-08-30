namespace EHR
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnDoctors = new Telerik.WinControls.UI.RadButton();
            this.btnLogins = new Telerik.WinControls.UI.RadButton();
            this.btnUsers = new Telerik.WinControls.UI.RadButton();
            this.btnDashboard = new Telerik.WinControls.UI.RadButton();
            this.adminPanelContainer = new Telerik.WinControls.UI.RadPanel();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminPanelContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnDoctors);
            this.radPanel1.Controls.Add(this.btnLogins);
            this.radPanel1.Controls.Add(this.btnUsers);
            this.radPanel1.Controls.Add(this.btnDashboard);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(979, 35);
            this.radPanel1.TabIndex = 0;
            // 
            // btnDoctors
            // 
            this.btnDoctors.Location = new System.Drawing.Point(737, 3);
            this.btnDoctors.MinimumSize = new System.Drawing.Size(166, 29);
            this.btnDoctors.Name = "btnDoctors";
            // 
            // 
            // 
            this.btnDoctors.RootElement.MinSize = new System.Drawing.Size(166, 29);
            this.btnDoctors.Size = new System.Drawing.Size(232, 29);
            this.btnDoctors.TabIndex = 1;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.ThemeName = "CrystalDark";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnLogins
            // 
            this.btnLogins.Location = new System.Drawing.Point(495, 3);
            this.btnLogins.MinimumSize = new System.Drawing.Size(166, 29);
            this.btnLogins.Name = "btnLogins";
            // 
            // 
            // 
            this.btnLogins.RootElement.MinSize = new System.Drawing.Size(166, 29);
            this.btnLogins.Size = new System.Drawing.Size(232, 29);
            this.btnLogins.TabIndex = 1;
            this.btnLogins.Text = "LogIns";
            this.btnLogins.ThemeName = "CrystalDark";
            this.btnLogins.Click += new System.EventHandler(this.btnLogins_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(253, 3);
            this.btnUsers.MinimumSize = new System.Drawing.Size(166, 29);
            this.btnUsers.Name = "btnUsers";
            // 
            // 
            // 
            this.btnUsers.RootElement.MinSize = new System.Drawing.Size(166, 29);
            this.btnUsers.Size = new System.Drawing.Size(232, 29);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.ThemeName = "CrystalDark";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(10, 3);
            this.btnDashboard.MinimumSize = new System.Drawing.Size(166, 29);
            this.btnDashboard.Name = "btnDashboard";
            // 
            // 
            // 
            this.btnDashboard.RootElement.MinSize = new System.Drawing.Size(166, 29);
            this.btnDashboard.Size = new System.Drawing.Size(232, 29);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.ThemeName = "CrystalDark";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // adminPanelContainer
            // 
            this.adminPanelContainer.AutoSize = true;
            this.adminPanelContainer.Location = new System.Drawing.Point(0, 35);
            this.adminPanelContainer.MinimumSize = new System.Drawing.Size(979, 522);
            this.adminPanelContainer.Name = "adminPanelContainer";
            // 
            // 
            // 
            this.adminPanelContainer.RootElement.MinSize = new System.Drawing.Size(979, 522);
            this.adminPanelContainer.Size = new System.Drawing.Size(979, 522);
            this.adminPanelContainer.TabIndex = 1;
            this.adminPanelContainer.ThemeName = "CrystalDark";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 561);
            this.Controls.Add(this.adminPanelContainer);
            this.Controls.Add(this.radPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(987, 591);
            this.Name = "AdminForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.ThemeName = "CrystalDark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminPanelContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnDoctors;
        private Telerik.WinControls.UI.RadButton btnLogins;
        private Telerik.WinControls.UI.RadButton btnUsers;
        private Telerik.WinControls.UI.RadButton btnDashboard;
        private Telerik.WinControls.UI.RadPanel adminPanelContainer;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
    }
}
