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
    public partial class Bill : Form
    {
        MY_DB db = new MY_DB();
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Form_Load(object sender, EventArgs e)
        {
            ShowAllBills();
        }

        public void ShowAllBills()
        {
           
            SqlCommand command = new SqlCommand("SELECT Bill.IdBill,Bill.idTable, Bill.money, Bill.checkIn, Bill.checkOut,Dish.name AS 'Dish' ,BillInfo.Amount" +
                " FROM [Bill],[Dish],[BillInfo] WHERE Dish.Id = BillInfo.IdDish AND Bill.IdBIll = BillInfo.IdBill", db.getConnection);
            SqlDataAdapter apt = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            apt.Fill(table);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = table;

            long total = 0;
            for( int i = 0; i < table.Rows.Count; i++)
            {    
                    total += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }

            label_Total.Text = "Restaurant's income: " +total.ToString();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string dateFrom = dateTimePicker_From.Value.ToString("yyyy-MM-dd");
            string dateTo = dateTimePicker_To.Value.ToString("yyyy-MM-dd");
            string query = "SELECT Bill.IdBill,Bill.idTable, Bill.money, Bill.checkIn, Bill.checkOut,Dish.name AS 'Dish' ,BillInfo.Amount" +
                " FROM [Bill],[Dish],[BillInfo] WHERE Dish.Id = BillInfo.IdDish AND Bill.IdBIll = BillInfo.IdBill AND Bill.checkOut BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
            int id = 0;
            if (textBox_tableId.Text.Trim() != "")
            {
                query += " AND Bill.idTable = @idT";
                 id = Convert.ToInt32(textBox_tableId.Text.ToString());
            }
            SqlCommand command = new SqlCommand(query, db.getConnection);
           
            command.Parameters.Add("@idT",SqlDbType.Int).Value =id;
            //
            SqlDataAdapter apt = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            apt.Fill(table);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = table;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            ShowAllBills();
        }
    }
}
