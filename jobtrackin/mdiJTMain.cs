using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace jobtrackin
{
	public partial class mdiJTMain : Form
	{
		public bool loggedIn = false;
		public string[] loggedInUser;
		public string jtUserId;
		public string jtusername;
		public string jtpassword;
		public string jtfirstName;
		public string jtlastName;
		public string jtsocLastFour;
		public string jtemail;
		public string jtphotoPath;
		public string jtresumePath;
		public string jtpermission;	

		private void mdiJTMain_Load(object sender, EventArgs e)
		{
			lblMessageCtr.IsAccessible = false;
			System.Windows.Forms.ToolTip jhtToolTips = new System.Windows.Forms.ToolTip();

			// Set up the delays for the ToolTip.
			//jhtToolTips.AutoPopDelay = 5000;
			//jhtToolTips.InitialDelay = 1000;
			//jhtToolTips.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			jhtToolTips.ShowAlways = true;

			// Set up the ToolTip text for all application buttons.

			//Main toolbar buttons
			jhtToolTips.SetToolTip(this.btnOverview, "Overview");
			jhtToolTips.SetToolTip(this.btnCompanies, "Companies");
			jhtToolTips.SetToolTip(this.btnContacts, "Contacts");
			jhtToolTips.SetToolTip(this.btnCalls, "Call Log");
			jhtToolTips.SetToolTip(this.btnAppointments, "Apointments / Follow Ups");
			jhtToolTips.SetToolTip(this.btnExit, "Exit / Quit");
			
			//Login form
			jhtToolTips.SetToolTip(this.btnLogin, "Login");
			jhtToolTips.SetToolTip(this.btnClear, "Clear the form and retry");

			this.ActiveControl =  tbUsername;
		}

		public mdiJTMain()
		{
			InitializeComponent();
			this.tabControl.SelectedTab = tabLogin;
		}

			//InitializeComponent();
			//tabOverview.Enabled = false;
			//tabCompanies.Enabled = false;
			//tabContacts.Enabled = false;
			//tabCallLog.Enabled = false;
			//tabAppointments.Enabled = false;
			//tabLogin.Enabled = true; //We call this specifically so there is no chance it got disabled accidentally.


		private void btnOverview_Click(object sender, EventArgs e)
		{
			if (!loggedIn)
			{
				MessageBox.Show("You are not logged in. You must Log in first.");
			}
			else
			{
				this.tabControl.SelectedTab = tabOverview;
			}
		}

		private void btnCompanies_Click(object sender, EventArgs e)
		{
			if (!loggedIn)
			{
				MessageBox.Show("You are not logged in. You must Log in first.");
			}
			else
			{
				this.tabControl.SelectedTab = tabCompanies;
			}
		}

		private void btnContacts_Click(object sender, EventArgs e)
		{
			if (!loggedIn)
			{
				MessageBox.Show("You are not logged in. You must Log in first.");
			}
			else
			{
				this.tabControl.SelectedTab = tabContacts;
			}
		}

		private void btnCalls_Click(object sender, EventArgs e)
		{
			if (!loggedIn)
			{
				MessageBox.Show("You are not logged in. You must Log in first.");
			}
			else
			{
				this.tabControl.SelectedTab = tabCallLog;
			}
		}

		private void btnAppointments_Click(object sender, EventArgs e)
		{
			if (!loggedIn)
			{
				MessageBox.Show("You are not logged in. You must Log in first.");
			}
			else
			{
				this.tabControl.SelectedTab = tabAppointments;
			}
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			if (!loggedIn)
			{
				MessageBox.Show("You are not logged in. You must Log in first.");
			}
			else
			{
				this.tabControl.SelectedTab = tabSettings;
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			lblMessageCtr.Text = "Checking User information...";

			DBconnect dbConn = new DBconnect();
			string userId = dbConn.Login(tbUsername.Text, tbPassword.Text);
			//BigInteger bigIntReturned = new BigInteger();
			//bool isInt = BigInteger.TryParse(userId, out bigIntReturned);
			if (userId != "false")
			{
				string[] loggedInUser;
				String sqlQry = "SELECT * FROM jobUsers WHERE userID='" + userId + "';";
				//MessageBox.Show("Login was successful!");
				dbConn.userQuery(userId, sqlQry, out loggedInUser);
				//{
					
					//DataTable loggedInUser = dbConn.userQuery(userId);
				int pos = Array.IndexOf(loggedInUser, userId);
				if (pos > -1)
				{
					jtUserId = loggedInUser[0];
					jtusername = loggedInUser[1];
					jtpassword = loggedInUser[2];
					jtfirstName = loggedInUser[3];
					jtlastName = loggedInUser[4];
					jtsocLastFour = loggedInUser[5];
					jtemail = loggedInUser[6];
					jtphotoPath = loggedInUser[7];
					jtresumePath = loggedInUser[8];
					jtpermission = loggedInUser[9];

					if (jtpermission == "admin")
					{
						lblStatusArea.Text = "Welcome " + jtusername + "!\n\n You are an '" + jtpermission + "'.";
						btnSettings.Visible = true;
					}
					else
					{
						lblStatusArea.Text = "Welcome " + jtusername + "!\n\nYou have normal access.";
					}
					loggedIn = true;
					lblMessageCtr.Text = "Login Successful!";
					this.tabControl.SelectedTab = tabOverview;
				}
				else
				{
					MessageBox.Show("There was an error loading the user data!!! Contact your administrator immediately!!!");
					Application.Exit();
				}
			}
			//}
			//else
			//{
			//	MessageBox.Show("Login failed! Username/Password was incorrect!\nPlease try again.");
			//	tabControl.SelectedTab = tabLogin;
			//	tbUsername.Focus();
			//}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			tbPassword.Text = "";
			tbUsername.Text = "";
			tbUsername.Focus();
		}

		private void tabOverview_Enter(object sender, EventArgs e)
		{
			this.timer1.Start(); //This will make the message dissappear after a set time.
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.lblMessageCtr.Text = "";
		}

		private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Return)
			{
				btnLogin.PerformClick();
			}
		}

		private void mdiJTMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			string message = "Quit the Application?";
			string caption = "Are you SURE you want to quit?";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(this, message, caption, buttons);
			// login box without logging in - if so then the 
			// app must close
			if (result == DialogResult.No)
			{
				e.Cancel = true;
				//result == DialogResult.No;
				if (!loggedIn)
				{
					this.tabControl.SelectedTab = tabLogin;
				}
				else
				{
					this.tabControl.SelectedTab = tabOverview;
				}
			}
			//else
			//{
			//	// Closes the whole application. 
			//	Application.Exit();
			//}
			//btnExit.PerformClick();
		}
	
	
	
	
	
	
	
	}
}
