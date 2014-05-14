using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using jobtrackin;
using System.Security.Cryptography;
using System.Data;
using System.Numerics;

namespace jobtrackin
{
	class DBconnect
	{
		//Unfortunately these need to be public due to time 
		//constraints or I would have done the whole public/private thing.
		public MySql.Data.MySqlClient.MySqlConnection dbConn = null;
		public MySql.Data.MySqlClient.MySqlDataReader dbReader = null;
		public string dbconnString = Properties.Settings.Default.connectionString;

		public DBconnect()
		{
			try
			{
				dbConn = new MySqlConnection(dbconnString);
				dbConn.Open();
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			//finally
			//{
			//	if (dbConn != null)
			//	{
			//		dbConn.Close(); //safely close the connection
			//	}
			//}
		}

		public string Login(string user, string pass)
		{
			string retVal = "false";

			try
			{
				dbConn = new MySqlConnection(dbconnString);
				dbConn.Open(); //open the connection
				String cmdText = "SELECT userId, username, password, permission FROM jobUsers WHERE username=@name";
				//Unfortunately I don't have to time at the moment to deal with md5 hashing the password, figuring it out
				//was taking way to long.
				MySqlCommand cmd = new MySqlCommand(cmdText, dbConn);
				cmd.Prepare();
				//we will bind a value to the placeholder
				cmd.Parameters.AddWithValue("@name", user);
				dbReader = cmd.ExecuteReader(); //execute the reader
				/*The Read() method points to the next record It return false if there are no more records else returns true.*/
				while (dbReader.Read())
				{
					/** 
					 * reader.GetString(0) will get the value of the first column of 
					 * the table so we need to get the password column wich is dbReader.Getstring(2)
					 * 
					 **/
					if (dbReader.GetString(2) == pass)
					{
						retVal = dbReader.GetString(0);
					}
					else
					{
						retVal = "false";
					}
				}
			}
			catch (MySqlException err)
			{
				MessageBox.Show("Login failed! With Error: " + err.ToString());
				retVal = "false";
			}
			return retVal;
		}

		public static void userQuery(string uId, out string[] userData)
		{
			String sqlQry = "SELECT * FROM jobUsers WHERE userID='" + uId + "'";
			using (MySqlConnection dbConn = new MySqlConnection(sqlQry))
			{
				dbConn.Open(); //open the connection

				//using (MySqlDataAdapter dbCa = new MySqlDataAdapter(qrySql, dbConn))
				//{
				//MySqlDataAdapter dbCa = new MySqlDataAdapter();
				//dbCa.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				//dbCa.SelectCommand = new MySqlCommand(qrySql, dbConn);
				MySqlCommand cmd = new MySqlCommand(sqlQry, dbConn);
				cmd.Prepare();
				//dbCa.InsertCommand.Prepare(cmdText); //broken

				//we will bind a value to the placeholder
				//dbCa.InsertCommand.Parameters.AddWithValue("@uId", uId);

				MySqlDataReader dbReader = cmd.ExecuteReader(); //execute the reader
				//DataSet userDs = new DataSet();
				//DataTable userData = new DataTable();
				//dbCa.Fill(userDs);
				if (dbReader.HasRows)
				{
					dbReader.Read();
					userData = new string[9];
					userData[0] = dbReader.GetString(0);
					userData[1] = dbReader.GetString(1);
					userData[2] = dbReader.GetString(2);
					userData[3] = dbReader.GetString(3);
					userData[4] = dbReader.GetString(4);
					userData[5] = dbReader.GetString(5);
					userData[6] = dbReader.GetString(6);
					userData[7] = dbReader.GetString(7);
					userData[8] = dbReader.GetString(8);
					userData[9] = dbReader.GetString(9);
					//userData.Clear();
					//userData.Columns.Add("userID");
					//userData.Columns.Add("username");
					//userData.Columns.Add("password");
					//userData.Columns.Add("firstName");
					//userData.Columns.Add("lastName");
					//userData.Columns.Add("socLastFour");
					//userData.Columns.Add("email");
					//userData.Columns.Add("photoPath");
					//userData.Columns.Add("resumePath");
					//userData.Columns.Add("permission");
					//DataRow uidRow = userData.NewRow();

					//dbReader.Read(); //We should now have our single user record.
					//uidRow["userID"] = dbReader.GetString(0);
					//uidRow["username"] = dbReader.GetString(1);
					//uidRow["password"] = dbReader.GetString(2);
					//uidRow["firstName"] = dbReader.GetString(3);
					//uidRow["lastName"] = dbReader.GetString(4);
					//uidRow["socLastFour"] = dbReader.GetString(5);
					//uidRow["email"] = dbReader.GetString(6);
					//uidRow["photoPath"] = dbReader.GetString(7);
					//uidRow["resumePath"] = dbReader.GetString(8);
					//uidRow["permission"] = dbReader.GetString(9);
					dbConn.Close();
				}
				//return userDs.Tables[0];
				//}
			}
		}
	}
}
