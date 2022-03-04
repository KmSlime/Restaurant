using Restaurant.ManagerCs;
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
    public partial class ChangeManagerPassword : Form
    {
        public ChangeManagerPassword()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            if (newPassBox.Text == confirmBox.Text)
            {
                if (manager.changePassword(newPassBox.Text))
                {
                    MessageBox.Show("Your Password was changed");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
