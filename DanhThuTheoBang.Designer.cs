namespace GUI_QuanLySieuThi
{
    partial class DanhThuTheoBang
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
            System.Windows.Forms.Button btnThoat;
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongDon = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaSP = new System.Windows.Forms.ComboBox();
            this.dtSP = new System.Windows.Forms.DataGridView();
            btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackgroundImage = global::GUI_QuanLySieuThi.Properties.Resources.thoat;
            btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThoat.Location = new System.Drawing.Point(445, 431);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(72, 72);
            btnThoat.TabIndex = 18;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "TỔNG SỐ ĐƠN HÀNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "TỔNG THÀNH TIỀN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "THỐNG KÊ DOANH THU THEO MẶT HÀNG";
            // 
            // txtTongDon
            // 
            this.txtTongDon.Location = new System.Drawing.Point(188, 476);
            this.txtTongDon.Name = "txtTongDon";
            this.txtTongDon.Size = new System.Drawing.Size(192, 20);
            this.txtTongDon.TabIndex = 12;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(177, 430);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(203, 20);
            this.txtThanhTien.TabIndex = 13;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(148, 386);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(316, 20);
            this.txtTenSP.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "TÊN SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "MÃ SẢN PHẨM";
            // 
            // cmbMaSP
            // 
            this.cmbMaSP.FormattingEnabled = true;
            this.cmbMaSP.Location = new System.Drawing.Point(140, 343);
            this.cmbMaSP.Name = "cmbMaSP";
            this.cmbMaSP.Size = new System.Drawing.Size(196, 21);
            this.cmbMaSP.TabIndex = 9;
            this.cmbMaSP.SelectedIndexChanged += new System.EventHandler(this.cmbMaSP_SelectedIndexChanged);
            // 
            // dtSP
            // 
            this.dtSP.AllowUserToOrderColumns = true;
            this.dtSP.Location = new System.Drawing.Point(12, 70);
            this.dtSP.Name = "dtSP";
            this.dtSP.Size = new System.Drawing.Size(536, 242);
            this.dtSP.TabIndex = 8;
            // 
            // DanhThuTheoBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 524);
            this.Controls.Add(btnThoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongDon);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMaSP);
            this.Controls.Add(this.dtSP);
            this.Name = "DanhThuTheoBang";
            this.Text = "DanhThuTheoBang";
            this.Load += new System.EventHandler(this.DanhThuTheoBang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongDon;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaSP;
        private System.Windows.Forms.DataGridView dtSP;
    }
}