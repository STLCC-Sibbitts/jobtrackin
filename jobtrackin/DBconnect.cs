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

		public void userQuery(string uId, string sqlQry, out string[] userData)
		{
			userData = new string[10];

			using (MySqlConnection dbConn = new MySqlConnection(dbconnString))
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
					dbConn.Close();
				}
			}
		}




		//public DataSet SelectRows(DataSet dataset,string connection,string query) 
		public DataSet dbQry(string type, string uId, string sqlQry, DataSet jtDs, DataGridView dgv)
		{
			//We may only be using one of these...
			MySqlConnection dbConn = new MySqlConnection(dbconnString);
			MySqlDataAdapter jtDa = new MySqlDataAdapter();
			jtDa.MissingSchemaAction = MissingSchemaAction.AddWithKey; //We need/WANT the index keys in the result set
			//MySqlCommand cmd = new MySqlCommand();
			switch (type)
			{
				case "select":
					jtDa.SelectCommand = new MySqlCommand(sqlQry, dbConn);
					//jtDa.InsertCommand.Parameters.AddWithValue("@userId", uId); //Will get this part working when there is more time.
					//jtDa.InsertCommand.Prepare(); //Will get this part working when there is more time.
					//DataSet jtDs = new DataSet();
					jtDa.Fill(jtDs);
					//DataTable jtDt = jtDs.Tables["jobInterviews"];
					dgv.DataSource = jtDs.Tables[0];
					//dgv.DataMember = jtDt.TableName[0];
					return jtDs;
					//break;
				case "insert":
					jtDa.InsertCommand = new MySqlCommand(sqlQry, dbConn);
					return jtDs;
					//break;
				case "update":
					jtDa.UpdateCommand = new MySqlCommand(sqlQry, dbConn);
					return jtDs;
					//break;
				case "delete":
					jtDa.DeleteCommand = new MySqlCommand(sqlQry, dbConn);
					return jtDs;
					//break;
				default:
					return jtDs;
					//break;
			}
		}
	
	
	}
}
