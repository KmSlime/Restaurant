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
    public partial class WareHouseForm : Form
    {
        Stock stock = new Stock();
        MY_DB db = new MY_DB();
        bool button = false;
        bool KindFLag = false;
        public WareHouseForm()
        {
            InitializeComponent();
        }

        private void WareHourseForm_Load(object sender, EventArgs e)
        {
            LoadFull();
            button_Remove.Enabled = false;
          
        }

        public void LoadFull()
        {
            groupBox_Information.Visible = false;
            // datagridview
            SqlCommand command = new SqlCommand("SELECT * FROM [Stock]", db.getConnection);
            DataTable table = new DataTable();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            groupBox_Information.Visible = true;
            label_TimeEdit.Visible = false;
            dateTimePicker_Edit.Visible = false;
            button_ShowAdd.Visible = false;
            button_Edit.Visible = true;
            button = false;//
            button_EditMaterial.Visible = false ;
            button_AddMaterial.Visible = true;
            textBox_Id.Visible = false;
            label_Id.Visible = false;
            textBox_Id.Text = "";
            textBox_Material.Text = "";
            textBox_Amount.Text = "";
            textBox_Price.Text = "";

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            groupBox_Information.Visible = true;
            button_AddMaterial.Visible = false;
            button_Edit.Visible = false;
            button_ShowAdd.Visible = true;
            dateTimePicker_Edit.Visible = true;
            label_TimeEdit.Visible = true;
            button = true;
            button_AddMaterial.Visible = false;
            button_EditMaterial.Visible = true;
            textBox_Id.Visible = true;
            label_Id.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_AddMaterial_Click(object sender, EventArgs e)
        {

           
            string id = textBox_Id.Text.ToString();
            string Material = textBox_Material.Text.ToString();
            string Amount = textBox_Amount.Text.ToString();
            string money = textBox_Price.Text.ToString();

            DateTime time = dateTimePicker_Edit.Value.Date;
            string kind = textBox_Kind.Text.ToString();
            if (CheckSpace())
            {
                if (stock.InputStock( Material, Amount, money, time, kind))
                {
                    MessageBox.Show("The Material is inserted ", "Stock form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    textBox_Material.Text = "";
                    textBox_Amount.Text = "";
                    textBox_Price.Text = "";
                    LoadFull();
                    button_ShowAdd.Visible = true;
                }
                else
                {
                    MessageBox.Show("Something wrong happended :(", "Stock form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information!!!", "Stock form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool CheckSpace()
        {
            if ( textBox_Material.Text.Trim() == "" ||
                textBox_Amount.Text.Trim() == "" || textBox_Price.Text.Trim() == "" || textBox_Kind.Text.Trim() == "")
               {
                return false;
               }
            else
            {
                return true;
            }
        }

        private void button_EditMaterial_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text.ToString();
            string Material = textBox_Material.Text.ToString();
            string Amount = textBox_Amount.Text.ToString();
            string money = textBox_Price.Text.ToString();

            DateTime time = dateTimePicker_Edit.Value.Date;
            string kind = textBox_Kind.Text.ToString();
            if (CheckSpace())
            {
                if (stock.editStock(id, Material, Amount, money, time, kind))
                {
                    MessageBox.Show("The Material is Editted ", "Stock form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFull();
                    button_Edit.Visible = true;
                }
                else
                {
                    MessageBox.Show("Something wrong happended :(", "Stock form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please full all the information!!!", "Stock form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (button == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [Stock] WHERE id = @id", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DataTable table = new DataTable();
                table = stock.StockList(command);
                textBox_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_Material.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_Amount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_Price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker_Edit.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
                textBox_Kind.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show("Do you really want to delete this rows", "Stock Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (stock.DeleteStock(id))
                    {
                        MessageBox.Show("The Material is Deleted ", "Stock form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFull();
                    }
                    else
                    {
                        MessageBox.Show("Something wrong happended :(", "Stock form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void cellClick_TextChanged(object sender, EventArgs e)
        {
            button_Remove.Enabled = true;
        }

        private void textBox_FindId_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            string dateFrom = dateTimePicker_DateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dateTimePicker_DateTo.Value.ToString("yyyy-MM-dd");
            string query = "SELECT * FROM [Stock] WHERE time  BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
           if(textBox_MaterialFind.Text.Trim() != "")
            {
                query = query + "AND Material_name = @Mn ";

            }
           if(KindFLag == true)
            {
                query = query + "AND kind = @kd ";
            }
           
           
            SqlCommand command = new SqlCommand(query,db.getConnection);
            command.Parameters.Add("@Mn", SqlDbType.NVarChar).Value = textBox_MaterialFind.Text.ToString();
            string kind = comboBox_FindKind.Text.ToString();
            command.Parameters.Add("@kd", SqlDbType.NVarChar).Value = kind;
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(command);
            adp.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox_FindMaterial_TextChanged(object sender, EventArgs e)
        {
            KindFLag = true;
        }

        private void comboBox_FindKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            KindFLag = true;
        }

        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            LoadFull();
            button_ShowAdd.Visible = true;
            button_Edit.Visible = true;
        }
    }
}
