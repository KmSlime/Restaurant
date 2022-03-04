using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace final_Project
{
    public partial class ShowRecipe : Form
    {
        Stock stock = new Stock();
        Recipe recipe = new Recipe();
        DishesCs dishes = new DishesCs();
        MY_DB db = new MY_DB();
        public ShowRecipe()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // chua fix xong
            DataTable table = new DataTable();
            string name = comboBox_SelectMaterial.Text.ToString();
            table = recipe.FindIdbyName(name);
            string id = table.Rows[0][0].ToString();
            DataTable tableDataGriview = new DataTable();
            tableDataGriview = recipe.showDishRecipeById(id);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = tableDataGriview;
           

        }

        private void ShowRecipe_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Dish]", db.getConnection);
            comboBox_SelectMaterial.DataSource = dishes.SelectDishes(command);
            comboBox_SelectMaterial.DisplayMember = "name";
            comboBox_SelectMaterial.ValueMember = "id";

            FullLoad();
            //comboBox_Dish.DataSource = dishes.SelectDishes(command);
            //comboBox_Dish.DisplayMember = "name";
            //comboBox_Dish.ValueMember = "id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullLoad();
        }

        public void FullLoad()
        {
            SqlCommand command = new SqlCommand("SELECT Dish.name AS 'Dish', recipe.Material, recipe.amount FROM [Dish],[recipe]" +
                "WHERE Dish.id = recipe.IdDish", db.getConnection);
            dataGridView1.DataSource = dishes.SelectDishes(command);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
