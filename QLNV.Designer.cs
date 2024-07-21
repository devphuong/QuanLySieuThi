namespace GUI_QuanLySieuThi
{
    partial class QLNV
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
            this.dtgdsnv = new System.Windows.Forms.DataGridView();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnxoanv = new System.Windows.Forms.Button();
            this.btnexportexcel = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsnv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgdsnv
            // 
            this.dtgdsnv.AllowUserToAddRows = false;
            this.dtgdsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgdsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdsnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.GTINH,
            this.NGSINH,
            this.SODT,
            this.NGVL,
            this.CHUCVU,
            this.DCHI});
            this.dtgdsnv.Location = new System.Drawing.Point(9, 222);
            this.dtgdsnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgdsnv.MultiSelect = false;
            this.dtgdsnv.Name = "dtgdsnv";
            this.dtgdsnv.RowHeadersWidth = 51;
            this.dtgdsnv.RowTemplate.Height = 24;
            this.dtgdsnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgdsnv.Size = new System.Drawing.Size(1051, 144);
            this.dtgdsnv.TabIndex = 8;
            this.dtgdsnv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdsnv_CellValueChanged);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(881, 81);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(97, 48);
            this.btnThemNV.TabIndex = 9;
            this.btnThemNV.Text = "Thêm NV";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnxoanv
            // 
            this.btnxoanv.Location = new System.Drawing.Point(880, 139);
            this.btnxoanv.Name = "btnxoanv";
            this.btnxoanv.Size = new System.Drawing.Size(98, 48);
            this.btnxoanv.TabIndex = 10;
            this.btnxoanv.Text = "Xóa NV";
            this.btnxoanv.UseVisualStyleBackColor = true;
            this.btnxoanv.Click += new System.EventHandler(this.btnxoanv_Click);
            // 
            // btnexportexcel
            // 
            this.btnexportexcel.Location = new System.Drawing.Point(473, 389);
            this.btnexportexcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexportexcel.Name = "btnexportexcel";
            this.btnexportexcel.Size = new System.Drawing.Size(143, 53);
            this.btnexportexcel.TabIndex = 12;
            this.btnexportexcel.Text = "Xuất Danh Sách";
            this.btnexportexcel.UseVisualStyleBackColor = true;
            this.btnexportexcel.Click += new System.EventHandler(this.btnexportexcel_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(644, 389);
            this.btnreload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(130, 53);
            this.btnreload.TabIndex = 13;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(719, 99);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm nhân viên theo mã";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // GTINH
            // 
            this.GTINH.DataPropertyName = "GTINH";
            this.GTINH.HeaderText = "Giới tính";
            this.GTINH.MinimumWidth = 6;
            this.GTINH.Name = "GTINH";
            // 
            // NGSINH
            // 
            this.NGSINH.DataPropertyName = "NGSINH";
            this.NGSINH.HeaderText = "Ngày sinh";
            this.NGSINH.MinimumWidth = 6;
            this.NGSINH.Name = "NGSINH";
            // 
            // SODT
            // 
            this.SODT.DataPropertyName = "SODT";
            this.SODT.HeaderText = "Số điện thoại";
            this.SODT.MinimumWidth = 6;
            this.SODT.Name = "SODT";
            // 
            // NGVL
            // 
            this.NGVL.DataPropertyName = "NGVL";
            this.NGVL.HeaderText = "Ngày vào làm";
            this.NGVL.MinimumWidth = 6;
            this.NGVL.Name = "NGVL";
            // 
            // CHUCVU
            // 
            this.CHUCVU.DataPropertyName = "CHUCVU";
            this.CHUCVU.HeaderText = "Chức vụ";
            this.CHUCVU.MinimumWidth = 6;
            this.CHUCVU.Name = "CHUCVU";
            // 
            // DCHI
            // 
            this.DCHI.DataPropertyName = "DCHI";
            this.DCHI.HeaderText = "Địa chỉ";
            this.DCHI.MinimumWidth = 6;
            this.DCHI.Name = "DCHI";
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnexportexcel);
            this.Controls.Add(this.btnxoanv);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.dtgdsnv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QLNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgdsnv;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnxoanv;
        private System.Windows.Forms.Button btnexportexcel;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCHI;
    }
}