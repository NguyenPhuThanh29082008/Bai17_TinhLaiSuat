namespace Bai17_TinhLaiSuat
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtLaisuat = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lstKq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số % lãi suất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền lãi suất";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(146, 295);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(140, 47);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(146, 95);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(140, 26);
            this.txtTien.TabIndex = 5;
            // 
            // txtLaisuat
            // 
            this.txtLaisuat.Location = new System.Drawing.Point(146, 153);
            this.txtLaisuat.Name = "txtLaisuat";
            this.txtLaisuat.Size = new System.Drawing.Size(140, 26);
            this.txtLaisuat.TabIndex = 6;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(146, 223);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(140, 26);
            this.txtNam.TabIndex = 7;
            // 
            // lstKq
            // 
            this.lstKq.FormattingEnabled = true;
            this.lstKq.ItemHeight = 20;
            this.lstKq.Location = new System.Drawing.Point(345, 57);
            this.lstKq.Name = "lstKq";
            this.lstKq.Size = new System.Drawing.Size(409, 344);
            this.lstKq.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 432);
            this.Controls.Add(this.lstKq);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtLaisuat);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtLaisuat;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.ListBox lstKq;
    }
}

