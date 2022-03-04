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
    class BillCs
    {
        MY_DB db = new MY_DB();
        public bool InsertBill(int idTable, DateTime TimeIn)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Bill] (IdTable, state,checkIn)" +
                " VALUES (@idT,@st,@CIn)", db.getConnection);
            command.Parameters.Add("@idT", SqlDbType.Int).Value = idTable;
            command.Parameters.Add("@st", SqlDbType.NVarChar).Value = " Eating";
            command.Parameters.Add("@CIn", SqlDbType.DateTime).Value = TimeIn;

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

        public bool UpDateBill(int idTable, int IdBill, DateTime TimeOut, string money)
        {
            string state = "Paid";
            SqlCommand command = new SqlCommand("UPDATE [Bill] SET checkOut = @CO , state = @St, money = @mn WHERE idBill = @idB AND idTable = @idT", db.getConnection);
            command.Parameters.Add("@CO", SqlDbType.DateTime).Value = TimeOut;
            command.Parameters.Add("@St", SqlDbType.NVarChar).Value = state;
            command.Parameters.Add("@idB", SqlDbType.Int).Value = IdBill;
            command.Parameters.Add("@idT", SqlDbType.NVarChar).Value = idTable;
            command.Parameters.Add("@mn", SqlDbType.NVarChar).Value = money;


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
