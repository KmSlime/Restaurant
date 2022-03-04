
namespace Restaurant
{
    partial class AvailableShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableShift));
            this.availableShiftView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftBox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availableShiftView)).BeginInit();
            this.SuspendLayout();
            // 
            // availableShiftView
            // 
            this.availableShiftView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableShiftView.Location = new System.Drawing.Point(340, 0);
            this.availableShiftView.Name = "availableShiftView";
            this.availableShiftView.RowTemplate.Height = 30;
            this.availableShiftView.Size = new System.Drawing.Size(302, 233);
            this.availableShiftView.TabIndex = 1;
            this.availableShiftView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableShiftView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Day:";
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(112, 67);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(168, 20);
            this.dayBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(59, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Shift:";
            // 
            // shiftBox
            // 
            this.shiftBox.Location = new System.Drawing.Point(112, 116);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(168, 20);
            this.shiftBox.TabIndex = 9;
            // 
            // getButton
            // 
            this.getButton.BackColor = System.Drawing.Color.Transparent;
            this.getButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.getButton.Location = new System.Drawing.Point(93, 163);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(168, 55);
            this.getButton.TabIndex = 10;
            this.getButton.Text = "Get Shift";
            this.getButton.UseVisualStyleBackColor = false;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // AvailableShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 230);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.shiftBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.availableShiftView);
            this.Name = "AvailableShift";
            this.Text = "AvailableShift";
            this.Load += new System.EventHandler(this.AvailableShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableShiftView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView availableShiftView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shiftBox;
        private System.Windows.Forms.Button getButton;
    }
}