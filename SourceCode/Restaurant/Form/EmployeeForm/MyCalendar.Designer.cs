
namespace Restaurant
{
    partial class MyCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCalendar));
            this.myShiftView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.shiftBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myShiftView)).BeginInit();
            this.SuspendLayout();
            // 
            // myShiftView
            // 
            this.myShiftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myShiftView.Location = new System.Drawing.Point(340, -2);
            this.myShiftView.Name = "myShiftView";
            this.myShiftView.RowTemplate.Height = 30;
            this.myShiftView.Size = new System.Drawing.Size(302, 233);
            this.myShiftView.TabIndex = 0;
            this.myShiftView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myShiftView_CellContentClick);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Transparent;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.removeButton.Location = new System.Drawing.Point(67, 163);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(168, 55);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove Shift";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(122, 54);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(168, 20);
            this.dayBox.TabIndex = 2;
            // 
            // shiftBox
            // 
            this.shiftBox.Location = new System.Drawing.Point(122, 109);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(168, 20);
            this.shiftBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(69, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(65, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shift:";
            // 
            // MyCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shiftBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.myShiftView);
            this.Name = "MyCalendar";
            this.Text = "MyShift";
            this.Load += new System.EventHandler(this.MyShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myShiftView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myShiftView;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox shiftBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}