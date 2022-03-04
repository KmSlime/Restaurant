using csFile.CalendarCs;
using csFile.EmployeeCs;
using final_Project;
using Restaurant.csFile.MainCs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp2;


namespace Restaurant
{
    public partial class ManagerMainMenu : Form
    {
        MY_DB mydb = new MY_DB();
        Calendar calendar = new Calendar();
        ManagerSalary salary = new ManagerSalary();
        EmployeeSalary staffSalary = new EmployeeSalary();

        public ManagerMainMenu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            AddStaff add = new AddStaff();           
            add.Show();
        }



        private void removeStaffButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            try
            {
                if (employee.removeEmployee(Convert.ToInt32(staffIDBox.Text)))
                {
                    if(staffSalary.removeFromSalaryData(Convert.ToInt32(staffIDBox.Text))) {
                        MessageBox.Show("Staff Removed");
                    }
                }
            } catch
            {
                MessageBox.Show("Please input ID again !!!");
            }
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerMainMenu_Load(object sender, EventArgs e)
        {
            getManagerImgAndUsername(Global.ManagerID);
            if (salary.mySalary())
            {

            }

            Global.managerFine(Global.getManagerFine());
        }

        public void getManagerImgAndUsername(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT username, picture FROM manager WHERE id = @id", mydb.getConnection);
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

        private void showStaffButton_Click(object sender, EventArgs e)
        {
            ShowFullStaff show = new ShowFullStaff();
            show.Show();
        }

        private void newCalendarButton_Click(object sender, EventArgs e)
        {

            Calendar calendar = new Calendar();
            calendar.removeSchedule();
            calendar.removeManagerSchedule();
            calendar.newSalary();
            calendar.newManagerSalary();

            if(calendar.scheduling())
            {
                MessageBox.Show("New Schedule successful");
            } else
            {
                MessageBox.Show("Error");
            }
        }

        private void editStaffButton_Click(object sender, EventArgs e)
        {
            EditStaff edit = new EditStaff();
            edit.Show();
        }

        private void showCalendarButton_Click(object sender, EventArgs e)
        {
            ShowCalendar show = new ShowCalendar();
            show.Show();
        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {
            ChangeManagerPassword change = new ChangeManagerPassword();
            change.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditManager edit = new EditManager();
            edit.Show();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            WareHouseForm stock = new WareHouseForm();
            stock.Show();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.ShowDialog();
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            Tables table = new Tables();
            table.Show();
        }

        private void dishButton_Click(object sender, EventArgs e)
        {
            Dishes dishes = new Dishes();
            dishes.Show();
        }

        private void showManagerButton_Click(object sender, EventArgs e)
        {
            ShowManagerCalendar calendar = new ShowManagerCalendar();
            calendar.Show();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            int day = calendar.convertToInt(DateTime.Now.DayOfWeek.ToString());
            DateTime checkin = DateTime.Now;

            SqlCommand cmd = new SqlCommand("UPDATE manager_calendar SET checkin=@checkin WHERE shift=@shift AND day=@day", mydb.getConnection);
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

            if (checkin.TimeOfDay < shift1Upper && checkin.TimeOfDay > shift1Lower)
            {
                shift = 1;
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
            else if (checkin.TimeOfDay < shift1End && checkin.TimeOfDay > shift1Lower)
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
            else
            {
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

        private void accountingButton_Click(object sender, EventArgs e)
        {
            Global.managerFine(Global.getManagerFine());
            AccountingManagerSalary accounting = new AccountingManagerSalary();
            accounting.Show();
        }
    }
}
