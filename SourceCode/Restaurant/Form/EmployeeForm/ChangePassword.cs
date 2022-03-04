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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if(newPassBox.Text == confirmBox.Text)
            {
                if(employee.changePassword(newPassBox.Text))
                {
                    MessageBox.Show("Your Password was changed");
                }
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
