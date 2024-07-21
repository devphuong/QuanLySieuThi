namespace GUI_QuanLySieuThi
{
    partial class GUI_frmDoiMK
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
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtNhapLaiMKMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapMKMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapMKCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(164, 37);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(205, 23);
            this.txtTenTK.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên tài khoản:";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Location = new System.Drawing.Point(212, 153);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(157, 30);
            this.btnDoiMK.TabIndex = 14;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtNhapLaiMKMoi
            // 
            this.txtNhapLaiMKMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMKMoi.Location = new System.Drawing.Point(164, 124);
            this.txtNhapLaiMKMoi.Name = "txtNhapLaiMKMoi";
            this.txtNhapLaiMKMoi.Size = new System.Drawing.Size(205, 23);
            this.txtNhapLaiMKMoi.TabIndex = 13;
            this.txtNhapLaiMKMoi.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // txtNhapMKMoi
            // 
            this.txtNhapMKMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMKMoi.Location = new System.Drawing.Point(164, 95);
            this.txtNhapMKMoi.Name = "txtNhapMKMoi";
            this.txtNhapMKMoi.Size = new System.Drawing.Size(205, 23);
            this.txtNhapMKMoi.TabIndex = 11;
            this.txtNhapMKMoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txtNhapMKCu
            // 
            this.txtNhapMKCu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMKCu.Location = new System.Drawing.Point(164, 66);
            this.txtNhapMKCu.Name = "txtNhapMKCu";
            this.txtNhapMKCu.Size = new System.Drawing.Size(205, 23);
            this.txtNhapMKCu.TabIndex = 10;
            this.txtNhapMKCu.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // GUI_frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 206);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtNhapLaiMKMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhapMKMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNhapMKCu);
            this.Controls.Add(this.label1);
            this.Name = "GUI_frmDoiMK";
            this.Text = "GUI_frmDoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox txtNhapLaiMKMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapMKMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapMKCu;
        private System.Windows.Forms.Label label1;
    }
}