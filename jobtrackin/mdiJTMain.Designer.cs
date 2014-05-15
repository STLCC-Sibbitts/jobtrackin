namespace jobtrackin
{
	partial class mdiJTMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiJTMain));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabLogin = new System.Windows.Forms.TabPage();
			this.grbxLogin = new System.Windows.Forms.GroupBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabOverview = new System.Windows.Forms.TabPage();
			this.dgvOverview = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.tabCompanies = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.tabContacts = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.tabCallLog = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.tabAppointments = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.tabSettings = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.btnPanel = new System.Windows.Forms.Panel();
			this.lblTopMsgCtr = new System.Windows.Forms.Label();
			this.lblStatusArea = new System.Windows.Forms.Label();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnAppointments = new System.Windows.Forms.Button();
			this.btnCalls = new System.Windows.Forms.Button();
			this.btnContacts = new System.Windows.Forms.Button();
			this.btnCompanies = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnOverview = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblMessageCtr = new System.Windows.Forms.Label();
			this.tabControl.SuspendLayout();
			this.tabLogin.SuspendLayout();
			this.grbxLogin.SuspendLayout();
			this.tabOverview.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
			this.tabCompanies.SuspendLayout();
			this.tabContacts.SuspendLayout();
			this.tabCallLog.SuspendLayout();
			this.tabAppointments.SuspendLayout();
			this.tabSettings.SuspendLayout();
			this.btnPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabLogin);
			this.tabControl.Controls.Add(this.tabOverview);
			this.tabControl.Controls.Add(this.tabCompanies);
			this.tabControl.Controls.Add(this.tabContacts);
			this.tabControl.Controls.Add(this.tabCallLog);
			this.tabControl.Controls.Add(this.tabAppointments);
			this.tabControl.Controls.Add(this.tabSettings);
			this.tabControl.Location = new System.Drawing.Point(0, 98);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1185, 609);
			this.tabControl.TabIndex = 4;
			// 
			// tabLogin
			// 
			this.tabLogin.Controls.Add(this.grbxLogin);
			this.tabLogin.Location = new System.Drawing.Point(4, 22);
			this.tabLogin.Name = "tabLogin";
			this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
			this.tabLogin.Size = new System.Drawing.Size(1177, 583);
			this.tabLogin.TabIndex = 0;
			this.tabLogin.Text = "Login";
			this.tabLogin.UseVisualStyleBackColor = true;
			// 
			// grbxLogin
			// 
			this.grbxLogin.Controls.Add(this.btnLogin);
			this.grbxLogin.Controls.Add(this.btnClear);
			this.grbxLogin.Controls.Add(this.tbPassword);
			this.grbxLogin.Controls.Add(this.tbUsername);
			this.grbxLogin.Controls.Add(this.label2);
			this.grbxLogin.Controls.Add(this.label1);
			this.grbxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.grbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbxLogin.Location = new System.Drawing.Point(348, 188);
			this.grbxLogin.Name = "grbxLogin";
			this.grbxLogin.Size = new System.Drawing.Size(476, 229);
			this.grbxLogin.TabIndex = 0;
			this.grbxLogin.TabStop = false;
			this.grbxLogin.Text = "Enter User Information:";
			// 
			// btnLogin
			// 
			this.btnLogin.Image = global::jobtrackin.Properties.Resources.glossy_login_icon75x75;
			this.btnLogin.Location = new System.Drawing.Point(353, 131);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 73);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnClear
			// 
			this.btnClear.Image = global::jobtrackin.Properties.Resources.glossy_clear_icon75x75;
			this.btnClear.Location = new System.Drawing.Point(92, 131);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 73);
			this.btnClear.TabIndex = 3;
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(184, 91);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(244, 22);
			this.tbPassword.TabIndex = 1;
			this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
			// 
			// tbUsername
			// 
			this.tbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.tbUsername.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsername.Location = new System.Drawing.Point(184, 50);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(244, 26);
			this.tbUsername.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Enter Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Enter Username:";
			// 
			// tabOverview
			// 
			this.tabOverview.Controls.Add(this.dgvOverview);
			this.tabOverview.Controls.Add(this.label3);
			this.tabOverview.Location = new System.Drawing.Point(4, 22);
			this.tabOverview.Name = "tabOverview";
			this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
			this.tabOverview.Size = new System.Drawing.Size(1177, 583);
			this.tabOverview.TabIndex = 1;
			this.tabOverview.Text = "Overview";
			this.tabOverview.UseVisualStyleBackColor = true;
			this.tabOverview.Enter += new System.EventHandler(this.tabOverview_Enter);
			// 
			// dgvOverview
			// 
			this.dgvOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOverview.Location = new System.Drawing.Point(12, 59);
			this.dgvOverview.Name = "dgvOverview";
			this.dgvOverview.Size = new System.Drawing.Size(957, 467);
			this.dgvOverview.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(287, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Job Hunt Tracking - Overview";
			// 
			// tabCompanies
			// 
			this.tabCompanies.Controls.Add(this.label4);
			this.tabCompanies.Location = new System.Drawing.Point(4, 22);
			this.tabCompanies.Name = "tabCompanies";
			this.tabCompanies.Size = new System.Drawing.Size(1177, 583);
			this.tabCompanies.TabIndex = 2;
			this.tabCompanies.Text = "Companies";
			this.tabCompanies.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(305, 24);
			this.label4.TabIndex = 1;
			this.label4.Text = "Job Hunt Tracking - Companies";
			// 
			// tabContacts
			// 
			this.tabContacts.Controls.Add(this.label5);
			this.tabContacts.Location = new System.Drawing.Point(4, 22);
			this.tabContacts.Name = "tabContacts";
			this.tabContacts.Size = new System.Drawing.Size(1177, 583);
			this.tabContacts.TabIndex = 3;
			this.tabContacts.Text = "Contacts";
			this.tabContacts.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(280, 24);
			this.label5.TabIndex = 1;
			this.label5.Text = "Job Hunt Tracking - Contacts";
			// 
			// tabCallLog
			// 
			this.tabCallLog.Controls.Add(this.label6);
			this.tabCallLog.Location = new System.Drawing.Point(4, 22);
			this.tabCallLog.Name = "tabCallLog";
			this.tabCallLog.Size = new System.Drawing.Size(1177, 583);
			this.tabCallLog.TabIndex = 4;
			this.tabCallLog.Text = "Call Log";
			this.tabCallLog.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(276, 24);
			this.label6.TabIndex = 2;
			this.label6.Text = "Job Hunt Tracking - Call Log";
			// 
			// tabAppointments
			// 
			this.tabAppointments.Controls.Add(this.label7);
			this.tabAppointments.Location = new System.Drawing.Point(4, 22);
			this.tabAppointments.Name = "tabAppointments";
			this.tabAppointments.Size = new System.Drawing.Size(1177, 583);
			this.tabAppointments.TabIndex = 5;
			this.tabAppointments.Text = "Appts / Follow Ups";
			this.tabAppointments.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(450, 24);
			this.label7.TabIndex = 2;
			this.label7.Text = "Job Hunt Tracking - Appointments / Follow Ups";
			// 
			// tabSettings
			// 
			this.tabSettings.Controls.Add(this.label8);
			this.tabSettings.Location = new System.Drawing.Point(4, 22);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.Size = new System.Drawing.Size(1177, 583);
			this.tabSettings.TabIndex = 6;
			this.tabSettings.Text = "Settings";
			this.tabSettings.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(268, 24);
			this.label8.TabIndex = 1;
			this.label8.Text = "Job Hunt Tracking -Settings";
			// 
			// btnPanel
			// 
			this.btnPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.btnPanel.Controls.Add(this.lblTopMsgCtr);
			this.btnPanel.Controls.Add(this.lblStatusArea);
			this.btnPanel.Controls.Add(this.btnSettings);
			this.btnPanel.Controls.Add(this.btnAppointments);
			this.btnPanel.Controls.Add(this.btnCalls);
			this.btnPanel.Controls.Add(this.btnContacts);
			this.btnPanel.Controls.Add(this.btnCompanies);
			this.btnPanel.Controls.Add(this.btnExit);
			this.btnPanel.Controls.Add(this.btnOverview);
			this.btnPanel.Location = new System.Drawing.Point(1, 0);
			this.btnPanel.Name = "btnPanel";
			this.btnPanel.Size = new System.Drawing.Size(1181, 120);
			this.btnPanel.TabIndex = 6;
			// 
			// lblTopMsgCtr
			// 
			this.lblTopMsgCtr.Font = new System.Drawing.Font("SketchFlow Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTopMsgCtr.ForeColor = System.Drawing.Color.Red;
			this.lblTopMsgCtr.Location = new System.Drawing.Point(741, 96);
			this.lblTopMsgCtr.Name = "lblTopMsgCtr";
			this.lblTopMsgCtr.Size = new System.Drawing.Size(254, 16);
			this.lblTopMsgCtr.TabIndex = 10;
			this.lblTopMsgCtr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblStatusArea
			// 
			this.lblStatusArea.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.lblStatusArea.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusArea.ForeColor = System.Drawing.Color.DarkOrange;
			this.lblStatusArea.Location = new System.Drawing.Point(741, 10);
			this.lblStatusArea.Name = "lblStatusArea";
			this.lblStatusArea.Size = new System.Drawing.Size(254, 70);
			this.lblStatusArea.TabIndex = 9;
			this.lblStatusArea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnSettings
			// 
			this.btnSettings.Image = global::jobtrackin.Properties.Resources.glossy_settings_icon;
			this.btnSettings.Location = new System.Drawing.Point(588, 1);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(118, 115);
			this.btnSettings.TabIndex = 8;
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Visible = false;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnAppointments
			// 
			this.btnAppointments.Image = global::jobtrackin.Properties.Resources.glossy_appointments_icon;
			this.btnAppointments.Location = new System.Drawing.Point(117, 1);
			this.btnAppointments.Name = "btnAppointments";
			this.btnAppointments.Size = new System.Drawing.Size(118, 115);
			this.btnAppointments.TabIndex = 7;
			this.btnAppointments.UseVisualStyleBackColor = true;
			this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
			// 
			// btnCalls
			// 
			this.btnCalls.Image = global::jobtrackin.Properties.Resources.glossy_callLog_icon;
			this.btnCalls.Location = new System.Drawing.Point(470, 1);
			this.btnCalls.Name = "btnCalls";
			this.btnCalls.Size = new System.Drawing.Size(118, 115);
			this.btnCalls.TabIndex = 6;
			this.btnCalls.UseVisualStyleBackColor = true;
			this.btnCalls.Click += new System.EventHandler(this.btnCalls_Click);
			// 
			// btnContacts
			// 
			this.btnContacts.Image = global::jobtrackin.Properties.Resources.glossy_contacts_icon;
			this.btnContacts.Location = new System.Drawing.Point(352, 1);
			this.btnContacts.Name = "btnContacts";
			this.btnContacts.Size = new System.Drawing.Size(118, 115);
			this.btnContacts.TabIndex = 5;
			this.btnContacts.UseVisualStyleBackColor = true;
			this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
			// 
			// btnCompanies
			// 
			this.btnCompanies.Image = global::jobtrackin.Properties.Resources.glossy_companies_icon;
			this.btnCompanies.Location = new System.Drawing.Point(234, 1);
			this.btnCompanies.Name = "btnCompanies";
			this.btnCompanies.Size = new System.Drawing.Size(118, 115);
			this.btnCompanies.TabIndex = 4;
			this.btnCompanies.UseVisualStyleBackColor = true;
			this.btnCompanies.Click += new System.EventHandler(this.btnCompanies_Click);
			// 
			// btnExit
			// 
			this.btnExit.Image = global::jobtrackin.Properties.Resources.glossy_exit_icon;
			this.btnExit.Location = new System.Drawing.Point(1059, 1);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(118, 115);
			this.btnExit.TabIndex = 3;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnOverview
			// 
			this.btnOverview.Image = global::jobtrackin.Properties.Resources.glossy_overview_icon;
			this.btnOverview.Location = new System.Drawing.Point(0, 1);
			this.btnOverview.Name = "btnOverview";
			this.btnOverview.Size = new System.Drawing.Size(118, 115);
			this.btnOverview.TabIndex = 2;
			this.btnOverview.UseVisualStyleBackColor = true;
			this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblMessageCtr
			// 
			this.lblMessageCtr.BackColor = System.Drawing.Color.White;
			this.lblMessageCtr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblMessageCtr.CausesValidation = false;
			this.lblMessageCtr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblMessageCtr.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessageCtr.ForeColor = System.Drawing.Color.Red;
			this.lblMessageCtr.Location = new System.Drawing.Point(2, 708);
			this.lblMessageCtr.Name = "lblMessageCtr";
			this.lblMessageCtr.Size = new System.Drawing.Size(1181, 22);
			this.lblMessageCtr.TabIndex = 11;
			this.lblMessageCtr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mdiJTMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 733);
			this.Controls.Add(this.lblMessageCtr);
			this.Controls.Add(this.btnPanel);
			this.Controls.Add(this.tabControl);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "mdiJTMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Job Huntin\' Tracker  by: It\'s Just Code";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mdiJTMain_FormClosing);
			this.Load += new System.EventHandler(this.mdiJTMain_Load);
			this.tabControl.ResumeLayout(false);
			this.tabLogin.ResumeLayout(false);
			this.grbxLogin.ResumeLayout(false);
			this.grbxLogin.PerformLayout();
			this.tabOverview.ResumeLayout(false);
			this.tabOverview.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
			this.tabCompanies.ResumeLayout(false);
			this.tabCompanies.PerformLayout();
			this.tabContacts.ResumeLayout(false);
			this.tabContacts.PerformLayout();
			this.tabCallLog.ResumeLayout(false);
			this.tabCallLog.PerformLayout();
			this.tabAppointments.ResumeLayout(false);
			this.tabAppointments.PerformLayout();
			this.tabSettings.ResumeLayout(false);
			this.tabSettings.PerformLayout();
			this.btnPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabLogin;
		private System.Windows.Forms.TabPage tabOverview;
		private System.Windows.Forms.TabPage tabCompanies;
		private System.Windows.Forms.TabPage tabContacts;
		private System.Windows.Forms.TabPage tabCallLog;
		private System.Windows.Forms.TabPage tabAppointments;
		private System.Windows.Forms.GroupBox grbxLogin;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel btnPanel;
		private System.Windows.Forms.Button btnOverview;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCompanies;
		private System.Windows.Forms.Button btnAppointments;
		private System.Windows.Forms.Button btnCalls;
		private System.Windows.Forms.Button btnContacts;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblMessageCtr;
		private System.Windows.Forms.TabPage tabSettings;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Label lblStatusArea;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dgvOverview;
		private System.Windows.Forms.Label lblTopMsgCtr;
	}
}