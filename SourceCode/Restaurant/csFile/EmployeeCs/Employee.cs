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

namespace csFile.EmployeeCs
{
    class Employee
    {
        MY_DB mydb = new MY_DB();    

        public DataTable getAllEmployee()
        {
            SqlCommand cmd = new SqlCommand("SELECT id, fname, lname, username, bdate, phone, address, picture FROM employee", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adpt.Fill(table);

            return table;
        }

        public DataTable getEmployeeInfo(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT id, fname, lname, bdate, phone, address, picture FROM employee WHERE id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adpt.Fill(table);

            return table;
        }

        public bool addEmployee(string fname, string lname, string username, string password, DateTime bDate, string phone, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO employee (fname, lname, username, bdate ,password, picture, phone, address) VALUES (@fname, @lname, @username, @bdate, @password, @picture, @phone, @address)", mydb.getConnection);

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
        public bool checkExis(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM employee WHERE username=@username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            mydb.openConnection();

            if (table.Rows.Count > 0)
            {
                cmd.CommandText = "SELECT * FROM manager WHERE username=@username";
                adpt.SelectCommand = cmd;
                adpt.Fill(table);

                if (table.Rows.Count > 0)
                {
                    mydb.closeConnection();
                    return false;

                }
                else
                {
                    mydb.closeConnection();
                    return true;

                }
            }
            else
            {
                cmd.CommandText = "SELECT * FROM manager WHERE username=@username";
                adpt.SelectCommand = cmd;
                adpt.Fill(table);

                if (table.Rows.Count > 0)
                {
                    mydb.closeConnection();
                    return false;

                }
                else
                {
                    mydb.closeConnection();
                    return true;

                }
            }
        }

        public bool removeEmployee(int employeeID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM employee WHERE id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = employeeID;

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
            SqlCommand cmd = new SqlCommand("SELECT id FROM employee WHERE username=@username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return Convert.ToInt32(table.Rows[0][0]);
        }
        public string getNameByID(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT fname, lname FROM employee WHERE id=@id", mydb.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adpt.Fill(table);

                return table.Rows[0][0].ToString() + " " + table.Rows[0][1].ToString();
            }
            catch
            {
                return "";
            }
        }

        public DataTable getShift(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT day, shift FROM calendar WHERE employee_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool changePassword(string password)
        {
            SqlCommand cmd = new SqlCommand("UPDATE employee SET password=@pwd WHERE id=@id", mydb.getConnection);
            cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.StaffID;

            mydb.openConnection();

            if(cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
