using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SimpleProject_server_api
{
    public class Konnection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public DataTable dataTable;
        string connect;

        public Konnection()
        {
            connect = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        }

        public void forRetrive(string query)
        {
            con = new SqlConnection(connect);
            cmd = new SqlCommand(query,con);
            sda = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            con.Open();
            cmd.CommandType = CommandType.Text;
            sda.Fill(dataTable);
            con.Close();
        }
        
    }
}