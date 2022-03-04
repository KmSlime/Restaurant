
namespace final_Project
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.button_ShowMenu = new System.Windows.Forms.Button();
            this.listView_ShowFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_Dish = new System.Windows.Forms.PictureBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_comment = new System.Windows.Forms.Label();
            this.comboBox_Kind = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ShowBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dish)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ShowMenu
            // 
            this.button_ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowMenu.Location = new System.Drawing.Point(906, 25);
            this.button_ShowMenu.Name = "button_ShowMenu";
            this.button_ShowMenu.Size = new System.Drawing.Size(220, 36);
            this.button_ShowMenu.TabIndex = 1;
            this.button_ShowMenu.Text = "Show All";
            this.button_ShowMenu.UseVisualStyleBackColor = true;
            this.button_ShowMenu.Click += new System.EventHandler(this.button_ShowMenu_Click);
            // 
            // listView_ShowFood
            // 
            this.listView_ShowFood.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView_ShowFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_ShowFood.HideSelection = false;
            this.listView_ShowFood.LargeImageList = this.imageList1;
            this.listView_ShowFood.Location = new System.Drawing.Point(12, 25);
            this.listView_ShowFood.Name = "listView_ShowFood";
            this.listView_ShowFood.Size = new System.Drawing.Size(286, 527);
            this.listView_ShowFood.SmallImageList = this.imageList1;
            this.listView_ShowFood.TabIndex = 2;
            this.listView_ShowFood.UseCompatibleStateImageBehavior = false;
            this.listView_ShowFood.SelectedIndexChanged += new System.EventHandler(this.listView_ShowFood_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dish";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(170, 90);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox_Dish
            // 
            this.pictureBox_Dish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_Dish.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Dish.Image")));
            this.pictureBox_Dish.Location = new System.Drawing.Point(325, 25);
            this.pictureBox_Dish.Name = "pictureBox_Dish";
            this.pictureBox_Dish.Size = new System.Drawing.Size(547, 330);
            this.pictureBox_Dish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Dish.TabIndex = 3;
            this.pictureBox_Dish.TabStop = false;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(6, 55);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(71, 32);
            this.label_Price.TabIndex = 4;
            this.label_Price.Text = "Price";
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comment.Location = new System.Drawing.Point(6, 104);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(117, 32);
            this.label_comment.TabIndex = 5;
            this.label_comment.Text = "Comment";
            // 
            // comboBox_Kind
            // 
            this.comboBox_Kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Kind.FormattingEnabled = true;
            this.comboBox_Kind.Location = new System.Drawing.Point(906, 67);
            this.comboBox_Kind.Name = "comboBox_Kind";
            this.comboBox_Kind.Size = new System.Drawing.Size(220, 33);
            this.comboBox_Kind.TabIndex = 6;
            this.comboBox_Kind.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kind_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Amount);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Controls.Add(this.label_Price);
            this.groupBox1.Controls.Add(this.label_comment);
            this.groupBox1.Location = new System.Drawing.Point(325, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 191);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Segoe Script", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.ForeColor = System.Drawing.Color.Red;
            this.label_Amount.Location = new System.Drawing.Point(332, 16);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(114, 54);
            this.label_Amount.TabIndex = 11;
            this.label_Amount.Text = "State";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.White;
            this.label_name.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.Maroon;
            this.label_name.Location = new System.Drawing.Point(6, 16);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(74, 33);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Name";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(906, 450);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(220, 34);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_amount.Location = new System.Drawing.Point(906, 391);
            this.numericUpDown_amount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(220, 30);
            this.numericUpDown_amount.TabIndex = 12;
            this.numericUpDown_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(906, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(220, 249);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_ShowBill
            // 
            this.button_ShowBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowBill.Location = new System.Drawing.Point(906, 518);
            this.button_ShowBill.Name = "button_ShowBill";
            this.button_ShowBill.Size = new System.Drawing.Size(220, 34);
            this.button_ShowBill.TabIndex = 14;
            this.button_ShowBill.Text = "Show bill";
            this.button_ShowBill.UseVisualStyleBackColor = true;
            this.button_ShowBill.Click += new System.EventHandler(this.button_ShowBill_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 564);
            this.Controls.Add(this.button_ShowBill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown_amount);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_Kind);
            this.Controls.Add(this.pictureBox_Dish);
            this.Controls.Add(this.listView_ShowFood);
            this.Controls.Add(this.button_ShowMenu);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dish)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_ShowMenu;
        private System.Windows.Forms.ListView listView_ShowFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox_Dish;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.ComboBox comboBox_Kind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.NumericUpDown numericUpDown_amount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ShowBill;
    }
}