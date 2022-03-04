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
    public partial class Tables : Form
    {
        MY_DB db = new MY_DB();
        TablesCs tables = new TablesCs();
        BillInfo billinfo = new BillInfo();
       
        public Tables()
        {
            InitializeComponent();
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            LoadTable();  
        }
        public void LoadTable()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Tables]", db.getConnection);
            dataGridView_tableList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_tableList.RowTemplate.Height = 40;
            dataGridView_tableList.DataSource = tables.AllTheTable(command);

            dataGridView_tableList.Columns[0].HeaderText = "ID";
            dataGridView_tableList.Columns[1].HeaderText = "People";
            dataGridView_tableList.Columns[2].HeaderText = "State";


        }

        
       
        private void button_AddTable_Click(object sender, EventArgs e)
        {
            int people = 0;
            string state = "Empty";
         if(  tables.InsertTable(people, state))
            {
                LoadTable();
            }
         else
            {
                MessageBox.Show("Somrthing is wrong", "Table Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button_EditTable_Click(object sender, EventArgs e)
        {
          
          
          
           
        }

        private void dataGridView_tableList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_tableList.CurrentRow.Cells[2].Value.ToString() == "busy")
            {
                int tableId = Convert.ToInt32(dataGridView_tableList.CurrentRow.Cells[0].Value.ToString());
                DataTable table = new DataTable();
                table = billinfo.TakeIDBill(tableId);
                int Idbill = Convert.ToInt32(table.Rows[0][1].ToString());
                DataTable BillTable = new DataTable();
                BillTable = billinfo.TableInfo(Idbill, tableId);
                dataGridView_TableInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_TableInfo.RowTemplate.Height = 80;
                
                dataGridView_TableInfo.DataSource = BillTable;
            }
            else
            {
                MessageBox.Show("The table empty", "Tables form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
        }

        private void button_DeleteTable_Click(object sender, EventArgs e)
        {
            int idtable =Convert.ToInt32(dataGridView_tableList.CurrentRow.Cells[0].Value.ToString());
            if(MessageBox.Show("Do you want to Delete this table","Table form",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(tables.RemoveTable(idtable))
                {
                    MessageBox.Show("The table have been remove", "Table form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Somrthing is wrong", "Table Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
