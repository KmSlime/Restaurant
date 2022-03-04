
namespace final_Project
{
    partial class PrintBillForm
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
            this.label_Total = new System.Windows.Forms.Label();
            this.button_Paid = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(30, 330);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(56, 25);
            this.label_Total.TabIndex = 1;
            this.label_Total.Text = "Total";
            // 
            // button_Paid
            // 
            this.button_Paid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Paid.Location = new System.Drawing.Point(338, 321);
            this.button_Paid.Name = "button_Paid";
            this.button_Paid.Size = new System.Drawing.Size(173, 42);
            this.button_Paid.TabIndex = 2;
            this.button_Paid.Text = "Paid";
            this.button_Paid.UseVisualStyleBackColor = false;
            this.button_Paid.Click += new System.EventHandler(this.button_Paid_Click);
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.Color.MediumPurple;
            this.button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Location = new System.Drawing.Point(338, 373);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(173, 42);
            this.button_Print.TabIndex = 3;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // PrintBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 427);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_Paid);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintBillForm";
            this.Text = "PrintBillForm";
            this.Load += new System.EventHandler(this.PrintBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_Paid;
        private System.Windows.Forms.Button button_Print;
    }
}