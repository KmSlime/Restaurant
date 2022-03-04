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

    class Stock
    {
    MY_DB db = new MY_DB();

    public bool InputStock( string Material, string amount, string money, DateTime time, string kind )
    {
            SqlCommand command = new SqlCommand("INSERT INTO [Stock](Material_Name, amount, money,time, kind)" +
                " VALUES ( @Mn, @Am, @Money, @time,@kd)",db.getConnection);
          
            command.Parameters.Add("@Mn", SqlDbType.NVarChar).Value = Material;
            command.Parameters.Add("@Am", SqlDbType.NVarChar).Value = amount;
            command.Parameters.Add("@Money", SqlDbType.NVarChar).Value = money;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = time;
            command.Parameters.Add("@kd", SqlDbType.NVarChar).Value = kind;
           
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
    
        public bool editStock(string Id, string Material,string amount, string money, DateTime time, string kind)
        {
            SqlCommand command = new SqlCommand("UPDATE [Stock] SET Material_Name = @Mname, amount = @Am, money = @mn, time = @time, kind = @kd WHERE Id = @id", db.getConnection);
            command.Parameters.Add("@Mname", SqlDbType.NVarChar).Value = Material;
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = Id;
            command.Parameters.Add("@Am", SqlDbType.NVarChar).Value = amount;
            command.Parameters.Add("@mn", SqlDbType.NVarChar).Value = money;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = time;
            command.Parameters.Add("@kd", SqlDbType.NVarChar).Value = kind;
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
        public bool DeleteStock(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [recipe] WHERE IDMaterial = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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

        public DataTable StockList(SqlCommand command)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public bool UpdateUsed(int IDMaterial, int Used)
        {
            SqlCommand command = new SqlCommand("UPDATE [Stock] SET used = @used WHERE Id = @idM", db.getConnection);
            command.Parameters.Add("@used", SqlDbType.Int).Value = Used;
            command.Parameters.Add("@idM", SqlDbType.Int).Value = IDMaterial;
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

        public DataTable FindAllstock(int IdMaterial)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Stock] WHERE Id = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = IdMaterial;
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }

        public DataTable FindMaterialIDByName (string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Stock] WHERE Material_Name = @Mn", db.getConnection);
            command.Parameters.Add("@Mn", SqlDbType.NVarChar).Value = name;
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }
    }
}
