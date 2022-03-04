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
    public partial class AccountingManagerSalary : Form
    {

        ManagerSalary salary = new ManagerSalary();
        public AccountingManagerSalary()
        {
            InitializeComponent();
        }

        private void AccountingManagerSalary_Load(object sender, EventArgs e)
        {
            myFinesLabel.Text += " " + Global.ManagerFine;
            mySalaryLabel.Text += " " + salary.getSalary().ToString();

            totalLabel.Text += " " + (salary.getSalary() - Global.ManagerFine).ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
