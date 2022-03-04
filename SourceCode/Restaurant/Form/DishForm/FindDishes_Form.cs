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

    public partial class FindDishes_Form : Form
    {
        MY_DB db = new MY_DB();
        public FindDishes_Form()
        {
            InitializeComponent();
            SqlCommand command = new SqlCommand("SELECT id,name,price,pic,comment,kind FROM [Dish] ", db.getConnection);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adp.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
        }

        private void FindDishes_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
