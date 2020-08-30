namespace EHR
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.btnPatients = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnTreat = new Telerik.WinControls.UI.RadButton();
            this.btnAddPatient = new Telerik.WinControls.UI.RadButton();
            this.btnScan = new Telerik.WinControls.UI.RadButton();
            this.crystalDarkTheme2 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.doctorPanelContainer = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTreat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPanelContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatients
            // 
            this.btnPatients.Location = new System.Drawing.Point(737, 3);
            this.btnPatients.MinimumSize = new System.Drawing.Size(166, 29);
            this.btnPatients.Name = "btnPatients";
            // 
            // 
            // 
            this.btnPatients.RootElement.MinSize = new System.Drawing.Size(166, 29);
            this.btnPatients.Size = new System.Drawing.Size(232, 29);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.ThemeName = "CrystalDark";
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnPatients);
            this.radPanel1.Controls.Add(this.btnTreat);
            this.radPanel1.Controls.Add(this.btnAddPatient);
            this.radPanel1.Controls.Add(this.btnScan);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(979, 35);
            this.radPanel1.TabIndex = 2;
            // 
            // btnTreat
            // 
            this.btnTreat.Location = new System.Drawing.Point(495, 3);
            this.btnTreat.MinimumSize = new System.Drawing.Size(166, 29);
            this.btnTreat.Name = "btnTreat";
            // 
            // 
            // 
            this.btnTreat.RootElement.MinSize = new System.Drawing.Size(166, 29);
            this.btnTreat.Size = new System.Drawing.Size(232, 29);
            this.btnTreat.TabIndex = 1;
            this.btnTreat.Text = "Treat Patient";
            this.btnTreat.ThemeName = "CrystalDark";
            this.btnTreat.Click += new System.EventHandler(this.btnTreat_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(253, 3);
            this.btnAddPatient.MinimumSize = new System.Drawing.Size(166, 29);
            this.btnAddPatient.Name = "btnAddPatient";
            // 
            // 
            // 
            this.btnAddPatient.RootElement.MinSize = new System.Drawing.Size(166, 29);
            this.btnAddPatient.Size = new System.Drawing.Size(232, 29);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Add New Patient";
            this.btnAddPatient.ThemeName = "CrystalDark";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(10, 3);
            this.btnScan.MinimumSize = new System.Drawing.Size(166, 29);
            this.btnScan.Name = "btnScan";
            // 
            // 
            // 
            this.btnScan.RootElement.MinSize = new System.Drawing.Size(166, 29);
            this.btnScan.Size = new System.Drawing.Size(232, 29);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan QR Code";
            this.btnScan.ThemeName = "CrystalDark";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // doctorPanelContainer
            // 
            this.doctorPanelContainer.AutoSize = true;
            this.doctorPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorPanelContainer.Location = new System.Drawing.Point(0, 35);
            this.doctorPanelContainer.MinimumSize = new System.Drawing.Size(979, 522);
            this.doctorPanelContainer.Name = "doctorPanelContainer";
            // 
            // 
            // 
            this.doctorPanelContainer.RootElement.MinSize = new System.Drawing.Size(979, 522);
            this.doctorPanelContainer.Size = new System.Drawing.Size(979, 522);
            this.doctorPanelContainer.TabIndex = 3;
            this.doctorPanelContainer.ThemeName = "CrystalDark";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 556);
            this.Controls.Add(this.doctorPanelContainer);
            this.Controls.Add(this.radPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(987, 591);
            this.Name = "DoctorForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Panel";
            this.ThemeName = "CrystalDark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.btnPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTreat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPanelContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.UI.RadButton btnPatients;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnTreat;
        private Telerik.WinControls.UI.RadButton btnAddPatient;
        private Telerik.WinControls.UI.RadButton btnScan;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme2;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadPanel doctorPanelContainer;
    }
}
