
namespace final_Project
{
    partial class AddMaterial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MaterialAmount = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Dish = new System.Windows.Forms.ComboBox();
            this.comboBox_Material = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // textBox_MaterialAmount
            // 
            this.textBox_MaterialAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaterialAmount.Location = new System.Drawing.Point(117, 147);
            this.textBox_MaterialAmount.Name = "textBox_MaterialAmount";
            this.textBox_MaterialAmount.Size = new System.Drawing.Size(109, 30);
            this.textBox_MaterialAmount.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Yellow;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(244, 147);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(110, 30);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dish";
            // 
            // comboBox_Dish
            // 
            this.comboBox_Dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Dish.FormattingEnabled = true;
            this.comboBox_Dish.Location = new System.Drawing.Point(117, 42);
            this.comboBox_Dish.Name = "comboBox_Dish";
            this.comboBox_Dish.Size = new System.Drawing.Size(237, 33);
            this.comboBox_Dish.TabIndex = 9;
            // 
            // comboBox_Material
            // 
            this.comboBox_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Material.FormattingEnabled = true;
            this.comboBox_Material.Location = new System.Drawing.Point(117, 92);
            this.comboBox_Material.Name = "comboBox_Material";
            this.comboBox_Material.Size = new System.Drawing.Size(237, 33);
            this.comboBox_Material.TabIndex = 10;
            // 
            // AddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(366, 194);
            this.Controls.Add(this.comboBox_Material);
            this.Controls.Add(this.comboBox_Dish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_MaterialAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMaterial";
            this.Text = "Add Material";
            this.Load += new System.EventHandler(this.AddDishes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_MaterialAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Dish;
        private System.Windows.Forms.ComboBox comboBox_Material;
    }
}