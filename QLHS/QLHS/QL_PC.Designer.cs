namespace NMCNPM
{
    partial class QL_PC
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
            this.cbChonKhoi = new System.Windows.Forms.ComboBox();
            this.txNamHoc = new System.Windows.Forms.TextBox();
            this.butOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChonMon = new System.Windows.Forms.ComboBox();
            this.cbChonGiaoVien = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbChonHK = new System.Windows.Forms.ComboBox();
            this.cbChonLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgPC = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPC)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChonKhoi
            // 
            this.cbChonKhoi.FormattingEnabled = true;
            this.cbChonKhoi.Location = new System.Drawing.Point(136, 25);
            this.cbChonKhoi.Name = "cbChonKhoi";
            this.cbChonKhoi.Size = new System.Drawing.Size(121, 24);
            this.cbChonKhoi.TabIndex = 1;
            this.cbChonKhoi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txNamHoc
            // 
            this.txNamHoc.Location = new System.Drawing.Point(134, 130);
            this.txNamHoc.Name = "txNamHoc";
            this.txNamHoc.Size = new System.Drawing.Size(144, 23);
            this.txNamHoc.TabIndex = 1;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(107, 170);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(91, 42);
            this.butOK.TabIndex = 2;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lớp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.butXoa);
            this.groupBox1.Controls.Add(this.butSua);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbChonMon);
            this.groupBox1.Controls.Add(this.cbChonGiaoVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(30, 157);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(91, 42);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(200, 157);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(91, 42);
            this.butXoa.TabIndex = 2;
            this.butXoa.Text = "Xoá";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(362, 157);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(91, 42);
            this.butSua.TabIndex = 2;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giáo viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Môn:";
            // 
            // cbChonMon
            // 
            this.cbChonMon.FormattingEnabled = true;
            this.cbChonMon.Location = new System.Drawing.Point(180, 57);
            this.cbChonMon.Name = "cbChonMon";
            this.cbChonMon.Size = new System.Drawing.Size(174, 24);
            this.cbChonMon.TabIndex = 0;
            // 
            // cbChonGiaoVien
            // 
            this.cbChonGiaoVien.FormattingEnabled = true;
            this.cbChonGiaoVien.Location = new System.Drawing.Point(180, 102);
            this.cbChonGiaoVien.Name = "cbChonGiaoVien";
            this.cbChonGiaoVien.Size = new System.Drawing.Size(262, 24);
            this.cbChonGiaoVien.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butOK);
            this.groupBox2.Controls.Add(this.cbChonHK);
            this.groupBox2.Controls.Add(this.cbChonLop);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txNamHoc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbChonKhoi);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 230);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cbChonHK
            // 
            this.cbChonHK.FormattingEnabled = true;
            this.cbChonHK.Location = new System.Drawing.Point(136, 93);
            this.cbChonHK.Name = "cbChonHK";
            this.cbChonHK.Size = new System.Drawing.Size(121, 24);
            this.cbChonHK.TabIndex = 0;
            // 
            // cbChonLop
            // 
            this.cbChonLop.FormattingEnabled = true;
            this.cbChonLop.Location = new System.Drawing.Point(136, 59);
            this.cbChonLop.Name = "cbChonLop";
            this.cbChonLop.Size = new System.Drawing.Size(121, 24);
            this.cbChonLop.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Học kì:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn khối:";
            // 
            // dtgPC
            // 
            this.dtgPC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.MaMon,
            this.MaGiaoVien,
            this.MaHocKy});
            this.dtgPC.Location = new System.Drawing.Point(530, 101);
            this.dtgPC.Name = "dtgPC";
            this.dtgPC.ReadOnly = true;
            this.dtgPC.RowTemplate.Height = 24;
            this.dtgPC.Size = new System.Drawing.Size(482, 412);
            this.dtgPC.TabIndex = 5;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Môn";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien.HeaderText = "Giáo viên";
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.ReadOnly = true;
            // 
            // MaHocKy
            // 
            this.MaHocKy.DataPropertyName = "MaHocKy";
            this.MaHocKy.HeaderText = "Học kỳ";
            this.MaHocKy.Name = "MaHocKy";
            this.MaHocKy.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bảng phân công năm học - Năm học:";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(825, 59);
            this.txtNam.Name = "txtNam";
            this.txtNam.ReadOnly = true;
            this.txtNam.Size = new System.Drawing.Size(144, 23);
            this.txtNam.TabIndex = 1;
            // 
            // QL_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 564);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgPC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QL_PC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công giảng dạy";
            this.Load += new System.EventHandler(this.QL_PC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChonKhoi;
        private System.Windows.Forms.TextBox txNamHoc;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbChonMon;
        private System.Windows.Forms.ComboBox cbChonGiaoVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbChonHK;
        private System.Windows.Forms.ComboBox cbChonLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgPC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocKy;
    }
}