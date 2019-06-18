namespace Quan_Ly_Sach
{
    partial class Form3
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
            this.ghichu = new System.Windows.Forms.ListView();
            this.Cot1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 28);
            this.label1.TabIndex = 73;
            this.label1.Text = "DANH SÁCH CÁC LOẠI SÁCH TRONG NHÀ SÁCH";
            // 
            // ghichu
            // 
            this.ghichu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cot1,
            this.Cot2,
            this.Cot3,
            this.Cot4,
            this.Cot5,
            this.Cot6});
            this.ghichu.Location = new System.Drawing.Point(48, 51);
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(703, 387);
            this.ghichu.TabIndex = 74;
            this.ghichu.UseCompatibleStateImageBehavior = false;
            this.ghichu.View = System.Windows.Forms.View.Details;
            this.ghichu.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Cot1
            // 
            this.Cot1.Text = "Mã sách";
            this.Cot1.Width = 63;
            // 
            // Cot2
            // 
            this.Cot2.Text = "Tên sách";
            this.Cot2.Width = 116;
            // 
            // Cot3
            // 
            this.Cot3.Text = "Nhà xuất bản";
            this.Cot3.Width = 119;
            // 
            // Cot4
            // 
            this.Cot4.Text = "Giá";
            this.Cot4.Width = 112;
            // 
            // Cot5
            // 
            this.Cot5.Text = "Năm xuất bản";
            this.Cot5.Width = 96;
            // 
            // Cot6
            // 
            this.Cot6.Text = "Thể loại";
            this.Cot6.Width = 106;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.ghichu);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ghichu;
        private System.Windows.Forms.ColumnHeader Cot1;
        private System.Windows.Forms.ColumnHeader Cot2;
        private System.Windows.Forms.ColumnHeader Cot3;
        private System.Windows.Forms.ColumnHeader Cot4;
        private System.Windows.Forms.ColumnHeader Cot5;
        private System.Windows.Forms.ColumnHeader Cot6;
    }
}