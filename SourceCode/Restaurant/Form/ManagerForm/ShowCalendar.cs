using csFile.CalendarCs;
using csFile.EmployeeCs;
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
    public partial class ShowCalendar : Form
    {
        public ShowCalendar()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void ShowCalendar_Load(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            Employee employee = new Employee();

            slot0.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[0][3]));
            slot1.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[1][3]));
            slot2.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[2][3]));
            slot3.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[3][3]));
            slot4.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[4][3]));
            slot5.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[5][3]));
            slot6.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[6][3]));
            slot7.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[7][3]));
            slot8.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[8][3]));
            slot9.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[9][3]));
            slot10.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[10][3]));
            slot11.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[11][3]));
            slot12.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[12][3]));
            slot13.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[13][3]));
            slot14.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[14][3]));
            slot15.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[15][3]));
            slot16.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[16][3]));
            slot17.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[17][3]));
            slot18.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[18][3]));
            slot19.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[19][3]));
            slot20.Text = employee.getNameByID(Convert.ToInt32(calendar.getCalendar().Rows[20][3]));

        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slot0_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
