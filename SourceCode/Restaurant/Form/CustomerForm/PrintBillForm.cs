using Microsoft.Office.Interop.Word;
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
using DataTable = System.Data.DataTable;
using Global = Restaurant.csFile.MainCs.Global;

namespace final_Project
{
    public partial class PrintBillForm : Form
    {
        BillInfo billinfo =new BillInfo();
        BillCs bill = new BillCs();
        TablesCs tables = new TablesCs();
        Stock stock = new Stock();
        Recipe recipe = new Recipe();
        public PrintBillForm()
        {
            InitializeComponent();
        }

        private void PrintBillForm_Load(object sender, EventArgs e)
        {
            ShowTheirChoice();
           
        }

        public void ShowTheirChoice()
        {
            int TableId = Global.GlobalTableId;
            DataTable table = new DataTable();
            table = billinfo.TakeIDBill(TableId);
            int IdBill = Convert.ToInt32(table.Rows[0][1]);
            DataTable tableShowBill = new System.Data.DataTable();
            tableShowBill = billinfo.SelectBillInfo(IdBill, TableId);
            tableShowBill.Columns.Add("Total", typeof(string));
            for (int i = 0; i < tableShowBill.Rows.Count; i++)
            {
                int total = 0;
                total = Convert.ToInt32(tableShowBill.Rows[i][2]) * Convert.ToInt32(tableShowBill.Rows[i][1]);
                tableShowBill.Rows[i][3] = total;
            }
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = tableShowBill;
            // tru vao kho 
            for( int i = 0; i < tableShowBill.Rows.Count - 1; i++)
            {
                string name = tableShowBill.Rows[i][0].ToString();
                DataTable tableForStock = new DataTable();
                tableForStock =  recipe.FindIdbyName(name);     // Find ID Dish
                int DishID = Convert.ToInt32(tableForStock.Rows[i][0].ToString());
                DataTable FindRecipe = new DataTable();
                FindRecipe = recipe.FindRecipe(DishID);
                for ( int j = 0; j <FindRecipe.Rows.Count; j++)
                {
                    int MaterialId = Convert.ToInt32(FindRecipe.Rows[j][1]);
                    int NewUsed = Convert.ToInt32(FindRecipe.Rows[j][3].ToString()) * Convert.ToInt32(tableShowBill.Rows[i][2].ToString());
                    DataTable tableUseToTakeOldUsed = stock.FindAllstock(MaterialId);
                    int OldUsed = Convert.ToInt32(tableUseToTakeOldUsed.Rows[j][6].ToString());
                    int TotalUsed = NewUsed + OldUsed;
                    if(stock.UpdateUsed(MaterialId, TotalUsed))
                    { 
                    }
                    else
                    {
                        MessageBox.Show("Something wrong happend", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                
            }
            long TotalBill = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TotalBill += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            label_Total.Text ="Total Bill: " +  TotalBill.ToString();
           
        }

        private void button_Paid_Click(object sender, EventArgs e)
        {
            int TableId = Global.GlobalTableId;
            DataTable table = new DataTable();
            table = billinfo.TakeIDBill(TableId);
            int IdBill = Convert.ToInt32(table.Rows[0][1]);
            DateTime time = DateTime.Now;
            long TotalBill = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                TotalBill += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
           if( bill.UpDateBill(TableId, IdBill, time, TotalBill.ToString()))
           {
                MessageBox.Show("Hope to see you again ^_^","Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string state = "Empty";
                tables.UpdateTable(TableId, 0, state);
            }
           else
             {
                MessageBox.Show("Something wrong happend", "Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          

        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridView1, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int rowCount = DGV.Rows.Count;
                int columnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[rowCount + 1, columnCount + 1];

                int r = 0;
                for (int c = 0; c <= columnCount - 1; c++)
                {
                    for (r = 0; r <= rowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= rowCount - 1; r++)
                {
                    for (int c = 0; c <= columnCount - 1; c++)
                    {
                        oTemp += DataArray[r, c] + "\t";
                    }
                }
                oRange.Text = oTemp;
                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref rowCount, ref columnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                for (int c = 0; c <= columnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "your header text";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }



                oDoc.SaveAs(filename);
            }
        }
        }
}
