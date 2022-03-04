using Restaurant.csFile.MainCs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace Restaurant.ManagerCs
{
    class Manager
    {
        MY_DB mydb = new MY_DB();

        public bool addManager(string fname, string lname, string username, string password, DateTime bDate ,string phone, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO manager (fname, lname, username, bdate ,password, picture, phone, address) VALUES (@fname, @lname, @username, @bdate, @password, @picture, @phone, @address)", mydb.getConnection);

            cmd.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = bDate;
            cmd.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = phone;
            cmd.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getManagerInfo(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT id, username, fname, lname, bdate, phone, address, picture FROM manager WHERE id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adpt.Fill(table);

            return table;
        }

        public bool checkExis(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM manager WHERE username=@username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            mydb.openConnection();

            if(table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;

            } else {
                mydb.closeConnection();
                return true;

            }
        }

        public bool removeManager(int managerID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM manager WHERE id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = managerID;

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public int getIdByUsername(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT id FROM manager WHERE username=@username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return Convert.ToInt32(table.Rows[0][0]);
        }

        public bool editStaff(int id, string fname, string lname, DateTime bdate, string username, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE employee SET fname = @fname, lname = @lname, bdate = @bdate, username = @username, phone = @phone, address = @adrs, picture = @picture WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@adrs", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool editManager(int id, string fname, string lname, DateTime bdate, string username, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE employee SET fname = @fname, lname = @lname, bdate = @bdate, username = @username, phone = @phone, address = @adrs, picture = @picture WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@adrs", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool changePassword(string password)
        {
            SqlCommand cmd = new SqlCommand("UPDATE manager SET password=@pwd WHERE id=@id", mydb.getConnection);
            cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.ManagerID;

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getAllManager()
        {
            SqlCommand cmd = new SqlCommand("SELECT id, fname, lname, username, bdate, phone, address, picture FROM manager", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adpt.Fill(table);

            return table;
        }
    }
}
