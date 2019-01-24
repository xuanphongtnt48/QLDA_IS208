namespace NMCNPM
{
    partial class QL_BC_TKHK
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
            this.components = new System.ComponentModel.Container();
            this.cbb_HK = new System.Windows.Forms.ComboBox();
            this.cbb_Lop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_BCTK = new System.Windows.Forms.DataGridView();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.qlsv1DataSet = new NMCNPM.Qlsv1DataSet();
            this.tONGKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tONGKETTableAdapter = new NMCNPM.Qlsv1DataSetTableAdapters.TONGKETTableAdapter();
            this.tableAdapterManager = new NMCNPM.Qlsv1DataSetTableAdapters.TableAdapterManager();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHocKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDatHKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyLeHKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BCTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGKETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_HK
            // 
            this.cbb_HK.FormattingEnabled = true;
            this.cbb_HK.Location = new System.Drawing.Point(539, 36);
            this.cbb_HK.Name = "cbb_HK";
            this.cbb_HK.Size = new System.Drawing.Size(83, 24);
            this.cbb_HK.TabIndex = 5;
            // 
            // cbb_Lop
            // 
            this.cbb_Lop.FormattingEnabled = true;
            this.cbb_Lop.Location = new System.Drawing.Point(214, 36);
            this.cbb_Lop.Name = "cbb_Lop";
            this.cbb_Lop.Size = new System.Drawing.Size(180, 24);
            this.cbb_Lop.TabIndex = 6;
            this.cbb_Lop.SelectedIndexChanged += new System.EventHandler(this.cbb_MaMon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học kỳ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lớp:";
            // 
            // dtgv_BCTK
            // 
            this.dtgv_BCTK.AutoGenerateColumns = false;
            this.dtgv_BCTK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_BCTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BCTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lop,
            this.SiSo,
            this.SoLuongDat,
            this.TyLe,
            this.maLopDataGridViewTextBoxColumn,
            this.maHocKyDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.siSoDataGridViewTextBoxColumn,
            this.soLuongDatHKDataGridViewTextBoxColumn,
            this.tyLeHKDataGridViewTextBoxColumn});
            this.dtgv_BCTK.DataSource = this.tONGKETBindingSource;
            this.dtgv_BCTK.Location = new System.Drawing.Point(106, 101);
            this.dtgv_BCTK.Name = "dtgv_BCTK";
            this.dtgv_BCTK.ReadOnly = true;
            this.dtgv_BCTK.RowTemplate.Height = 24;
            this.dtgv_BCTK.Size = new System.Drawing.Size(573, 254);
            this.dtgv_BCTK.TabIndex = 8;
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(360, 72);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(75, 23);
            this.btn_Xem.TabIndex = 9;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // qlsv1DataSet
            // 
            this.qlsv1DataSet.DataSetName = "Qlsv1DataSet";
            this.qlsv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tONGKETBindingSource
            // 
            this.tONGKETBindingSource.DataMember = "TONGKET";
            this.tONGKETBindingSource.DataSource = this.qlsv1DataSet;
            // 
            // tONGKETTableAdapter
            // 
            this.tONGKETTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.GIANGDAYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.KHOITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.THAMSOTableAdapter = null;
            this.tableAdapterManager.TONGKETTableAdapter = this.tONGKETTableAdapter;
            this.tableAdapterManager.UpdateOrder = NMCNPM.Qlsv1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLOPTableAdapter = null;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // SiSo
            // 
            this.SiSo.HeaderText = "Sĩ số";
            this.SiSo.Name = "SiSo";
            this.SiSo.ReadOnly = true;
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.HeaderText = "Số lượng đạt";
            this.SoLuongDat.Name = "SoLuongDat";
            this.SoLuongDat.ReadOnly = true;
            this.SoLuongDat.Width = 130;
            // 
            // TyLe
            // 
            this.TyLe.HeaderText = "Tỷ lệ";
            this.TyLe.Name = "TyLe";
            this.TyLe.ReadOnly = true;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maHocKyDataGridViewTextBoxColumn
            // 
            this.maHocKyDataGridViewTextBoxColumn.DataPropertyName = "MaHocKy";
            this.maHocKyDataGridViewTextBoxColumn.HeaderText = "MaHocKy";
            this.maHocKyDataGridViewTextBoxColumn.Name = "maHocKyDataGridViewTextBoxColumn";
            this.maHocKyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Nam";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siSoDataGridViewTextBoxColumn
            // 
            this.siSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo";
            this.siSoDataGridViewTextBoxColumn.HeaderText = "SiSo";
            this.siSoDataGridViewTextBoxColumn.Name = "siSoDataGridViewTextBoxColumn";
            this.siSoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDatHKDataGridViewTextBoxColumn
            // 
            this.soLuongDatHKDataGridViewTextBoxColumn.DataPropertyName = "SoLuongDatHK";
            this.soLuongDatHKDataGridViewTextBoxColumn.HeaderText = "SoLuongDatHK";
            this.soLuongDatHKDataGridViewTextBoxColumn.Name = "soLuongDatHKDataGridViewTextBoxColumn";
            this.soLuongDatHKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tyLeHKDataGridViewTextBoxColumn
            // 
            this.tyLeHKDataGridViewTextBoxColumn.DataPropertyName = "TyLeHK";
            this.tyLeHKDataGridViewTextBoxColumn.HeaderText = "TyLeHK";
            this.tyLeHKDataGridViewTextBoxColumn.Name = "tyLeHKDataGridViewTextBoxColumn";
            this.tyLeHKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QL_BC_TKHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 367);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.dtgv_BCTK);
            this.Controls.Add(this.cbb_HK);
            this.Controls.Add(this.cbb_Lop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QL_BC_TKHK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Tổng Kết Học Kỳ";
            this.Load += new System.EventHandler(this.QL_BC_TKHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BCTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGKETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbb_HK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_BCTK;
        private System.Windows.Forms.Button btn_Xem;
        public System.Windows.Forms.ComboBox cbb_Lop;
        private Qlsv1DataSet qlsv1DataSet;
        private System.Windows.Forms.BindingSource tONGKETBindingSource;
        private Qlsv1DataSetTableAdapters.TONGKETTableAdapter tONGKETTableAdapter;
        private Qlsv1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHocKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDatHKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyLeHKDataGridViewTextBoxColumn;
    }
}