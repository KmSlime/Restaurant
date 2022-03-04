using csFile.EmployeeCs;
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
    public partial class MyInfo : Form
    {
        public MyInfo()
        {
            InitializeComponent();
        }

        private void MyInfo_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            myInfoView.DataSource = employee.getEmployeeInfo(Global.StaffID);

            myInfoView.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            myInfoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            picCol = (DataGridViewImageColumn)myInfoView.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            myInfoView.AllowUserToAddRows = false;

            myInfoView.Columns[0].HeaderText = "ID";
            myInfoView.Columns[1].HeaderText = "First Name";
            myInfoView.Columns[2].HeaderText = "Last Name";
            myInfoView.Columns[3].HeaderText = "Birth Date";
            myInfoView.Columns[4].HeaderText = "Phone Number";
            myInfoView.Columns[5].HeaderText = "Address";
            myInfoView.Columns[6].HeaderText = "Picture";
        }
    }
}
