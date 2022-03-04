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
    public partial class AllTheDishesForm : Form
    {
        MY_DB db = new MY_DB();
        public AllTheDishesForm()
        {
            InitializeComponent();
        }

        private void AllTheDishesForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        public void FormLoad()
        {
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlCommand command = new SqlCommand("SELECT id,name,price,pic FROM [Dish] ", db.getConnection);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adp.Fill(table);
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        private void button_find_Click(object sender, EventArgs e)
        {
            string max = numericUpDown_Max.Value.ToString();
            string min = numericUpDown_min.Value.ToString();
            SqlCommand command = new SqlCommand("SELECT id,name,price,pic FROM [Dish] WHERE price > @min AND price < @max ", db.getConnection);
            command.Parameters.Add("@min", SqlDbType.NVarChar).Value = min;
            command.Parameters.Add("@max", SqlDbType.NVarChar).Value = max;
            SqlDataAdapter adt = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adt.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
