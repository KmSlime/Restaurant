
namespace final_Project
{
    partial class ShowRecipe
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
            this.comboBox_SelectMaterial = new System.Windows.Forms.ComboBox();
            this.button_ShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox_SelectMaterial
            // 
            this.comboBox_SelectMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectMaterial.FormattingEnabled = true;
            this.comboBox_SelectMaterial.Location = new System.Drawing.Point(12, 78);
            this.comboBox_SelectMaterial.Name = "comboBox_SelectMaterial";
            this.comboBox_SelectMaterial.Size = new System.Drawing.Size(141, 33);
            this.comboBox_SelectMaterial.TabIndex = 1;
            this.comboBox_SelectMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_ShowAll
            // 
            this.button_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowAll.Location = new System.Drawing.Point(12, 400);
            this.button_ShowAll.Name = "button_ShowAll";
            this.button_ShowAll.Size = new System.Drawing.Size(132, 38);
            this.button_ShowAll.TabIndex = 2;
            this.button_ShowAll.Text = "Show All";
            this.button_ShowAll.UseVisualStyleBackColor = true;
            this.button_ShowAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recipe for the food";
            // 
            // ShowRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ShowAll);
            this.Controls.Add(this.comboBox_SelectMaterial);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowRecipe";
            this.Text = "ShowRecipe";
            this.Load += new System.EventHandler(this.ShowRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_SelectMaterial;
        private System.Windows.Forms.Button button_ShowAll;
        private System.Windows.Forms.Label label1;
    }
}