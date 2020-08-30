namespace EHR
{
    partial class ScanControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnTreat = new Telerik.WinControls.UI.RadButton();
            this.txtPtPhone = new System.Windows.Forms.TextBox();
            this.txtPtAllergies = new System.Windows.Forms.TextBox();
            this.txtPtEmail = new System.Windows.Forms.TextBox();
            this.txtPtAddress = new System.Windows.Forms.TextBox();
            this.txtPtName = new System.Windows.Forms.TextBox();
            this.txtPtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPtMeds = new System.Windows.Forms.RichTextBox();
            this.txtPtIll = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTreat)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(16, 12);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(370, 21);
            this.cboDevice.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(16, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(370, 340);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(133, 428);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 24);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.ThemeName = "CrystalDark";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.txtPtIll);
            this.radPanel1.Controls.Add(this.txtPtMeds);
            this.radPanel1.Controls.Add(this.btnTreat);
            this.radPanel1.Controls.Add(this.txtPtPhone);
            this.radPanel1.Controls.Add(this.txtPtAllergies);
            this.radPanel1.Controls.Add(this.txtPtEmail);
            this.radPanel1.Controls.Add(this.txtPtAddress);
            this.radPanel1.Controls.Add(this.txtPtName);
            this.radPanel1.Controls.Add(this.txtPtAge);
            this.radPanel1.Controls.Add(this.label8);
            this.radPanel1.Controls.Add(this.label9);
            this.radPanel1.Controls.Add(this.label4);
            this.radPanel1.Controls.Add(this.label5);
            this.radPanel1.Controls.Add(this.label6);
            this.radPanel1.Controls.Add(this.label3);
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Location = new System.Drawing.Point(405, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(559, 498);
            this.radPanel1.TabIndex = 5;
            // 
            // btnTreat
            // 
            this.btnTreat.Location = new System.Drawing.Point(435, 467);
            this.btnTreat.Name = "btnTreat";
            this.btnTreat.Size = new System.Drawing.Size(110, 24);
            this.btnTreat.TabIndex = 5;
            this.btnTreat.Text = "Treat Patient";
            this.btnTreat.ThemeName = "CrystalDark";
            this.btnTreat.Click += new System.EventHandler(this.btnTreat_Click);
            // 
            // txtPtPhone
            // 
            this.txtPtPhone.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPtPhone.Location = new System.Drawing.Point(202, 183);
            this.txtPtPhone.Name = "txtPtPhone";
            this.txtPtPhone.ReadOnly = true;
            this.txtPtPhone.Size = new System.Drawing.Size(343, 23);
            this.txtPtPhone.TabIndex = 81;
            // 
            // txtPtAllergies
            // 
            this.txtPtAllergies.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtAllergies.ForeColor = System.Drawing.Color.Black;
            this.txtPtAllergies.Location = new System.Drawing.Point(201, 227);
            this.txtPtAllergies.Multiline = true;
            this.txtPtAllergies.Name = "txtPtAllergies";
            this.txtPtAllergies.ReadOnly = true;
            this.txtPtAllergies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPtAllergies.Size = new System.Drawing.Size(343, 69);
            this.txtPtAllergies.TabIndex = 80;
            // 
            // txtPtEmail
            // 
            this.txtPtEmail.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtPtEmail.Location = new System.Drawing.Point(202, 97);
            this.txtPtEmail.Name = "txtPtEmail";
            this.txtPtEmail.ReadOnly = true;
            this.txtPtEmail.Size = new System.Drawing.Size(343, 23);
            this.txtPtEmail.TabIndex = 79;
            // 
            // txtPtAddress
            // 
            this.txtPtAddress.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtPtAddress.Location = new System.Drawing.Point(201, 138);
            this.txtPtAddress.Name = "txtPtAddress";
            this.txtPtAddress.ReadOnly = true;
            this.txtPtAddress.Size = new System.Drawing.Size(343, 23);
            this.txtPtAddress.TabIndex = 78;
            // 
            // txtPtName
            // 
            this.txtPtName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtName.ForeColor = System.Drawing.Color.Black;
            this.txtPtName.Location = new System.Drawing.Point(202, 18);
            this.txtPtName.Name = "txtPtName";
            this.txtPtName.ReadOnly = true;
            this.txtPtName.Size = new System.Drawing.Size(343, 23);
            this.txtPtName.TabIndex = 77;
            // 
            // txtPtAge
            // 
            this.txtPtAge.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtAge.ForeColor = System.Drawing.Color.Black;
            this.txtPtAge.Location = new System.Drawing.Point(201, 56);
            this.txtPtAge.Name = "txtPtAge";
            this.txtPtAge.ReadOnly = true;
            this.txtPtAge.Size = new System.Drawing.Size(343, 23);
            this.txtPtAge.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Previous Illnesses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 16);
            this.label9.TabIndex = 74;
            this.label9.Text = "Previous Medications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Allergies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Patient T.P. no:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Patient Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Patient E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Patient Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Patient Name";
            // 
            // txtPtMeds
            // 
            this.txtPtMeds.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtMeds.Location = new System.Drawing.Point(202, 302);
            this.txtPtMeds.Name = "txtPtMeds";
            this.txtPtMeds.ReadOnly = true;
            this.txtPtMeds.Size = new System.Drawing.Size(342, 76);
            this.txtPtMeds.TabIndex = 82;
            this.txtPtMeds.Text = "";
            // 
            // txtPtIll
            // 
            this.txtPtIll.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtIll.Location = new System.Drawing.Point(202, 384);
            this.txtPtIll.Name = "txtPtIll";
            this.txtPtIll.ReadOnly = true;
            this.txtPtIll.Size = new System.Drawing.Size(342, 71);
            this.txtPtIll.TabIndex = 83;
            this.txtPtIll.Text = "";
            // 
            // ScanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cboDevice);
            this.MinimumSize = new System.Drawing.Size(979, 522);
            this.Name = "ScanControl";
            this.Size = new System.Drawing.Size(979, 522);
            this.Load += new System.EventHandler(this.ScanControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTreat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadButton btnReset;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.TextBox txtPtPhone;
        private System.Windows.Forms.TextBox txtPtAllergies;
        private System.Windows.Forms.TextBox txtPtEmail;
        private System.Windows.Forms.TextBox txtPtAddress;
        private System.Windows.Forms.TextBox txtPtName;
        private System.Windows.Forms.TextBox txtPtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnTreat;
        private System.Windows.Forms.RichTextBox txtPtIll;
        private System.Windows.Forms.RichTextBox txtPtMeds;
    }
}
