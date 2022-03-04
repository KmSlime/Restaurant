using csFile.EmployeeCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class AddStaff : Form
    {

        public AddStaff()
        {
            InitializeComponent();
        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            Employee employee = new Employee();
            string lname = lnameBox.Text;
            string fname = fnameBox.Text;
            string phone = phoneBox.Text;
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string address = addressBox.Text;
            DateTime bdate = bDateBox.Value.Date;

            MemoryStream pic = new MemoryStream();
            if (employee.checkExis(username))
            {
                if (verif())
                {
                    pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                    if (employee.addEmployee(fname, lname, username, password, bdate, phone, address, pic))
                    {
                        MessageBox.Show("Staff Added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Username Available !!!");
            }



            bool verif()
            {
                if ((lnameBox.Text == "")
                    || (fnameBox.Text == "")
                        || (addressBox.Text == "")
                        || (phoneBox.Text == "")
                        || (usernameBox.Text == "")
                        || (passwordBox.Text == "")
                        || (pictureBox.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*png;*gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
