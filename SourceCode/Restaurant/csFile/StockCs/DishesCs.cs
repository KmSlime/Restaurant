using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace Restaurant
{
    class DishesCs
    {
        MY_DB db = new MY_DB();
        public bool insertDishes(string DishName, string money, MemoryStream picture, string comment, string kind)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Dish] (name,price,pic,comment,kind)" +
                "VALUES (@dsh,@pr,@pic,@cmt,@kd)", db.getConnection);

            command.Parameters.Add("@dsh", SqlDbType.NVarChar).Value = DishName;
            command.Parameters.Add("@pr", SqlDbType.NVarChar).Value = money;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@cmt", SqlDbType.NVarChar).Value = comment;
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

        public bool updatetDish(string ID, string DishName, string price, MemoryStream picture, string comment, string kind)
        {

            SqlCommand command = new SqlCommand("UPDATE [Dish] SET name = @nm, price = @pr, pic = @picture, comment = @cmt, kind = @kd " +
                "WHERE id = @id ", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@nm", SqlDbType.NVarChar).Value = DishName;
            command.Parameters.Add("@pr", SqlDbType.NVarChar).Value = price;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@cmt", SqlDbType.NVarChar).Value = comment;
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


        public DataTable FindByID(string ID)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM [Dish] WHERE Id = @cid", db.getConnection);
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = ID;
            SqlDataAdapter apd = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            apd.Fill(table);
            return table;
        }

        public bool RemoveDish(string name)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Dish] WHERE name =@nm", db.getConnection);
            command.Parameters.Add("@nm", SqlDbType.NVarChar).Value = name;
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

        public DataTable SelectDishes(SqlCommand command)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(command);
            adp.Fill(table);
            return table;
        }

        public bool ExistId(string ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Dish] WHERE Id = @cid", db.getConnection);

            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = ID;
            SqlDataAdapter apd = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            apd.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable FindByName(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Dish] WHERE name =@nm", db.getConnection);
            command.Parameters.Add("@nm", SqlDbType.NVarChar).Value = name;
            SqlDataAdapter apd = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            apd.Fill(table);
            return table;
        }


        public DataTable CheckDish(string id)
        {
            SqlCommand command = new SqlCommand("SELECT recipe.IdDish, recipe.IDMaterial, recipe.amount, Stock.Id," +
                " Stock.amount, Stock.used FROM [recipe],[Stock] WHERE recipe.IdDish = @id AND recipe.IDMaterial = Stock.Id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }
    }
}
