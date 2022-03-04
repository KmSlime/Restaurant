
namespace Restaurant
{
    partial class MyInfo
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
            this.myInfoView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myInfoView)).BeginInit();
            this.SuspendLayout();
            // 
            // myInfoView
            // 
            this.myInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myInfoView.Location = new System.Drawing.Point(1, -1);
            this.myInfoView.Name = "myInfoView";
            this.myInfoView.RowTemplate.Height = 120;
            this.myInfoView.Size = new System.Drawing.Size(1047, 142);
            this.myInfoView.TabIndex = 1;
            // 
            // MyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 141);
            this.Controls.Add(this.myInfoView);
            this.Name = "MyInfo";
            this.Text = "MyInfo";
            this.Load += new System.EventHandler(this.MyInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myInfoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myInfoView;
    }
}