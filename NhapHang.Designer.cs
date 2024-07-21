namespace GUI_QuanLySieuThi
{
    partial class NhapHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNhap = new System.Windows.Forms.ListView();
            this.clsl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.dtXuat = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quy Trình Nhập Hàng";
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn Giá";
            this.colDonGia.Width = 92;
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "TÊN SP";
            this.colTenSP.Width = 157;
            // 
            // colMa
            // 
            this.colMa.Text = "MÃ SP";
            // 
            // lvNhap
            // 
            this.lvNhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMa,
            this.colTenSP,
            this.colDonGia,
            this.clsl});
            this.lvNhap.HideSelection = false;
            this.lvNhap.Location = new System.Drawing.Point(1, 19);
            this.lvNhap.Name = "lvNhap";
            this.lvNhap.Size = new System.Drawing.Size(383, 337);
            this.lvNhap.TabIndex = 5;
            this.lvNhap.UseCompatibleStateImageBehavior = false;
            this.lvNhap.View = System.Windows.Forms.View.Details;
            // 
            // clsl
            // 
            this.clsl.Text = "Số Lượng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvNhap);
            this.groupBox2.Location = new System.Drawing.Point(13, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 362);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sản Phẩm Nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.dtXuat);
            this.groupBox1.Location = new System.Drawing.Point(402, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 401);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn Nhập Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền(VNĐ)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(240, 365);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 21);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Add";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(359, 365);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(101, 21);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập Hàng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // dtXuat
            // 
            this.dtXuat.AllowUserToAddRows = false;
            this.dtXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.GIA,
            this.DVT,
            this.NSX,
            this.SOLUONG,
            this.colThanhTien});
            this.dtXuat.Location = new System.Drawing.Point(1, 19);
            this.dtXuat.Name = "dtXuat";
            this.dtXuat.ReadOnly = true;
            this.dtXuat.Size = new System.Drawing.Size(744, 318);
            this.dtXuat.TabIndex = 0;
            this.dtXuat.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtXuat_CellValueChanged);
            // 
            // MASP
            // 
            this.MASP.HeaderText = "MÃ SP";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.HeaderText = "TÊN SP";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.HeaderText = "Đơn Giá";
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // NSX
            // 
            this.NSX.HeaderText = "NSX";
            this.NSX.Name = "NSX";
            this.NSX.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colMa;
        private System.Windows.Forms.ListView lvNhap;
        private System.Windows.Forms.ColumnHeader clsl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.DataGridView dtXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}