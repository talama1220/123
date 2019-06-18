namespace Quan_Ly_Sach
{
    partial class Mh_TimKiemTen
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
            this.ghichu = new System.Windows.Forms.ListView();
            this.Cot1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cot6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Th_Ghichu = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.ghichu.Location = new System.Drawing.Point(49, 128);
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(703, 387);
            this.ghichu.TabIndex = 81;
            this.ghichu.UseCompatibleStateImageBehavior = false;
            this.ghichu.View = System.Windows.Forms.View.Details;
            this.ghichu.SelectedIndexChanged += new System.EventHandler(this.ghichu_SelectedIndexChanged);
            // 
            // Cot1
            // 
            this.Cot1.Text = "Mã sách";
            this.Cot1.Width = 63;
            // 
            // Cot2
            // 
            this.Cot2.Text = "Tên sách";
            this.Cot2.Width = 200;
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
            // Th_Ghichu
            // 
            this.Th_Ghichu.AutoSize = true;
            this.Th_Ghichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_Ghichu.Location = new System.Drawing.Point(495, 14);
            this.Th_Ghichu.Name = "Th_Ghichu";
            this.Th_Ghichu.Size = new System.Drawing.Size(198, 19);
            this.Th_Ghichu.TabIndex = 80;
            this.Th_Ghichu.Text = "Nhập vào tên của sách cần tìm.";
            this.Th_Ghichu.Click += new System.EventHandler(this.Th_Ghichu_Click);
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(233, 12);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(231, 26);
            this.text1.TabIndex = 79;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "Tên Sách";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(464, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 77;
            this.button1.Text = "ĐỒNG Ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(144, -65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 38);
            this.label1.TabIndex = 76;
            this.label1.Text = "TÌM KIẾM SÁCH THEO THỂ LOẠI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Mh_TimKiemTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ghichu);
            this.Controls.Add(this.Th_Ghichu);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Mh_TimKiemTen";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ghichu;
        private System.Windows.Forms.ColumnHeader Cot1;
        private System.Windows.Forms.ColumnHeader Cot2;
        private System.Windows.Forms.ColumnHeader Cot3;
        private System.Windows.Forms.ColumnHeader Cot4;
        private System.Windows.Forms.ColumnHeader Cot5;
        private System.Windows.Forms.ColumnHeader Cot6;
        private System.Windows.Forms.Label Th_Ghichu;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}