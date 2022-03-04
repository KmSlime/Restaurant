using csFile.EmployeeCs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace Restaurant.csFile.MainCs
{
    public static class Global
    {
        

        static Global() { init = getInit();
            ManagerID = 1234;
            StaffID = 1234;
            StaffFine = 0;
            ManagerFine = 0;
        }



        public static int ManagerID { get; private set; }

        public static void setManagerID(int id)
        {
            ManagerID = id;
        }

        public static int StaffFine { get; private set; }


        public static void fine(int id)
        {
            StaffFine = id;
        }

        public static int ManagerFine { get; private set; }


        public static void managerFine(int id)
        {
            ManagerFine = id;
        }



        public static int StaffID { get; private set; }

        public static void setStaffID(int id)
        {
            StaffID = id;
        }

        public static int GlobalTableId { get; private set; }

        public static void SetGlobalTableId(int TableID)
        {
            GlobalTableId = TableID;

        }




        public static int init { get; private set; }

        public static void setInit(int id)
        {
            init = id;
        }

        public static void increaseInit()
        {
            init++;
        }
        
        public static void setInitDatabase()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("UPDATE initial SET init = @init", mydb.getConnection);
            cmd.Parameters.Add("@init", System.Data.SqlDbType.Int).Value = init;

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 0)
            {
                mydb.closeConnection();
            }
            else
            {
                mydb.closeConnection();
            }

        }

        public static int getInit()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT init FROM initial", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adpt.Fill(table);

            return Convert.ToInt32(table.Rows[0][0]);
        }

        public static int getFine()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT pay_fines FROM salary WHERE employee_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = StaffID;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return Convert.ToInt32(table.Rows[0][0]);
        }

        public static int getManagerFine()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT pay_fines FROM manager_salary WHERE manager_id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ManagerID;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return Convert.ToInt32(table.Rows[0][0]);
        }
    }
}
