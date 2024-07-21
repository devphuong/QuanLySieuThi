namespace GUI_QuanLySieuThi
{
    partial class BieuDoCot
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoaiSP = new System.Windows.Forms.Button();
            this.CmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoaiSP);
            this.groupBox1.Controls.Add(this.CmbLoaiSP);
            this.groupBox1.Location = new System.Drawing.Point(22, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Theo Mã Sản Phẩm";
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.Location = new System.Drawing.Point(120, 61);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Size = new System.Drawing.Size(75, 23);
            this.btnLoaiSP.TabIndex = 1;
            this.btnLoaiSP.Text = "Tìm";
            this.btnLoaiSP.UseVisualStyleBackColor = true;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // CmbLoaiSP
            // 
            this.CmbLoaiSP.FormattingEnabled = true;
            this.CmbLoaiSP.Location = new System.Drawing.Point(10, 26);
            this.CmbLoaiSP.Name = "CmbLoaiSP";
            this.CmbLoaiSP.Size = new System.Drawing.Size(313, 21);
            this.CmbLoaiSP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.txtMonth);
            this.groupBox2.Controls.Add(this.txtDay);
            this.groupBox2.Location = new System.Drawing.Point(375, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê Theo Ngày";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(132, 62);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 2;
            this.btnDate.Text = "Tìm";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(232, 30);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(75, 20);
            this.txtYear.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(132, 30);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(49, 20);
            this.txtMonth.TabIndex = 2;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(40, 30);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(42, 20);
            this.txtDay.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(375, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(180, 412);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(171, 33);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "Xuất tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "SoLuong";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(339, 274);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea12.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart2.Legends.Add(legend12);
            this.chart2.Location = new System.Drawing.Point(375, 12);
            this.chart2.Name = "chart2";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "VND";
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(339, 274);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // BieuDoCot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAll);
            this.Name = "BieuDoCot";
            this.Text = "BieuDoCot";
            this.Load += new System.EventHandler(this.BieuDoCot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoaiSP;
        private System.Windows.Forms.ComboBox CmbLoaiSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}