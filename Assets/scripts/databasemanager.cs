//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;
//using System.Data;
//using Mono.Data.Sqlite;

//public class databasemanager : MonoBehaviour {

//    private string connectionstring;


//	// Use this for initialization
//	void Start () {
//        connectionstring = "URI=file:" + Application.dataPath + "/plugins/pitchcount.sqlite";
//        getpitches();
//	}
	
//	// Update is called once per frame
//	void Update () {
		
//	}

//    private void getpitches()
//    {
//        using (IDbConnection dbConnection = new SqliteConnection(connectionstring))
//        {
//            dbConnection.Open();
//            using (IDbCommand dbcmd = dbConnection.CreateCommand())
//            {
//                string sqlqueryall = "SELECT * FROM pitches";
//                dbcmd.CommandText = sqlqueryall;

//                using (IDataReader reader = dbcmd.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        Debug.Log(reader.GetInt16(1));
//                    }

//                    dbConnection.Close();
//                    reader.Close();
//                }
//            }
//        }

//    }
//}
