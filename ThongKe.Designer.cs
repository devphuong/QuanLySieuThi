namespace GUI_QuanLySieuThi
{
    partial class ThongKe
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTiLeBanHang = new System.Windows.Forms.Button();
            this.btnDoanhThuChart = new System.Windows.Forms.Button();
            this.btnDoanhThuDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::GUI_QuanLySieuThi.Properties.Resources.thoat;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(291, 271);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(267, 246);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Trở Lại";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnTiLeBanHang
            // 
            this.btnTiLeBanHang.BackgroundImage = global::GUI_QuanLySieuThi.Properties.Resources.tron;
            this.btnTiLeBanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTiLeBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiLeBanHang.Location = new System.Drawing.Point(18, 271);
            this.btnTiLeBanHang.Name = "btnTiLeBanHang";
            this.btnTiLeBanHang.Size = new System.Drawing.Size(267, 246);
            this.btnTiLeBanHang.TabIndex = 2;
            this.btnTiLeBanHang.Text = "Tỉ Lệ Bán Hàng";
            this.btnTiLeBanHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTiLeBanHang.UseVisualStyleBackColor = true;
            this.btnTiLeBanHang.Click += new System.EventHandler(this.btnTiLeBanHang_Click_1);
            // 
            // btnDoanhThuChart
            // 
            this.btnDoanhThuChart.BackgroundImage = global::GUI_QuanLySieuThi.Properties.Resources.cot;
            this.btnDoanhThuChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoanhThuChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThuChart.Location = new System.Drawing.Point(291, 16);
            this.btnDoanhThuChart.Name = "btnDoanhThuChart";
            this.btnDoanhThuChart.Size = new System.Drawing.Size(267, 246);
            this.btnDoanhThuChart.TabIndex = 3;
            this.btnDoanhThuChart.Text = "Doanh Thu Theo Biểu Đồ";
            this.btnDoanhThuChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoanhThuChart.UseVisualStyleBackColor = true;
            this.btnDoanhThuChart.Click += new System.EventHandler(this.btnDoanhThuChart_Click_1);
            // 
            // btnDoanhThuDate
            // 
            this.btnDoanhThuDate.BackgroundImage = global::GUI_QuanLySieuThi.Properties.Resources.Daymonthyear;
            this.btnDoanhThuDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoanhThuDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThuDate.Location = new System.Drawing.Point(18, 16);
            this.btnDoanhThuDate.Name = "btnDoanhThuDate";
            this.btnDoanhThuDate.Size = new System.Drawing.Size(267, 246);
            this.btnDoanhThuDate.TabIndex = 4;
            this.btnDoanhThuDate.Text = "Doanh Thu Theo Bảng";
            this.btnDoanhThuDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoanhThuDate.UseVisualStyleBackColor = true;
            this.btnDoanhThuDate.Click += new System.EventHandler(this.btnDoanhThuDate_Click_1);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 532);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiLeBanHang);
            this.Controls.Add(this.btnDoanhThuChart);
            this.Controls.Add(this.btnDoanhThuDate);
            this.Name = "ThongKe";
            this.Text = "Thống Kê Doanh Thu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTiLeBanHang;
        private System.Windows.Forms.Button btnDoanhThuChart;
        private System.Windows.Forms.Button btnDoanhThuDate;
    }
}