using csFile.CalendarCs;
using csFile.EmployeeCs;
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
    public partial class MyCalendar : Form
    {
        MY_DB mydb = new MY_DB();
        Calendar calendar = new Calendar();
        EmployeeSalary salary = new EmployeeSalary();

        public MyCalendar()
        {
            InitializeComponent();
        }

        private void MyShift_Load(object sender, EventArgs e)
        {
            removeButton.Enabled = false;
            Employee employee = new Employee();
            Calendar calendar = new Calendar();

            DataTable table = employee.getShift(Global.StaffID);

            DataTable tableCloned = table.Clone();
            tableCloned.Columns[0].DataType = typeof(string);
            foreach (DataRow row in table.Rows)
            {
                tableCloned.ImportRow(row);
            }

            for (int i = 0; i <tableCloned.Rows.Count; i++)
            {
                tableCloned.Rows[i][0] = calendar.convertToDay(Convert.ToInt32(table.Rows[i][0]));
            }


            myShiftView.DataSource = tableCloned;
            myShiftView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            myShiftView.Columns[0].HeaderText = "Day";
            myShiftView.Columns[1].HeaderText = "Shift";

        }

        private void myShiftView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            removeButton.Enabled = true;
            dayBox.Text = myShiftView.CurrentRow.Cells[0].Value.ToString();
            shiftBox.Text = myShiftView.CurrentRow.Cells[1].Value.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE calendar SET employee_id = 0 WHERE day=@day AND shift=@shift", mydb.getConnection);
            cmd.Parameters.Add("@day", SqlDbType.Int).Value = calendar.convertToInt(dayBox.Text);
            cmd.Parameters.Add("@shift", SqlDbType.Int).Value = Convert.ToInt32(shiftBox.Text);

            mydb.openConnection();

            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Removed Shift");
                if(salary.fined(400))
                {

                }

                mydb.closeConnection();
            }
            else
            {
                mydb.closeConnection();
            }
        }
    }
}
