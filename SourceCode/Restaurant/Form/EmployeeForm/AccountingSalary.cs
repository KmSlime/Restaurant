using Restaurant.csFile.MainCs;
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
    public partial class AccountingSalary : Form
    {
        EmployeeSalary salary = new EmployeeSalary();
        public AccountingSalary()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountingSalary_Load(object sender, EventArgs e)
        {
            myFinesLabel.Text += " " + Global.StaffFine;
            mySalaryLabel.Text += " " + salary.getSalary().ToString();

            totalLabel.Text += " " + (salary.getSalary() - Global.StaffFine).ToString();
        }
    }
}
