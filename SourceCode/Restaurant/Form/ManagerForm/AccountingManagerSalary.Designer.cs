
namespace Restaurant
{
    partial class AccountingManagerSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingManagerSalary));
            this.closeLabel = new System.Windows.Forms.Label();
            this.mySalaryLabel = new System.Windows.Forms.Label();
            this.myFinesLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.closeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.closeLabel.Location = new System.Drawing.Point(558, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(22, 25);
            this.closeLabel.TabIndex = 37;
            this.closeLabel.Text = "x";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // mySalaryLabel
            // 
            this.mySalaryLabel.AutoSize = true;
            this.mySalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.mySalaryLabel.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.mySalaryLabel.ForeColor = System.Drawing.Color.White;
            this.mySalaryLabel.Location = new System.Drawing.Point(57, 51);
            this.mySalaryLabel.Name = "mySalaryLabel";
            this.mySalaryLabel.Size = new System.Drawing.Size(153, 41);
            this.mySalaryLabel.TabIndex = 38;
            this.mySalaryLabel.Text = "My Salary:";
            // 
            // myFinesLabel
            // 
            this.myFinesLabel.AutoSize = true;
            this.myFinesLabel.BackColor = System.Drawing.Color.Transparent;
            this.myFinesLabel.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.myFinesLabel.ForeColor = System.Drawing.Color.White;
            this.myFinesLabel.Location = new System.Drawing.Point(326, 51);
            this.myFinesLabel.Name = "myFinesLabel";
            this.myFinesLabel.Size = new System.Drawing.Size(144, 41);
            this.myFinesLabel.TabIndex = 39;
            this.myFinesLabel.Text = "My Fines:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(64, 197);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(148, 49);
            this.cancelButton.TabIndex = 41;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(379, 199);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(91, 41);
            this.totalLabel.TabIndex = 42;
            this.totalLabel.Text = "Total:";
            // 
            // AccountingManagerSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 280);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.myFinesLabel);
            this.Controls.Add(this.mySalaryLabel);
            this.Controls.Add(this.closeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountingManagerSalary";
            this.Text = "AccountingManagerSalary";
            this.Load += new System.EventHandler(this.AccountingManagerSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label mySalaryLabel;
        private System.Windows.Forms.Label myFinesLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label totalLabel;
    }
}