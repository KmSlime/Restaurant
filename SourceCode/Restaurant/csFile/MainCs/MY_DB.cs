using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1VNURLH\TUAN;Initial Catalog=Restaurant;Integrated Security=True");

        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }

    public class Class1
    {
    }
}
