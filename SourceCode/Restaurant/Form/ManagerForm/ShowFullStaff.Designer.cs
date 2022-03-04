
namespace Restaurant
{
    partial class ShowFullStaff
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
            this.listStaffView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listStaffView)).BeginInit();
            this.SuspendLayout();
            // 
            // listStaffView
            // 
            this.listStaffView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listStaffView.Location = new System.Drawing.Point(-1, 0);
            this.listStaffView.Name = "listStaffView";
            this.listStaffView.RowTemplate.Height = 120;
            this.listStaffView.Size = new System.Drawing.Size(1062, 497);
            this.listStaffView.TabIndex = 0;
            // 
            // ShowFullStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 495);
            this.Controls.Add(this.listStaffView);
            this.Name = "ShowFullStaff";
            this.Text = "ShowFullStaff";
            this.Load += new System.EventHandler(this.ShowFullStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listStaffView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listStaffView;
    }
}