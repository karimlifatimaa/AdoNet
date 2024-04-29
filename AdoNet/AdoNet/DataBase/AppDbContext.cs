﻿using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.DataBase
{
    public class AppDbContext
    {
        readonly string connectionString = "server=DESKTOP-VHCECVJ\\SQLEXPRESS;database=ADO_207;Trusted_connection=true;integrated security=true";
        SqlConnection sqlConnection;
        public AppDbContext()
        {
            sqlConnection = new SqlConnection(connectionString);

        }
        public int NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            int result= sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
        public DataTable Query(string query)
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            DataTable table=new DataTable();
            adapter.Fill(table);
            sqlConnection.Close();
            return table;
        }
       
    }
}
