using csFile.CalendarCs;
using Restaurant.csFile.MainCs;
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

namespace Restaurant
{
    public partial class AvailableShift : Form
    {
        MY_DB mydb = new MY_DB();
        Calendar calendar = new Calendar();
        EmployeeSalary salary = new EmployeeSalary();

        public AvailableShift()
        {
            InitializeComponent();
        }

        private void availableShiftView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getButton.Enabled = true;
            dayBox.Text = availableShiftView.CurrentRow.Cells[0].Value.ToString();
            shiftBox.Text = availableShiftView.CurrentRow.Cells[1].Value.ToString();
        }

        private void getButton_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("UPDATE calendar SET employee_id = @id WHERE day=@day AND shift=@shift", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Global.StaffID;
            cmd.Parameters.Add("@day", SqlDbType.Int).Value = calendar.convertToInt(dayBox.Text);
            cmd.Parameters.Add("@shift", SqlDbType.Int).Value = Convert.ToInt32(shiftBox.Text);

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Get Shift Succesful");
                if (salary.bonus(400))
                {

                }
                mydb.closeConnection();
            }
            else
            {
                mydb.closeConnection();
            }
        }

        private void AvailableShift_Load(object sender, EventArgs e)
        {
            DataTable table = calendar.availableShift();

            DataTable tableCloned = table.Clone();
            tableCloned.Columns[0].DataType = typeof(string);
            foreach (DataRow row in table.Rows)
            {
                tableCloned.ImportRow(row);
            }

            for (int i = 0; i < tableCloned.Rows.Count; i++)
            {
                tableCloned.Rows[i][0] = calendar.convertToDay(Convert.ToInt32(table.Rows[i][0]));
            }


            availableShiftView.DataSource = tableCloned;
            availableShiftView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            availableShiftView.Columns[0].HeaderText = "Day";
            availableShiftView.Columns[1].HeaderText = "Shift";
        }
    }
}
