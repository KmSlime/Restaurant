using Restaurant;
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

namespace final_Project
{
    public partial class CustomerLogin : Form
    {
        BillCs bill = new BillCs();
        TablesCs tables = new TablesCs();
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_Id.Text.ToString());
            Global.SetGlobalTableId(id);
            DateTime time = DateTime.Now;
            if (tables.Exist(id))
            {
                if (tables.CheckEmptyTable(id))
                {
                    if (bill.InsertBill(Global.GlobalTableId, time))
                    {
                        MessageBox.Show("Welcom to our Restaurant", "Actice form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string state = "busy";
                        int people = Convert.ToInt32(numericUpDown1.Value.ToString());
                        tables.UpdateTable(Global.GlobalTableId, people, state);
                        MenuForm menuForm = new MenuForm();
                        menuForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Something wrong happened :(", "Actice form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Tables is using", "Actice form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The tables is not exist!!!", "Tables Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void Table_Login_Load(object sender, EventArgs e)
        {

        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Login_Click_1(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(textBox_Id.Text.ToString());
                Global.SetGlobalTableId(id);
                DateTime time = DateTime.Now;
                if (tables.Exist(id))
                {
                    if (tables.CheckEmptyTable(id))
                    {
                        if (bill.InsertBill(Global.GlobalTableId, time))
                        {
                            MessageBox.Show("Welcom to our Restaurant", "Actice form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string state = "busy";
                            int people = Convert.ToInt32(numericUpDown1.Value.ToString());
                            tables.UpdateTable(Global.GlobalTableId, people, state);
                            MenuForm menuForm = new MenuForm();
                            menuForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Something wrong happened :(", "Actice form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Tables is using", "Actice form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The tables is not exist!!!", "Tables Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            
        }
    }
}
