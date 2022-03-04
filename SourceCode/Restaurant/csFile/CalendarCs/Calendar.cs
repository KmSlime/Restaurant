using csFile.EmployeeCs;
using Restaurant.csFile.MainCs;
using Restaurant.ManagerCs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace csFile.CalendarCs
{
    class Calendar
    {
        MY_DB mydb = new MY_DB();
        Employee employee = new Employee();
        Manager manager = new Manager();

        public bool scheduling()
        {
            
            DataTable table = employee.getAllEmployee();
            DataTable table2 = manager.getAllManager();

            if(table.Rows.Count != 0) 
            {              
                int day = 1;
                int shift = 1;
                for (; day <= 7; day++)
                {
                    managerLoop(day, shift, table2);
                    loop(day, shift, table);
                }
            } else
            {
                return false;
            }
            Global.increaseInit();
            Global.setInitDatabase();
            return true;
        }

        public bool removeSchedule()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM calendar", mydb.getConnection);
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public bool removeManagerSchedule()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM manager_calendar", mydb.getConnection);
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable getCalendar()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM calendar", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public DataTable getManagerCalendar()
        {
            SqlCommand cmd = new SqlCommand("SELECT day, shift, manager_id FROM manager_calendar", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }


        public DataTable availableShift()
        {
            SqlCommand cmd = new SqlCommand("SELECT day, shift FROM calendar WHERE employee_id=0", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public void loop(int day, int shift, DataTable table)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO calendar (day, shift, employee_id) VALUES (@day, @shift, @id)", mydb.getConnection);
            for (; shift <= 3; shift++)
            {
                if (Global.init > table.Rows.Count - 1)
                {
                    Global.setInit(0);
                }
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@day", SqlDbType.Int).Value = day;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[Global.init][0]);

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    mydb.closeConnection();
                }
                else
                {
                    mydb.closeConnection();
                }

                Global.increaseInit();
                Global.setInitDatabase();

            }
        }

        public void managerLoop(int day, int shift, DataTable table)
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand("INSERT INTO manager_calendar (day, shift, manager_id) VALUES (@day, @shift, @id)", mydb.getConnection);
            for (; shift <= 3; shift++)
            {
                if(Global.init % 2 == 0)
                {
                    if (shift % 2 != 0)
                    {
                        count = 0;
                    } else
                    {
                        count = 1;
                    }
                } else {
                    if (shift % 2 != 0)
                    {
                        count = 1;
                    }
                    else
                    {
                        count = 0;
                    }
                }



                cmd.Parameters.Clear();
                cmd.Parameters.Add("@day", SqlDbType.Int).Value = day;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[count][0]);

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    mydb.closeConnection();
                }
                else
                {
                    mydb.closeConnection();
                }

                count++;
            }
        }

        public string convertToDay(int dayNumb)
        {
            switch (dayNumb)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default: 
                    return "";
            }
        }

        public int convertToInt(string day)
        {
            switch (day)
            {
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                case "Saturday":
                    return 6;
                case "Sunday":
                    return 7;
                default:
                    return 0;

            }
        }

        public void newSalary()
        {
            SqlCommand cmd = new SqlCommand("UPDATE salary SET mysalary=0, pay_fines=0", mydb.getConnection);
            if(cmd.ExecuteNonQuery() > 0)
            {

            }
        }

        public void newManagerSalary()
        {
            SqlCommand cmd = new SqlCommand("UPDATE manager_salary SET mysalary=0, pay_fines=0", mydb.getConnection);
            if (cmd.ExecuteNonQuery() > 0)
            {

            }
        }
    }
}
