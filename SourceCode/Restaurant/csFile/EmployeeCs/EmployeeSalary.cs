using Restaurant.csFile.MainCs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace Restaurant
{
    class EmployeeSalary
    {
        MY_DB mydb = new MY_DB();

        public DataTable myWorkTime()
        {
            SqlCommand cmd = new SqlCommand("SELECT checkin, checkout FROM calendar WHERE employee_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.StaffID;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool mySalary()
        {
            TimeSpan workHours = new TimeSpan();
            try
            {
                DateTime checkin = (DateTime)myWorkTime().Rows[0][0];
                DateTime checkout = (DateTime)myWorkTime().Rows[0][1];

                workHours = checkout.TimeOfDay - checkin.TimeOfDay;
            } catch
            {
                workHours = new TimeSpan(0,0,0);
            }
            if(workHours.Hours < 12)
            {
                if (fined(100)) { }
            }
            
            int salary = workHours.Hours * 80;
            
            SqlCommand cmd = new SqlCommand("UPDATE salary SET mysalary=@salary WHERE employee_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.StaffID;
            cmd.Parameters.Add("@salary", SqlDbType.Int).Value = salary;

            mydb.openConnection();

            if(cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            } else {
                mydb.closeConnection();
                return false;
            }
        }      

        public bool fined(int fee)
        {
            SqlCommand cmd = new SqlCommand("UPDATE salary SET pay_fines=@pay WHERE employee_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.StaffID;
            cmd.Parameters.Add("@pay", SqlDbType.Int).Value = fee + Global.StaffFine;

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

        public bool bonus(int bonus)
        {
            SqlCommand cmd = new SqlCommand("UPDATE salary SET pay_fines=@pay WHERE employee_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.StaffID;
            cmd.Parameters.Add("@pay", SqlDbType.Int).Value = getSalary() + bonus;

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

        public int getSalary()
        {
            SqlCommand cmd = new SqlCommand("SELECT mysalary FROM salary WHERE employee_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.StaffID;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return Convert.ToInt32(table.Rows[0][0]);
        }

        public bool addToSalaryData(int id)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO salary (mysalary, employee_id, pay_fines) VALUES (0, @id, 0)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();
            
            if(cmd.ExecuteNonQuery() > 0)
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

        public bool removeFromSalaryData(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM salary WHERE employee_id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
    }
}
