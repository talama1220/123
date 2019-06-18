namespace Quan_Ly_Sach
{
    partial class Mh_XoaSach
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
            this.Th_Ghichu = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Th_Ghichu
            // 
            this.Th_Ghichu.AutoSize = true;
            this.Th_Ghichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_Ghichu.Location = new System.Drawing.Point(482, 88);
            this.Th_Ghichu.Name = "Th_Ghichu";
            this.Th_Ghichu.Size = new System.Drawing.Size(223, 38);
            this.Th_Ghichu.TabIndex = 67;
            this.Th_Ghichu.Text = "Nhập vào vị trí trong danh sách của\r\n sách cần xóa";
            this.Th_Ghichu.Click += new System.EventHandler(this.Th_Ghichu_Click);
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(220, 86);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(231, 26);
            this.text1.TabIndex = 66;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Số thứ tự";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 64;
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
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 38);
            this.label1.TabIndex = 50;
            this.label1.Text = "XÓA SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Mh_XoaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Th_Ghichu);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Mh_XoaSach";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Th_Ghichu;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}