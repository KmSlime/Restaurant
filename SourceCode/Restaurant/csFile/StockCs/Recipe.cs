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
    class Recipe
    {
        MY_DB db = new MY_DB();
        public bool insertRecipe(string IdDish, int idMaterial, string Material, string amount)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [recipe](IdDish,IDMaterial,Material,amount)" +
                " VALUES ( @idD,@IDM,@Mtr, @Am)", db.getConnection);
            command.Parameters.Add("@idD", SqlDbType.NVarChar).Value = IdDish;
            command.Parameters.Add("@IDM", SqlDbType.NVarChar).Value = idMaterial;
            command.Parameters.Add("@Mtr", SqlDbType.NVarChar).Value = Material;
            command.Parameters.Add("@Am", SqlDbType.NVarChar).Value = amount;
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

        public DataTable SelectMaterial(SqlCommand command)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(command);
            adp.Fill(table);
            return table;
        }

        public bool IdMaterialExist(string IdMaterial, string idDish)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [recipe] WHERE idDish = @idD AND IDMaterial = @IdM", db.getConnection);
            command.Parameters.Add("@idD", SqlDbType.NVarChar).Value = idDish;
            command.Parameters.Add("@IdM", SqlDbType.NVarChar).Value = IdMaterial;
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

        public DataTable FindIdbyName(string name)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [Dish] WHERE name = @Mt", db.getConnection);
            command.Parameters.Add("@Mt", SqlDbType.NVarChar).Value = name;
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }

        public DataTable FindRecipe(int DishID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [recipe] WHERE IdDish = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = DishID;
            DataTable table = new DataTable();
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }

        public DataTable showDishRecipeById(string id)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(" SELECT Dish.name , recipe.Material, recipe.amount FROM [Dish],[recipe] WHERE  Dish.id = recipe.IdDish AND recipe.IdDIsh = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter apt = new SqlDataAdapter(command);
            apt.Fill(table);
            return table;
        }

        public bool RemoveDish(string name)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Stock] WHERE id = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = 0;
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
