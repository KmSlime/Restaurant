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
    public partial class ShowFullStaff : Form
    {
        public ShowFullStaff()
        {
            InitializeComponent();
        }

        private void ShowFullStaff_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            listStaffView.DataSource = employee.getAllEmployee();

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


        }
    }
}
