using csFile.CalendarCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class ShowManagerCalendar : Form
    {
        Calendar calendar = new Calendar();
        public ShowManagerCalendar()
        {
            InitializeComponent();
        }

        private void ShowManagerCalendar_Load(object sender, EventArgs e)
        {
            DataTable table = calendar.getManagerCalendar();

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


            calendarView.DataSource = tableCloned;
            calendarView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            calendarView.Columns[0].HeaderText = "Day";
            calendarView.Columns[1].HeaderText = "Shift";
        }
    }
}
