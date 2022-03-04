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

namespace Restaurant.ManagerForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uploadPic_Click(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            if (manager.getAllManager().Rows.Count < 2)
            {
                string lname = lnameBox.Text;
                string fname = fnameBox.Text;
                string phone = phoneBox.Text;
                string username = usernameBox.Text;
                string password = passwordBox.Text;
                string address = addressBox.Text;
                DateTime bdate = bDateBox.Value.Date;

                MemoryStream pic = new MemoryStream();
                if (manager.checkExis(username))
                {
                    if (verif())
                    {
                        pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                        if (manager.addManager(fname, lname, username, password, bdate, phone, address, pic))
                        {
                            MessageBox.Show("Manager Added", "Add Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Field", "Add Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Username Available !!!");
                }
            } else
            {
                MessageBox.Show("Maximum Manger is 2 !!!");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
