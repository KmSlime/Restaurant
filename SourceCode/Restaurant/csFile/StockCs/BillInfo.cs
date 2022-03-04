using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace final_Project
{
    class BillInfo
    {
        MY_DB db = new MY_DB();
        public bool insertBill(int IdBill,int IdDish, int amount)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [BillInfo] (IdBill,IdDish,Amount) VALUES (@idB,@idD,@Am)", db.getConnection);
            command.Parameters.Add("@idB", SqlDbType.Int).Value = IdBill;
            command.Parameters.Add("@idD", SqlDbType.Int).Value = IdDish;
            command.Parameters.Add("@Am", SqlDbType.Int).Value = amount;
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
        //con bug
        public DataTable SelectBillInfo(int IdBill, int idTable)
        {
            SqlCommand command = new SqlCommand("SELECT Dish.name,  Dish.price, BillInfo.Amount FROM [Dish],[BillInfo],[Bill] WHERE Dish.Id = BillInfo.IdDish AND BillInfo.IdBill = @idB AND Bill.IdTable = @idT AND BillInfo.IdBill = Bill.IdBill", db.getConnection);
            command.Parameters.Add("@idT", SqlDbType.Int).Value = idTable;
            command.Parameters.Add("@idB", SqlDbType.Int).Value = IdBill;
           DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }

        public DataTable TakeIDBill(int TableID)
        {
            string state = " Eating";
            SqlCommand command = new SqlCommand("SELECT * FROM [Bill] WHERE IdTable = @idT AND state = @st ", db.getConnection);
            command.Parameters.Add("@idT", SqlDbType.Int).Value = TableID;
            command.Parameters.Add("@st", SqlDbType.NVarChar).Value = state;
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }

        public DataTable TableInfo(int IdBill, int idTable)
        {
            SqlCommand command = new SqlCommand("SELECT Dish.name,  Dish.price, BillInfo.Amount, Bill.checkIn FROM [Dish],[BillInfo],[Bill] WHERE Dish.Id = BillInfo.IdDish AND BillInfo.IdBill = @idB AND Bill.IdTable = @idT", db.getConnection);
            command.Parameters.Add("@idT", SqlDbType.Int).Value = idTable;
            command.Parameters.Add("@idB", SqlDbType.Int).Value = IdBill;
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }

        public bool DeleteOrderedDish(int IdDish)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [BillInfo] WHERE IdBill = @idB", db.getConnection);
            command.Parameters.Add("@idB", SqlDbType.Int).Value = IdDish;
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
