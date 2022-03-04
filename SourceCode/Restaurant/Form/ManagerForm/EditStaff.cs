using csFile.EmployeeCs;
using Restaurant.ManagerCs;
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
    public partial class EditStaff : Form
    {
        public EditStaff()
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*png;*gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                Manager manager = new Manager();
                int id = Convert.ToInt32(IDBox.Text);
                string fname = fnameBox.Text;
                string lname = lnameBox.Text;
                string username = usernameBox.Text;
                DateTime bdate = bDateBox.Value.Date;
                string phone = phoneBox.Text;
                string adrs = addressBox.Text;
                MemoryStream picture = new MemoryStream();

                pictureBox.Image.Save(picture, pictureBox.Image.RawFormat);

                if (manager.editStaff(id, fname, lname, bdate, username, phone, adrs, picture))
                {
                    MessageBox.Show("The information was changed");
                }
                else
                {
                    MessageBox.Show("There was an error");
                }
            } catch
            {
                MessageBox.Show("Please choose a Staff to edit !!!");
            }
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            DataTable table = employee.getAllEmployee();
            listStaffView.DataSource = table;
            listStaffView.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            listStaffView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            picCol = (DataGridViewImageColumn)listStaffView.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            listStaffView.AllowUserToAddRows = false;

            listStaffView.Columns[0].HeaderText = "ID";
            listStaffView.Columns[1].HeaderText = "First Name";
            listStaffView.Columns[2].HeaderText = "Last Name";
            listStaffView.Columns[3].HeaderText = "Username";
            listStaffView.Columns[4].HeaderText = "Birth Date";
            listStaffView.Columns[5].HeaderText = "Phone Number";
            listStaffView.Columns[6].HeaderText = "Address";
            listStaffView.Columns[7].HeaderText = "Picture";

            totalLabel.Text += " " + table.Rows.Count;
        }

        private void listStaffView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            IDBox.Text = listStaffView.CurrentRow.Cells[0].Value.ToString();
            fnameBox.Text = listStaffView.CurrentRow.Cells[1].Value.ToString();
            lnameBox.Text = listStaffView.CurrentRow.Cells[2].Value.ToString();
            bDateBox.Value = (DateTime)listStaffView.CurrentRow.Cells[4].Value;
            usernameBox.Text = listStaffView.CurrentRow.Cells[3].Value.ToString();
            phoneBox.Text = listStaffView.CurrentRow.Cells[5].Value.ToString();
            addressBox.Text = listStaffView.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])listStaffView.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox.Image = Image.FromStream(picture);
        }
    }
}
