		
		public void dbQry(string type, string uId, string sqlQry)
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
					jtDa.InsertCommand.Parameters.AddWithValue("@userId", uId);
					jtDa.InsertCommand.Prepare();
					
					using (dbConn)
					{
						dbConn.Open(); //open the connection

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
					break;
				case "insert":
					jtDa.InsertCommand = new MySqlCommand(sqlQry, dbConn);
					break;
				case "update":
					jtDa.UpdateCommand = new MySqlCommand(sqlQry, dbConn);
					break;
				case "delete":
					jtDa.DeleteCommand = new MySqlCommand(sqlQry, dbConn);
					break;
			}
			
		}