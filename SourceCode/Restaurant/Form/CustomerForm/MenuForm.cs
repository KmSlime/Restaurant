using Restaurant;
using Restaurant.csFile.MainCs;
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
    public partial class MenuForm : Form
    {
        MY_DB db = new MY_DB();
        DishesCs dishes = new DishesCs();
        Bill bill = new Bill();
        BillInfo billinfo = new BillInfo();
        public MenuForm()
        {
            InitializeComponent();
        }

         private void button_ShowMenu_Click(object sender, EventArgs e)
        {
            ShowFullMenu();
          
        }

        private void FindKind()
        {
           
            listView_ShowFood.Clear();
            imageList1.Images.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM [Dish] WHERE kind = @kd", db.getConnection);
            command.Parameters.Add("@kd", SqlDbType.NVarChar).Value = comboBox_Kind.Text;
            DataTable table = new DataTable();
            table = dishes.SelectDishes(command);

            int imageIndex = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                imageList1.Images.Add(byteArrayToImage((byte[])table.Rows[i][3]));
                var viewItem = new ListViewItem(table.Rows[i][1].ToString());
                viewItem.ImageIndex = imageIndex;
                listView_ShowFood.Items.Add(viewItem);
                imageIndex++;
            }
        }
       

        public void ShowFullMenu()
        {
            label_Price.Visible = false;
            label_comment.Visible = false;
            label_name.Visible = false;
            label_Amount.Visible = false;
            // listview
            listView_ShowFood.Clear();
            imageList1.Images.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM [Dish]", db.getConnection);
          
            DataTable table = new DataTable();
            table = dishes.SelectDishes(command);
            int imageIndex = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {

                imageList1.Images.Add(byteArrayToImage((byte[])table.Rows[i][3]));

                var viewItem = new ListViewItem(table.Rows[i][1].ToString());
                viewItem.ImageIndex = imageIndex;
                listView_ShowFood.Items.Add(viewItem);
                imageIndex++;
            }

        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void listView_ShowFood_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView_ShowFood.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView_ShowFood.SelectedItems[0];
            //fill the text boxes
            string name = item.SubItems[0].Text;
            DataTable table = new DataTable();
            table = dishes.FindByName(name);
           
            byte[] pic = (byte[])table.Rows[0]["pic"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox_Dish.Image = Image.FromStream(picture);
            pictureBox_Dish.BackgroundImageLayout = ImageLayout.Stretch;
            label_Price.Text ="Price: "+ table.Rows[0][2].ToString();
            label_comment.Text = table.Rows[0][4].ToString();
            label_name.Text = table.Rows[0][1].ToString();
            // Amount
            string id = table.Rows[0][0].ToString();
            
            string state = ShowDishState(id);
            
            label_Amount.Text = ShowDishState(id);
            label_Price.Visible = true;
            label_comment.Visible = true;
            label_name.Visible = true;
            label_Amount.Visible = true;
            button_Add.Visible = true;

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
           
            SqlCommand command = new SqlCommand("SELECT DISTINCT kind FROM [Dish]", db.getConnection);
            
            comboBox_Kind.DataSource = dishes.SelectDishes(command);
            comboBox_Kind.DisplayMember = "kind";
            listView_ShowFood.Clear();
            imageList1.Images.Clear();
            ShowFullMenu();

        }

        private void comboBox_Kind_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindKind();
        }

        private string ShowDishState(string id)
        {
            DataTable table = new DataTable();
           
            string state = "";
            table = dishes.CheckDish( id);
           for( int i= 0; i < table.Rows.Count; i++ )
            {
                int CanUse = Convert.ToInt32(table.Rows[i][4]) - Convert.ToInt32(table.Rows[i][5]);
                int Use = Convert.ToInt32(table.Rows[i][2]);
                if (CanUse <= Use)
                {
                    state = "Sold out";
                 
                }
            }
            return state;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
             string name = label_name.Text.ToString();
            int amount = Convert.ToInt32(numericUpDown_amount.Value.ToString());
            DataTable table = new DataTable();
            table = dishes.FindByName(name);
            int idDish = Convert.ToInt32(table.Rows[0][0].ToString());
            int TableId = Global.GlobalTableId;
            DataTable tableBill = new DataTable();
            tableBill = billinfo.TakeIDBill(TableId);
            int IdBill = Convert.ToInt32(tableBill.Rows[0][1]);
            if ( billinfo.insertBill(IdBill, idDish, amount))     
            {
                MessageBox.Show("The dish is prepare!!","Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowTheirChoice();
        }

        public void ShowTheirChoice()
        {
            int TableId = Global.GlobalTableId;
            DataTable table = new DataTable();
            table = billinfo.TakeIDBill(TableId);
           
            int IdBill =Convert.ToInt32(table.Rows[0][1]);
            DataTable tableShowBill = new DataTable();
            tableShowBill = billinfo.SelectBillInfo(IdBill, TableId);
          
            tableShowBill.Columns.Add("Total", typeof(string));
            
            for (int i = 0; i < tableShowBill.Rows.Count; i++)
            {
                int total = 0;
                total = Convert.ToInt32(tableShowBill.Rows[i][2]) * Convert.ToInt32(tableShowBill.Rows[i][1]);
                tableShowBill.Rows[i][3] = total;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = tableShowBill;
        }

        private void button_ShowBill_Click(object sender, EventArgs e)
        {
            try
            {
                int TableId = Global.GlobalTableId;
                DataTable table = new DataTable();
                table = billinfo.TakeIDBill(TableId);
                int IdBill = Convert.ToInt32(table.Rows[0][1]);
                DataTable tableShowBill = new DataTable();
                DateTime time = DateTime.Now;
                tableShowBill.Columns.Add("Total", typeof(string));
                long TotalBill = 0;         
                for( int i = 0; i<dataGridView1.Rows.Count; i++)
                {
                    TotalBill += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
              
                PrintBillForm printBillForm = new PrintBillForm();
                printBillForm.ShowDialog();
            }
            catch
            {

            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
