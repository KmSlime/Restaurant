
namespace final_Project
{
    partial class WareHouseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_ShowAdd = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.groupBox_Information = new System.Windows.Forms.GroupBox();
            this.button_EditMaterial = new System.Windows.Forms.Button();
            this.textBox_Kind = new System.Windows.Forms.TextBox();
            this.button_AddMaterial = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_TimeEdit = new System.Windows.Forms.Label();
            this.dateTimePicker_Edit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Material = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.groupBox_Find = new System.Windows.Forms.GroupBox();
            this.button_ShowAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MaterialFind = new System.Windows.Forms.TextBox();
            this.button_Find = new System.Windows.Forms.Button();
            this.dateTimePicker_DateTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_FindKind = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_Information.SuspendLayout();
            this.groupBox_Find.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(777, 434);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.Location = new System.Drawing.Point(12, 231);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(329, 30);
            this.button_Edit.TabIndex = 10;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_ShowAdd
            // 
            this.button_ShowAdd.BackColor = System.Drawing.Color.BurlyWood;
            this.button_ShowAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowAdd.Location = new System.Drawing.Point(12, 150);
            this.button_ShowAdd.Name = "button_ShowAdd";
            this.button_ShowAdd.Size = new System.Drawing.Size(329, 36);
            this.button_ShowAdd.TabIndex = 11;
            this.button_ShowAdd.Text = "Add";
            this.button_ShowAdd.UseVisualStyleBackColor = false;
            this.button_ShowAdd.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(12, 192);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(329, 33);
            this.button_Remove.TabIndex = 12;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // groupBox_Information
            // 
            this.groupBox_Information.Controls.Add(this.button_EditMaterial);
            this.groupBox_Information.Controls.Add(this.textBox_Kind);
            this.groupBox_Information.Controls.Add(this.button_AddMaterial);
            this.groupBox_Information.Controls.Add(this.label7);
            this.groupBox_Information.Controls.Add(this.label_TimeEdit);
            this.groupBox_Information.Controls.Add(this.dateTimePicker_Edit);
            this.groupBox_Information.Controls.Add(this.label4);
            this.groupBox_Information.Controls.Add(this.label3);
            this.groupBox_Information.Controls.Add(this.label2);
            this.groupBox_Information.Controls.Add(this.label_Id);
            this.groupBox_Information.Controls.Add(this.textBox_Amount);
            this.groupBox_Information.Controls.Add(this.textBox_Price);
            this.groupBox_Information.Controls.Add(this.textBox_Material);
            this.groupBox_Information.Controls.Add(this.textBox_Id);
            this.groupBox_Information.Location = new System.Drawing.Point(12, 267);
            this.groupBox_Information.Name = "groupBox_Information";
            this.groupBox_Information.Size = new System.Drawing.Size(329, 317);
            this.groupBox_Information.TabIndex = 13;
            this.groupBox_Information.TabStop = false;
            this.groupBox_Information.Visible = false;
            // 
            // button_EditMaterial
            // 
            this.button_EditMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditMaterial.Location = new System.Drawing.Point(6, 252);
            this.button_EditMaterial.Name = "button_EditMaterial";
            this.button_EditMaterial.Size = new System.Drawing.Size(311, 59);
            this.button_EditMaterial.TabIndex = 15;
            this.button_EditMaterial.Text = "Edit";
            this.button_EditMaterial.UseVisualStyleBackColor = true;
            this.button_EditMaterial.Click += new System.EventHandler(this.button_EditMaterial_Click);
            // 
            // textBox_Kind
            // 
            this.textBox_Kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Kind.Location = new System.Drawing.Point(99, 94);
            this.textBox_Kind.Name = "textBox_Kind";
            this.textBox_Kind.Size = new System.Drawing.Size(203, 30);
            this.textBox_Kind.TabIndex = 16;
            // 
            // button_AddMaterial
            // 
            this.button_AddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddMaterial.Location = new System.Drawing.Point(6, 250);
            this.button_AddMaterial.Name = "button_AddMaterial";
            this.button_AddMaterial.Size = new System.Drawing.Size(311, 61);
            this.button_AddMaterial.TabIndex = 15;
            this.button_AddMaterial.Text = "Add";
            this.button_AddMaterial.UseVisualStyleBackColor = true;
            this.button_AddMaterial.Click += new System.EventHandler(this.button_AddMaterial_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kind:";
            // 
            // label_TimeEdit
            // 
            this.label_TimeEdit.AutoSize = true;
            this.label_TimeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeEdit.Location = new System.Drawing.Point(31, 202);
            this.label_TimeEdit.Name = "label_TimeEdit";
            this.label_TimeEdit.Size = new System.Drawing.Size(62, 25);
            this.label_TimeEdit.TabIndex = 9;
            this.label_TimeEdit.Text = "Time:";
            // 
            // dateTimePicker_Edit
            // 
            this.dateTimePicker_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Edit.Location = new System.Drawing.Point(99, 202);
            this.dateTimePicker_Edit.Name = "dateTimePicker_Edit";
            this.dateTimePicker_Edit.Size = new System.Drawing.Size(203, 26);
            this.dateTimePicker_Edit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Material:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(59, 22);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(34, 25);
            this.label_Id.TabIndex = 4;
            this.label_Id.Text = "Id:";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Amount.Location = new System.Drawing.Point(99, 130);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(203, 30);
            this.textBox_Amount.TabIndex = 3;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Price.Location = new System.Drawing.Point(99, 166);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(203, 30);
            this.textBox_Price.TabIndex = 2;
            // 
            // textBox_Material
            // 
            this.textBox_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Material.Location = new System.Drawing.Point(99, 55);
            this.textBox_Material.Name = "textBox_Material";
            this.textBox_Material.Size = new System.Drawing.Size(203, 30);
            this.textBox_Material.TabIndex = 1;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Id.Location = new System.Drawing.Point(99, 19);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(203, 30);
            this.textBox_Id.TabIndex = 0;
            // 
            // groupBox_Find
            // 
            this.groupBox_Find.Controls.Add(this.button_ShowAll);
            this.groupBox_Find.Controls.Add(this.label5);
            this.groupBox_Find.Controls.Add(this.textBox_MaterialFind);
            this.groupBox_Find.Controls.Add(this.button_Find);
            this.groupBox_Find.Controls.Add(this.dateTimePicker_DateTo);
            this.groupBox_Find.Controls.Add(this.dateTimePicker_DateFrom);
            this.groupBox_Find.Controls.Add(this.label13);
            this.groupBox_Find.Controls.Add(this.label10);
            this.groupBox_Find.Controls.Add(this.comboBox_FindKind);
            this.groupBox_Find.Controls.Add(this.label9);
            this.groupBox_Find.Location = new System.Drawing.Point(373, 9);
            this.groupBox_Find.Name = "groupBox_Find";
            this.groupBox_Find.Size = new System.Drawing.Size(732, 125);
            this.groupBox_Find.TabIndex = 14;
            this.groupBox_Find.TabStop = false;
            // 
            // button_ShowAll
            // 
            this.button_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowAll.Location = new System.Drawing.Point(573, 12);
            this.button_ShowAll.Name = "button_ShowAll";
            this.button_ShowAll.Size = new System.Drawing.Size(140, 46);
            this.button_ShowAll.TabIndex = 27;
            this.button_ShowAll.Text = "Show All";
            this.button_ShowAll.UseVisualStyleBackColor = true;
            this.button_ShowAll.Click += new System.EventHandler(this.button_ShowAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Material Name";
            // 
            // textBox_MaterialFind
            // 
            this.textBox_MaterialFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaterialFind.Location = new System.Drawing.Point(150, 27);
            this.textBox_MaterialFind.Name = "textBox_MaterialFind";
            this.textBox_MaterialFind.Size = new System.Drawing.Size(143, 30);
            this.textBox_MaterialFind.TabIndex = 25;
            // 
            // button_Find
            // 
            this.button_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Find.Location = new System.Drawing.Point(573, 68);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(140, 46);
            this.button_Find.TabIndex = 14;
            this.button_Find.Text = "Search";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // dateTimePicker_DateTo
            // 
            this.dateTimePicker_DateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateTo.Location = new System.Drawing.Point(395, 76);
            this.dateTimePicker_DateTo.Name = "dateTimePicker_DateTo";
            this.dateTimePicker_DateTo.Size = new System.Drawing.Size(143, 30);
            this.dateTimePicker_DateTo.TabIndex = 0;
            // 
            // dateTimePicker_DateFrom
            // 
            this.dateTimePicker_DateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateFrom.Location = new System.Drawing.Point(148, 76);
            this.dateTimePicker_DateFrom.Name = "dateTimePicker_DateFrom";
            this.dateTimePicker_DateFrom.Size = new System.Drawing.Size(145, 30);
            this.dateTimePicker_DateFrom.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(309, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Kind";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Date";
            // 
            // comboBox_FindKind
            // 
            this.comboBox_FindKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FindKind.FormattingEnabled = true;
            this.comboBox_FindKind.Location = new System.Drawing.Point(395, 27);
            this.comboBox_FindKind.Name = "comboBox_FindKind";
            this.comboBox_FindKind.Size = new System.Drawing.Size(143, 33);
            this.comboBox_FindKind.TabIndex = 15;
            this.comboBox_FindKind.SelectedIndexChanged += new System.EventHandler(this.comboBox_FindKind_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(301, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Between";
            // 
            // WareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1162, 596);
            this.Controls.Add(this.groupBox_Find);
            this.Controls.Add(this.groupBox_Information);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_ShowAdd);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WareHouseForm";
            this.Text = "WareHouseForm";
            this.Load += new System.EventHandler(this.WareHourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_Information.ResumeLayout(false);
            this.groupBox_Information.PerformLayout();
            this.groupBox_Find.ResumeLayout(false);
            this.groupBox_Find.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_ShowAdd;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.GroupBox groupBox_Information;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Material;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_TimeEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_Find;
        private System.Windows.Forms.ComboBox comboBox_FindKind;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateTo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_AddMaterial;
        private System.Windows.Forms.TextBox textBox_Kind;
        private System.Windows.Forms.Button button_EditMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MaterialFind;
        private System.Windows.Forms.Button button_ShowAll;
        private System.Windows.Forms.Label label10;
    }
}