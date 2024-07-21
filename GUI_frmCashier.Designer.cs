namespace GUI_QuanLySieuThi
{
    partial class GUI_frmCashier
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lbldsnv = new System.Windows.Forms.Label();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.SoHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblGioMoCa = new System.Windows.Forms.Label();
            this.lblMaCa = new System.Windows.Forms.Label();
            this.lblDoiMatKhau = new System.Windows.Forms.Label();
            this.lblChiTietCa = new System.Windows.Forms.Label();
            this.btnDongCa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 18);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 427);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnThongKe);
            this.tabPage2.Controls.Add(this.lbldsnv);
            this.tabPage2.Controls.Add(this.lsvHoaDon);
            this.tabPage2.Controls.Add(this.lblNhanVien);
            this.tabPage2.Controls.Add(this.lblGioMoCa);
            this.tabPage2.Controls.Add(this.lblMaCa);
            this.tabPage2.Controls.Add(this.lblDoiMatKhau);
            this.tabPage2.Controls.Add(this.lblChiTietCa);
            this.tabPage2.Controls.Add(this.btnDongCa);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblTenTK);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cửa hàng";
            this.tabPage2.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 70);
            this.button2.TabIndex = 18;
            this.button2.Text = "Nhập Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 70);
            this.button1.TabIndex = 18;
            this.button1.Text = "Bán Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThongKe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(23, 303);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(156, 81);
            this.btnThongKe.TabIndex = 17;
            this.btnThongKe.Text = "Xem Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.UseWaitCursor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lbldsnv
            // 
            this.lbldsnv.AutoSize = true;
            this.lbldsnv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldsnv.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldsnv.Location = new System.Drawing.Point(23, 266);
            this.lbldsnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldsnv.Name = "lbldsnv";
            this.lbldsnv.Size = new System.Drawing.Size(156, 17);
            this.lbldsnv.TabIndex = 16;
            this.lbldsnv.Text = "Danh Sách Nhân Viên";
            this.lbldsnv.UseWaitCursor = true;
            this.lbldsnv.Click += new System.EventHandler(this.lbldsnv_Click);
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SoHD,
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.lsvHoaDon.FullRowSelect = true;
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(235, 179);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(604, 205);
            this.lsvHoaDon.TabIndex = 15;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.UseWaitCursor = true;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // SoHD
            // 
            this.SoHD.Text = "Mã HĐ";
            this.SoHD.Width = 56;
            // 
            // MaSP
            // 
            this.MaSP.Text = "Mã SP";
            this.MaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaSP.Width = 64;
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên sản phẩm";
            this.TenSP.Width = 146;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "SL";
            this.SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuong.Width = 42;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DonGia.Width = 137;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThanhTien.Width = 148;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(398, 77);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(0, 16);
            this.lblNhanVien.TabIndex = 13;
            this.lblNhanVien.UseWaitCursor = true;
            // 
            // lblGioMoCa
            // 
            this.lblGioMoCa.AutoSize = true;
            this.lblGioMoCa.Location = new System.Drawing.Point(398, 102);
            this.lblGioMoCa.Name = "lblGioMoCa";
            this.lblGioMoCa.Size = new System.Drawing.Size(0, 16);
            this.lblGioMoCa.TabIndex = 12;
            this.lblGioMoCa.UseWaitCursor = true;
            // 
            // lblMaCa
            // 
            this.lblMaCa.AutoSize = true;
            this.lblMaCa.Location = new System.Drawing.Point(398, 52);
            this.lblMaCa.Name = "lblMaCa";
            this.lblMaCa.Size = new System.Drawing.Size(0, 16);
            this.lblMaCa.TabIndex = 10;
            this.lblMaCa.UseWaitCursor = true;
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.AutoSize = true;
            this.lblDoiMatKhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.Location = new System.Drawing.Point(20, 52);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(92, 16);
            this.lblDoiMatKhau.TabIndex = 9;
            this.lblDoiMatKhau.Text = "Đổi mật khẩu";
            this.lblDoiMatKhau.UseWaitCursor = true;
            this.lblDoiMatKhau.Click += new System.EventHandler(this.lblDoiMatKhau_Click);
            // 
            // lblChiTietCa
            // 
            this.lblChiTietCa.AutoSize = true;
            this.lblChiTietCa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChiTietCa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietCa.Location = new System.Drawing.Point(625, 147);
            this.lblChiTietCa.Name = "lblChiTietCa";
            this.lblChiTietCa.Size = new System.Drawing.Size(98, 16);
            this.lblChiTietCa.TabIndex = 7;
            this.lblChiTietCa.Text = "Chi tiết ca >>";
            this.lblChiTietCa.UseWaitCursor = true;
            this.lblChiTietCa.Click += new System.EventHandler(this.lblChiTietCa_Click);
            // 
            // btnDongCa
            // 
            this.btnDongCa.BackColor = System.Drawing.Color.Orange;
            this.btnDongCa.Location = new System.Drawing.Point(235, 131);
            this.btnDongCa.Name = "btnDongCa";
            this.btnDongCa.Size = new System.Drawing.Size(76, 32);
            this.btnDongCa.TabIndex = 6;
            this.btnDongCa.Text = "Đóng ca";
            this.btnDongCa.UseVisualStyleBackColor = false;
            this.btnDongCa.UseWaitCursor = true;
            this.btnDongCa.Click += new System.EventHandler(this.btnDongCa_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giờ mở ca:";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên:";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã ca:";
            this.label1.UseWaitCursor = true;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.Location = new System.Drawing.Point(20, 21);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(0, 18);
            this.lblTenTK.TabIndex = 1;
            this.lblTenTK.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bán hàng";
            this.tabPage1.UseWaitCursor = true;
            // 
            // GUI_frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "GUI_frmCashier";
            this.Text = "GUI_frmCashier";
            this.Load += new System.EventHandler(this.GUI_frmCashier_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblChiTietCa;
        private System.Windows.Forms.Button btnDongCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Label lblDoiMatKhau;
        private System.Windows.Forms.Label lblMaCa;
        private System.Windows.Forms.Label lblGioMoCa;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader SoHD;
        private System.Windows.Forms.ColumnHeader MaSP;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.Label lbldsnv;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}