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
    public partial class Dishes : Form
    {
        MY_DB db = new MY_DB();
        DishesCs dishes = new DishesCs();
        string IDDish;
        public Dishes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_AddUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_add.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox_add.Image = Image.FromFile(opf.FileName);
                pictureBox_add.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_add.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button_EditUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Edit.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox_Edit.Image = Image.FromFile(opf.FileName);

            }
        }

        private void button_Ingredient_Click(object sender, EventArgs e)
        {           
            AddMaterial adddishes = new AddMaterial();
            adddishes.ShowDialog();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Dishes dishform = new Dishes();
            if (verif())
            {
                string Name = textBox_AddName.Text.ToString();
               
                string price = textBox_Price.Text.ToString();
                string kind = textBox_Kind.Text.ToString();
                string comment = textBox_Comment.Text.ToString();
                    MemoryStream pic = new MemoryStream();
                    pictureBox_add.Image.Save(pic, pictureBox_add.Image.RawFormat);
                    if (dishes.insertDishes( Name, price, pic,comment,kind))
                    {
                        MessageBox.Show("The dish is inserted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoad();
                    }
                    else
                    {
                        MessageBox.Show("Some thing wrong happended!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
              
            }
            
            else
            {
                MessageBox.Show("Please fill all the information!!!", "NoTification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool verif()
        {
            if ((textBox_AddName.Text.Trim() == "")
                || (textBox_Price.Text.Trim() == "")   
                || pictureBox_add.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            FindDishes_Form findDishesForm = new FindDishes_Form();
            findDishesForm.ShowDialog();

            try
            {
                IDDish = findDishesForm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_EditName.Text = findDishesForm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_EditPrice.Text = findDishesForm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_EditCmt.Text = findDishesForm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox_editKind.Text = findDishesForm.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                DataTable table = new DataTable();
                 table = dishes.FindByID(IDDish);
               
                //picture
                byte[] pic = (byte[])table.Rows[0][3];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox_Edit.Image = Image.FromStream(picture);
                pictureBox_Edit.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_Edit.BackgroundImageLayout = ImageLayout.Stretch;

                //Combobox
                SqlCommand command = new SqlCommand("SELECT * FROM [Stock] ", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = IDDish;
                DataTable tableRecipe = new DataTable();
                tableRecipe = dishes.SelectDishes(command);
               
            }
            catch (Exception) { }
        }

        private void DishesForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        void FormLoad()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [Dish]", db.getConnection);
            comboBox_RemoveDish.DataSource = dishes.SelectDishes(command);
            comboBox_RemoveDish.DisplayMember = "name";
            comboBox_RemoveDish.ValueMember = "id";
            textBox_AddName.Text = "";
            textBox_EditName.Text = "";
            textBox_Price.Text = "";
          
            textBox_EditPrice.Text = "";
            pictureBox_add.Image = null;
            pictureBox_Edit.Image = null;
            //
            SqlCommand command1 = new SqlCommand("SELECT * FROM [recipe]", db.getConnection);
            
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string name = comboBox_RemoveDish.Text.ToString();
            if(dishes.RemoveDish(name))
            {
                MessageBox.Show("The Dish is deleted", "DishForm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLoad();
            }
            else
            {
                MessageBox.Show("Some thing wrong happended!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (textBox_EditName.Text.Trim() != "" || textBox_EditPrice.Text.Trim() != "")
            {
                string NewName = textBox_EditName.Text.ToString();
                string NewPrice = textBox_EditPrice.Text.ToString();
                string comment = textBox_EditCmt.Text.ToString();
                string kind = textBox_editKind.Text.ToString();
                MemoryStream pic = new MemoryStream();
                pictureBox_Edit.Image.Save(pic, pictureBox_Edit.Image.RawFormat);
                if (textBox_EditName.Text.Trim() == "" || textBox_EditPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill all the information!!!", "NoTification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dishes.updatetDish(IDDish, NewName, NewPrice, pic, comment, kind))
                    {
                        MessageBox.Show("The dish is inserted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoad();
                    }
                    else
                    {
                        MessageBox.Show("Some thing wrong happended!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please fill all the information!!!", "NoTification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            AllTheDishesForm allthedishForm = new AllTheDishesForm();
            allthedishForm.Show();
        }

        private void button_ShowRecipe_Click(object sender, EventArgs e)
        {
            ShowRecipe showrecipe = new ShowRecipe();
            showrecipe.ShowDialog();
        }
    }
}
