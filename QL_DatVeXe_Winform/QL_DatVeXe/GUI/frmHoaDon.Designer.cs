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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenVe = new System.Windows.Forms.TextBox();
            this.txtDiemDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayVe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayDi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonLuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoTatCa = new System.Windows.Forms.RadioButton();
            this.rdoChuaXacNhan = new System.Windows.Forms.RadioButton();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNGUOIDATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOGHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYLAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADONBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNgayVe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNgayDi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDonLuc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDiemDen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDiemDon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenVe);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết Vé";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Location = new System.Drawing.Point(126, 25);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(95, 67);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận Đơn";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AutoGenerateColumns = false;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn,
            this.tENNGUOIDATDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.sOGHEDataGridViewTextBoxColumn,
            this.tHANHTIENDataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewTextBoxColumn,
            this.nGAYLAPDataGridViewTextBoxColumn});
            this.dtgvHoaDon.DataSource = this.hOADONBindingSource2;
            this.dtgvHoaDon.Location = new System.Drawing.Point(6, 19);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.Size = new System.Drawing.Size(748, 150);
            this.dtgvHoaDon.TabIndex = 0;
            this.dtgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên vé: ";
            // 
            // txtTenVe
            // 
            this.txtTenVe.Enabled = false;
            this.txtTenVe.Location = new System.Drawing.Point(74, 21);
            this.txtTenVe.Name = "txtTenVe";
            this.txtTenVe.Size = new System.Drawing.Size(145, 20);
            this.txtTenVe.TabIndex = 1;
            // 
            // txtDiemDon
            // 
            this.txtDiemDon.Enabled = false;
            this.txtDiemDon.Location = new System.Drawing.Point(74, 56);
            this.txtDiemDon.Name = "txtDiemDon";
            this.txtDiemDon.Size = new System.Drawing.Size(145, 20);
            this.txtDiemDon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm đón: ";
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Enabled = false;
            this.txtDiemDen.Location = new System.Drawing.Point(74, 90);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(145, 20);
            this.txtDiemDen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = " Điểm đến: ";
            // 
            // txtNgayVe
            // 
            this.txtNgayVe.Enabled = false;
            this.txtNgayVe.Location = new System.Drawing.Point(333, 90);
            this.txtNgayVe.Name = "txtNgayVe";
            this.txtNgayVe.Size = new System.Drawing.Size(165, 20);
            this.txtNgayVe.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày về: ";
            // 
            // txtNgayDi
            // 
            this.txtNgayDi.Enabled = false;
            this.txtNgayDi.Location = new System.Drawing.Point(333, 56);
            this.txtNgayDi.Name = "txtNgayDi";
            this.txtNgayDi.Size = new System.Drawing.Size(165, 20);
            this.txtNgayDi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày đi: ";
            // 
            // txtDonLuc
            // 
            this.txtDonLuc.Enabled = false;
            this.txtDonLuc.Location = new System.Drawing.Point(333, 21);
            this.txtDonLuc.Name = "txtDonLuc";
            this.txtDonLuc.Size = new System.Drawing.Size(165, 20);
            this.txtDonLuc.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Đón lúc: ";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(6, 29);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Size = new System.Drawing.Size(120, 63);
            this.radioGroup1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoChuaXacNhan);
            this.groupBox3.Controls.Add(this.btnXacNhan);
            this.groupBox3.Controls.Add(this.rdoTatCa);
            this.groupBox3.Controls.Add(this.radioGroup1);
            this.groupBox3.Location = new System.Drawing.Point(545, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 123);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị";
            // 
            // rdoTatCa
            // 
            this.rdoTatCa.AutoSize = true;
            this.rdoTatCa.Checked = true;
            this.rdoTatCa.Location = new System.Drawing.Point(16, 29);
            this.rdoTatCa.Name = "rdoTatCa";
            this.rdoTatCa.Size = new System.Drawing.Size(56, 17);
            this.rdoTatCa.TabIndex = 6;
            this.rdoTatCa.TabStop = true;
            this.rdoTatCa.Text = "Tất cả";
            this.rdoTatCa.UseVisualStyleBackColor = true;
            this.rdoTatCa.CheckedChanged += new System.EventHandler(this.rdoTatCa_CheckedChanged);
            // 
            // rdoChuaXacNhan
            // 
            this.rdoChuaXacNhan.AutoSize = true;
            this.rdoChuaXacNhan.Location = new System.Drawing.Point(16, 64);
            this.rdoChuaXacNhan.Name = "rdoChuaXacNhan";
            this.rdoChuaXacNhan.Size = new System.Drawing.Size(99, 17);
            this.rdoChuaXacNhan.TabIndex = 7;
            this.rdoChuaXacNhan.Text = "Chưa Xác nhận";
            this.rdoChuaXacNhan.UseVisualStyleBackColor = true;
            this.rdoChuaXacNhan.CheckedChanged += new System.EventHandler(this.rdoChuaXacNhan_CheckedChanged);
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.FillWeight = 109F;
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "Mã Hóa đơn";
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            this.mAHDDataGridViewTextBoxColumn.Width = 109;
            // 
            // tENNGUOIDATDataGridViewTextBoxColumn
            // 
            this.tENNGUOIDATDataGridViewTextBoxColumn.DataPropertyName = "TENNGUOIDAT";
            this.tENNGUOIDATDataGridViewTextBoxColumn.FillWeight = 140F;
            this.tENNGUOIDATDataGridViewTextBoxColumn.HeaderText = "Khách hàng";
            this.tENNGUOIDATDataGridViewTextBoxColumn.Name = "tENNGUOIDATDataGridViewTextBoxColumn";
            this.tENNGUOIDATDataGridViewTextBoxColumn.Width = 140;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // sOGHEDataGridViewTextBoxColumn
            // 
            this.sOGHEDataGridViewTextBoxColumn.DataPropertyName = "SOGHE";
            this.sOGHEDataGridViewTextBoxColumn.FillWeight = 65F;
            this.sOGHEDataGridViewTextBoxColumn.HeaderText = "Số ghế";
            this.sOGHEDataGridViewTextBoxColumn.Name = "sOGHEDataGridViewTextBoxColumn";
            this.sOGHEDataGridViewTextBoxColumn.Width = 65;
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            // 
            // tRANGTHAIDataGridViewTextBoxColumn
            // 
            this.tRANGTHAIDataGridViewTextBoxColumn.DataPropertyName = "TRANGTHAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.FillWeight = 80F;
            this.tRANGTHAIDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.tRANGTHAIDataGridViewTextBoxColumn.Name = "tRANGTHAIDataGridViewTextBoxColumn";
            this.tRANGTHAIDataGridViewTextBoxColumn.Width = 80;
            // 
            // nGAYLAPDataGridViewTextBoxColumn
            // 
            this.nGAYLAPDataGridViewTextBoxColumn.DataPropertyName = "NGAYLAP";
            this.nGAYLAPDataGridViewTextBoxColumn.FillWeight = 95F;
            this.nGAYLAPDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.nGAYLAPDataGridViewTextBoxColumn.Name = "nGAYLAPDataGridViewTextBoxColumn";
            this.nGAYLAPDataGridViewTextBoxColumn.Width = 95;
            // 
            // hOADONBindingSource2
            // 
            this.hOADONBindingSource2.DataSource = typeof(BLL_DAL.HOADON);
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataSource = typeof(BLL_DAL.HOADON);
            // 
            // hOADONBindingSource1
            // 
            this.hOADONBindingSource1.DataSource = typeof(BLL_DAL.HOADON);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private System.Windows.Forms.BindingSource hOADONBindingSource1;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.BindingSource hOADONBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNGUOIDATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOGHEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYLAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayVe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayDi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonLuc;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoTatCa;
        private System.Windows.Forms.RadioButton rdoChuaXacNhan;
    }
}