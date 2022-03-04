using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace final_Project
{
    public partial class AddMaterial : Form
    {
        MY_DB db = new MY_DB();
        Recipe recipe = new Recipe();
        DishesCs dishes = new DishesCs();
        public AddMaterial()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            string DishName = comboBox_Dish.Text.ToString();
            DataTable table = new DataTable();
            table = dishes.FindByName(DishName);
            string DishId = table.Rows[0][0].ToString();
            int IdMaterial = Convert.ToInt32(comboBox_Material.SelectedValue.ToString());
            DataTable tableStock = new DataTable();
            string name = comboBox_Material.Text.ToString();
         //   int IdM =Convert.ToInt32(tableStock.Rows[0][0].ToString());
            tableStock = stock.FindMaterialIDByName(name);
            string Material = comboBox_Material.Text.ToString();
            string Amount = textBox_MaterialAmount.Text.ToString();
           
                if (recipe.insertRecipe(DishId,IdMaterial , Material, Amount))
                {
                    MessageBox.Show("It have been inserted", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some thing wrong happended!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
     
        }
        
        public void FormLoad()
        {
           
            SqlCommand command = new SqlCommand("SELECT * FROM [Dish]", db.getConnection);
            comboBox_Dish.DataSource = dishes.SelectDishes(command);
            comboBox_Dish.DisplayMember = "name";
            comboBox_Dish.ValueMember = "id";
            // material
            SqlCommand command1 = new SqlCommand("SELECT * FROM [Stock]", db.getConnection);
            comboBox_Material.DataSource = dishes.SelectDishes(command1);
            comboBox_Material.DisplayMember = "Material_Name";
            comboBox_Material.ValueMember = "id";
        }
        private void AddDishes_Load(object sender, EventArgs e)
        {
            FormLoad();
           
           
        }
        

    }
}
