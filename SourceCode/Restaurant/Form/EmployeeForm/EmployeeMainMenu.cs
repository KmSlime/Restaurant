using csFile.CalendarCs;
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

namespace Restaurant
{
    public partial class EmployeeMainMenu : Form
    {
        MY_DB mydb = new MY_DB();
        Calendar calendar = new Calendar();
        EmployeeSalary salary = new EmployeeSalary();

        public EmployeeMainMenu()
        {
            InitializeComponent();
        }

        private void employeeMainMenu_Load(object sender, EventArgs e)
        {
            getEmployeeImgAndUsername(Global.StaffID);
            if(salary.mySalary())
            {

            }

            Global.fine(Global.getFine());
        }

        public void getEmployeeImgAndUsername(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT username, picture FROM employee WHERE id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            byte[] pic;
            pic = (byte[])table.Rows[0][1];
            MemoryStream picture = new MemoryStream(pic);
            imgPanel.BackgroundImage = Image.FromStream(picture);
            imgPanel.BackgroundImageLayout = ImageLayout.Stretch;
            welcomeLabel.Text += "(" + table.Rows[0][0] + ")";
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myInfoButton_Click(object sender, EventArgs e)
        {
            MyInfo info = new MyInfo();
            info.Show();
        }

        private void calendatButton_Click(object sender, EventArgs e)
        {
            MyCalendar calendar = new MyCalendar();
            calendar.Show();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            int day = calendar.convertToInt(DateTime.Now.DayOfWeek.ToString());
            DateTime checkin = DateTime.Now;

            SqlCommand cmd = new SqlCommand("UPDATE calendar SET checkin=@checkin WHERE shift=@shift AND day=@day", mydb.getConnection);
            cmd.Parameters.Add("@day", SqlDbType.Int).Value = day;
            cmd.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;

            TimeSpan shift1Lower = new TimeSpan(7, 0, 0);
            TimeSpan shift1Upper = new TimeSpan(7, 5, 0);
            TimeSpan shift2Lower = new TimeSpan(11, 0, 0);
            TimeSpan shift2Upper = new TimeSpan(11, 5, 0);
            TimeSpan shift3Lower = new TimeSpan(18, 0, 0);
            TimeSpan shift3Upper = new TimeSpan(18, 5, 0);
            TimeSpan shift1End = new TimeSpan(11, 0, 0);
            TimeSpan shift2End = new TimeSpan(14, 0, 0);
            TimeSpan shift3End = new TimeSpan(22, 0, 0);


            int shift;

            if(checkin.TimeOfDay < shift1Upper && checkin.TimeOfDay > shift1Lower)
            {
                shift = 1;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    mydb.closeConnection();
                } else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }

            } else if(checkin.TimeOfDay < shift1End && checkin.TimeOfDay > shift1Lower)
            {
                shift = 1;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    MessageBox.Show("You are late !!!");

                    salary.fined(100);

                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }

            } else if(checkin.TimeOfDay < shift2Upper && checkin.TimeOfDay > shift2Lower)
            {
                shift = 2;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else if (checkin.TimeOfDay < shift2End && checkin.TimeOfDay > shift2Lower)
            {
                shift = 2;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    MessageBox.Show("You are late !!!");

                    salary.fined(100);

                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else if(checkin.TimeOfDay < shift3Upper && checkin.TimeOfDay > shift3Lower)
            {
                shift = 3;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else if (checkin.TimeOfDay < shift3End && checkin.TimeOfDay > shift3Lower)
            {
                shift = 3;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    MessageBox.Show("You are late !!!");

                    salary.fined(100);

                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else {
                MessageBox.Show("It's Not Time To Checkin");
            }
                           
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            int day = calendar.convertToInt(DateTime.Now.DayOfWeek.ToString());
            DateTime checkin = DateTime.Now;

            SqlCommand cmd = new SqlCommand("UPDATE calendar SET checkout=@checkout WHERE shift=@shift AND day=@day", mydb.getConnection);
            cmd.Parameters.Add("@day", SqlDbType.Int).Value = day;
            cmd.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkin;

            TimeSpan shift1Lower = new TimeSpan(11, 0, 0);
            TimeSpan shift1Upper = new TimeSpan(11, 5, 0);
            TimeSpan shift2Lower = new TimeSpan(14, 0, 0);
            TimeSpan shift2Upper = new TimeSpan(14, 5, 0);
            TimeSpan shift3Lower = new TimeSpan(22, 0, 0);
            TimeSpan shift3Upper = new TimeSpan(22, 5, 0);
            TimeSpan shift2Start = new TimeSpan(11, 0, 0);
            TimeSpan shift3Start = new TimeSpan(14, 0, 0);


            int shift;

            if (checkin.TimeOfDay < shift1Upper && checkin.TimeOfDay > shift1Lower)
            {
                shift = 1;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkout Completed");
                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }


            }
            else if (checkin.TimeOfDay < shift2Start && checkin.TimeOfDay > shift1Upper)
            {
                shift = 1;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkout Completed");
                    MessageBox.Show("Missing Checkout Time, You Got Fined !!!");
                    salary.fined(100);


                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else if (checkin.TimeOfDay < shift2Upper && checkin.TimeOfDay > shift2Lower)
            {
                shift = 2;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else if (checkin.TimeOfDay < shift3Start && checkin.TimeOfDay > shift2Upper)
            {
                shift = 2;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    MessageBox.Show("Missing Checkout Time, You Got Fined !!!");

                    salary.fined(100);

                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else if (checkin.TimeOfDay < shift3Upper && checkin.TimeOfDay > shift3Lower)
            {
                shift = 3;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else if (checkin.TimeOfDay > shift3Upper)
            {
                shift = 3;
                cmd.Parameters.Add("@shift", SqlDbType.Int).Value = shift;

                mydb.openConnection();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Checkin Completed");
                    MessageBox.Show("Missing Checkout Time, You Got Fined !!!");

                    salary.fined(100);

                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("You Don't Have Shift Today");
                    mydb.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("It's Not Time To Checkout");
            }
        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            Global.fine(Global.getFine());
            AccountingSalary accounting = new AccountingSalary();
            accounting.Show();
        }

        private void availableButton_Click(object sender, EventArgs e)
        {
            AvailableShift shift = new AvailableShift();
            shift.Show();
        }

        private void newSalaryDatabutton_Click(object sender, EventArgs e)
        {
            EmployeeSalary staffSalary = new EmployeeSalary();

            staffSalary.addToSalaryData(Convert.ToInt32(Global.StaffID));
        }
    }
}
