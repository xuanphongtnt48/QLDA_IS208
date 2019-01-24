namespace NMCNPM
{
    partial class QL_BC_TKM
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Mon = new System.Windows.Forms.ComboBox();
            this.dtgv_BCM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_HK = new System.Windows.Forms.ComboBox();
            this.qlsv1DataSet = new NMCNPM.Qlsv1DataSet();
            this.tONGKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tONGKETTableAdapter = new NMCNPM.Qlsv1DataSetTableAdapters.TONGKETTableAdapter();
            this.tableAdapterManager = new NMCNPM.Qlsv1DataSetTableAdapters.TableAdapterManager();
            this.tONGKETDataGridView = new System.Windows.Forms.DataGridView();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHocKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDatHKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyLeHKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qlhsDataSet = new NMCNPM.qlhsDataSet();
            this.btn_Xem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BCM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGKETDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbb_Mon
            // 
            this.cbb_Mon.FormattingEnabled = true;
            this.cbb_Mon.Location = new System.Drawing.Point(214, 35);
            this.cbb_Mon.Name = "cbb_Mon";
            this.cbb_Mon.Size = new System.Drawing.Size(180, 24);
            this.cbb_Mon.TabIndex = 1;
            // 
            // dtgv_BCM
            // 
            this.dtgv_BCM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_BCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BCM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lop,
            this.SiSo,
            this.SoLuongDat,
            this.TyLe});
            this.dtgv_BCM.Location = new System.Drawing.Point(106, 101);
            this.dtgv_BCM.Name = "dtgv_BCM";
            this.dtgv_BCM.ReadOnly = true;
            this.dtgv_BCM.RowTemplate.Height = 24;
            this.dtgv_BCM.Size = new System.Drawing.Size(573, 254);
            this.dtgv_BCM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học kỳ:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbb_HK
            // 
            this.cbb_HK.FormattingEnabled = true;
            this.cbb_HK.Location = new System.Drawing.Point(539, 35);
            this.cbb_HK.Name = "cbb_HK";
            this.cbb_HK.Size = new System.Drawing.Size(83, 24);
            this.cbb_HK.TabIndex = 1;
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
            // tONGKETDataGridView
            // 
            this.tONGKETDataGridView.AutoGenerateColumns = false;
            this.tONGKETDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tONGKETDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopDataGridViewTextBoxColumn,
            this.maHocKyDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.siSoDataGridViewTextBoxColumn,
            this.soLuongDatHKDataGridViewTextBoxColumn,
            this.tyLeHKDataGridViewTextBoxColumn});
            this.tONGKETDataGridView.DataSource = this.tONGKETBindingSource;
            this.tONGKETDataGridView.Location = new System.Drawing.Point(743, 305);
            this.tONGKETDataGridView.Name = "tONGKETDataGridView";
            this.tONGKETDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tONGKETDataGridView.TabIndex = 6;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            // 
            // maHocKyDataGridViewTextBoxColumn
            // 
            this.maHocKyDataGridViewTextBoxColumn.DataPropertyName = "MaHocKy";
            this.maHocKyDataGridViewTextBoxColumn.HeaderText = "MaHocKy";
            this.maHocKyDataGridViewTextBoxColumn.Name = "maHocKyDataGridViewTextBoxColumn";
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Nam";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            // 
            // siSoDataGridViewTextBoxColumn
            // 
            this.siSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo";
            this.siSoDataGridViewTextBoxColumn.HeaderText = "SiSo";
            this.siSoDataGridViewTextBoxColumn.Name = "siSoDataGridViewTextBoxColumn";
            // 
            // soLuongDatHKDataGridViewTextBoxColumn
            // 
            this.soLuongDatHKDataGridViewTextBoxColumn.DataPropertyName = "SoLuongDatHK";
            this.soLuongDatHKDataGridViewTextBoxColumn.HeaderText = "SoLuongDatHK";
            this.soLuongDatHKDataGridViewTextBoxColumn.Name = "soLuongDatHKDataGridViewTextBoxColumn";
            // 
            // tyLeHKDataGridViewTextBoxColumn
            // 
            this.tyLeHKDataGridViewTextBoxColumn.DataPropertyName = "TyLeHK";
            this.tyLeHKDataGridViewTextBoxColumn.HeaderText = "TyLeHK";
            this.tyLeHKDataGridViewTextBoxColumn.Name = "tyLeHKDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLop";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaLop";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHocKy";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaHocKy";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SiSo";
            this.dataGridViewTextBoxColumn4.HeaderText = "SiSo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SoLuongDatHK";
            this.dataGridViewTextBoxColumn5.HeaderText = "SoLuongDatHK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TyLeHK";
            this.dataGridViewTextBoxColumn6.HeaderText = "TyLeHK";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "MaLop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ số";
            this.SiSo.Name = "SiSo";
            this.SiSo.ReadOnly = true;
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.DataPropertyName = "SoLuongDat";
            this.SoLuongDat.HeaderText = "Số lượng đạt";
            this.SoLuongDat.Name = "SoLuongDat";
            this.SoLuongDat.ReadOnly = true;
            this.SoLuongDat.Width = 130;
            // 
            // TyLe
            // 
            this.TyLe.DataPropertyName = "TyLe";
            this.TyLe.HeaderText = "Tỷ lệ";
            this.TyLe.Name = "TyLe";
            this.TyLe.ReadOnly = true;
            // 
            // qlhsDataSet
            // 
            this.qlhsDataSet.DataSetName = "qlhsDataSet";
            this.qlhsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(366, 72);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(75, 23);
            this.btn_Xem.TabIndex = 7;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // QL_BC_TKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 545);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.tONGKETDataGridView);
            this.Controls.Add(this.dtgv_BCM);
            this.Controls.Add(this.cbb_HK);
            this.Controls.Add(this.cbb_Mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QL_BC_TKM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Tổng Kết Môn";
            this.Load += new System.EventHandler(this.QL_BC_TKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BCM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGKETDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Mon;
        private System.Windows.Forms.DataGridView dtgv_BCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private Qlsv1DataSet qlsv1DataSet;
        private System.Windows.Forms.BindingSource tONGKETBindingSource;
        private Qlsv1DataSetTableAdapters.TONGKETTableAdapter tONGKETTableAdapter;
        private Qlsv1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tONGKETDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHocKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDatHKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyLeHKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private qlhsDataSet qlhsDataSet;
        private System.Windows.Forms.Button btn_Xem;
    }
}