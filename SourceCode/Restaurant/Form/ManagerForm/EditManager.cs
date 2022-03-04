using Restaurant.csFile.MainCs;
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
    public partial class EditManager : Form
    {
        public EditManager()
        {
            InitializeComponent();
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
                Manager manager = new Manager();
                int id = Convert.ToInt32(Global.ManagerID);
                string fname = fnameBox.Text;
                string lname = lnameBox.Text;
                string username = usernameBox.Text;
                DateTime bdate = bDateBox.Value.Date;
                string phone = phoneBox.Text;
                string adrs = addressBox.Text;
                MemoryStream picture = new MemoryStream();

                pictureBox.Image.Save(picture, pictureBox.Image.RawFormat);

                if (manager.editManager(id, fname, lname, bdate, username, phone, adrs, picture))
                {
                    MessageBox.Show("The information was changed");
                }
                else
                {
                    MessageBox.Show("There was an error");
                }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditManager_Load(object sender, EventArgs e)
        {
            Manager manager = new Manager();

            DataTable table = manager.getManagerInfo(Global.ManagerID);

            usernameBox.Text = table.Rows[0][1].ToString();
            fnameBox.Text = table.Rows[0][2].ToString();
            lnameBox.Text = table.Rows[0][3].ToString();
            phoneBox.Text = table.Rows[0][5].ToString();
            addressBox.Text = table.Rows[0][6].ToString();

            byte[] pic;
            pic = (byte[])table.Rows[0][7];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox.Image = Image.FromStream(picture);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
