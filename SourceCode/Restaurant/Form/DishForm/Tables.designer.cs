
namespace final_Project
{
    partial class Tables
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
            this.button_AddTable = new System.Windows.Forms.Button();
            this.button_DeleteTable = new System.Windows.Forms.Button();
            this.dataGridView_tableList = new System.Windows.Forms.DataGridView();
            this.dataGridView_TableInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddTable
            // 
            this.button_AddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_AddTable.Location = new System.Drawing.Point(521, 56);
            this.button_AddTable.Name = "button_AddTable";
            this.button_AddTable.Size = new System.Drawing.Size(129, 43);
            this.button_AddTable.TabIndex = 1;
            this.button_AddTable.Text = "AddTable";
            this.button_AddTable.UseVisualStyleBackColor = true;
            this.button_AddTable.Click += new System.EventHandler(this.button_AddTable_Click);
            // 
            // button_DeleteTable
            // 
            this.button_DeleteTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_DeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteTable.Location = new System.Drawing.Point(521, 140);
            this.button_DeleteTable.Name = "button_DeleteTable";
            this.button_DeleteTable.Size = new System.Drawing.Size(129, 43);
            this.button_DeleteTable.TabIndex = 3;
            this.button_DeleteTable.Text = "Delete Table";
            this.button_DeleteTable.UseVisualStyleBackColor = false;
            this.button_DeleteTable.Click += new System.EventHandler(this.button_DeleteTable_Click);
            // 
            // dataGridView_tableList
            // 
            this.dataGridView_tableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tableList.Location = new System.Drawing.Point(12, 23);
            this.dataGridView_tableList.Name = "dataGridView_tableList";
            this.dataGridView_tableList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tableList.Size = new System.Drawing.Size(491, 186);
            this.dataGridView_tableList.TabIndex = 7;
            this.dataGridView_tableList.DoubleClick += new System.EventHandler(this.dataGridView_tableList_DoubleClick);
            // 
            // dataGridView_TableInfo
            // 
            this.dataGridView_TableInfo.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView_TableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TableInfo.Location = new System.Drawing.Point(12, 215);
            this.dataGridView_TableInfo.Name = "dataGridView_TableInfo";
            this.dataGridView_TableInfo.Size = new System.Drawing.Size(491, 240);
            this.dataGridView_TableInfo.TabIndex = 8;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(662, 485);
            this.Controls.Add(this.dataGridView_TableInfo);
            this.Controls.Add(this.dataGridView_tableList);
            this.Controls.Add(this.button_DeleteTable);
            this.Controls.Add(this.button_AddTable);
            this.Name = "TablesForm";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TableInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_AddTable;
        private System.Windows.Forms.Button button_DeleteTable;
        public System.Windows.Forms.DataGridView dataGridView_tableList;
        public System.Windows.Forms.DataGridView dataGridView_TableInfo;
    }
}