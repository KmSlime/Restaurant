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
    class TablesCs
    {
        MY_DB db = new MY_DB();
        public bool InsertTable(int people, string state)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Tables] (people,state) VALUES (@pp,@state) ", db.getConnection);
            command.Parameters.Add("@pp", SqlDbType.NVarChar).Value = people;
            command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool UpdateTable(int id, int people, string state)
        {
            SqlCommand command = new SqlCommand("UPDATE[Tables] SET people = @pp, state = @st WHERE id = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@pp", SqlDbType.NVarChar).Value = people;
            command.Parameters.Add("@st", SqlDbType.NVarChar).Value = state;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
        public DataTable AllTheTable(SqlCommand command)
        {
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }

        public bool Exist(int idTable)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Tables] WHERE id = @id ", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idTable;
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool CheckEmptyTable(int idTables)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Tables] WHERE id = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idTables;
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            string state = table.Rows[0][2].ToString();
            if (state == "Empty")
            {
                return true;
            }
            else return false;
        }

        public DataTable TableInfo(int idTables, int idBill)
        {
            SqlCommand command = new SqlCommand("SELECT Bill.idTable, Bill.idBill, Dish.name, BillInfo.Amount, Dish.price FROM [Bill],[Dish],[BillInfo] WHERE" +
               " Bill.IdTable = @idT AND BillInfo.IdBill = @idB AND BillInfo.IdBill = Bill.IdBill ", db.getConnection);
            command.Parameters.Add("@idT", SqlDbType.Int).Value = idTables;
            command.Parameters.Add("@idB", SqlDbType.Int).Value = idBill;
            DataTable table = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(command);
            adt.Fill(table);
            return table;
        }

        public bool RemoveTable(int idTable)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Tables] WHERE id = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idTable;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
