namespace GUI
{
    partial class frmHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYLAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDSHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Hóa đơn";
            // 
            // dtgvDSHoaDon
            // 
            this.dtgvDSHoaDon.AutoGenerateColumns = false;
            this.dtgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn,
            this.nGAYLAPDataGridViewTextBoxColumn,
            this.tHANHTIENDataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewTextBoxColumn,
            this.kHACHHANGDataGridViewTextBoxColumn});
            this.dtgvDSHoaDon.DataSource = this.hOADONBindingSource;
            this.dtgvDSHoaDon.Location = new System.Drawing.Point(6, 19);
            this.dtgvDSHoaDon.Name = "dtgvDSHoaDon";
            this.dtgvDSHoaDon.Size = new System.Drawing.Size(764, 224);
            this.dtgvDSHoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết Hóa đơn";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(695, 295);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 39);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataSource = typeof(BLL_DAL.HOADON);
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // nGAYLAPDataGridViewTextBoxColumn
            // 
            this.nGAYLAPDataGridViewTextBoxColumn.DataPropertyName = "NGAYLAP";
            this.nGAYLAPDataGridViewTextBoxColumn.HeaderText = "NGAYLAP";
            this.nGAYLAPDataGridViewTextBoxColumn.Name = "nGAYLAPDataGridViewTextBoxColumn";
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            // 
            // tRANGTHAIDataGridViewTextBoxColumn
            // 
            this.tRANGTHAIDataGridViewTextBoxColumn.DataPropertyName = "TRANGTHAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.HeaderText = "TRANGTHAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.Name = "tRANGTHAIDataGridViewTextBoxColumn";
            // 
            // kHACHHANGDataGridViewTextBoxColumn
            // 
            this.kHACHHANGDataGridViewTextBoxColumn.DataPropertyName = "KHACHHANG";
            this.kHACHHANGDataGridViewTextBoxColumn.HeaderText = "KHACHHANG";
            this.kHACHHANGDataGridViewTextBoxColumn.Name = "kHACHHANGDataGridViewTextBoxColumn";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dtgvDSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYLAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
    }
}