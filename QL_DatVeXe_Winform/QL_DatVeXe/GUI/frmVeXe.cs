using BLL_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmVeXe : Form
    {
        VeXe_BLL_DAL veXe = new VeXe_BLL_DAL();
        public frmVeXe()
        {
            InitializeComponent();
        }

        void setEnabledText(bool enabled)
        {
            txtTenVe.Enabled = enabled;
            txtGiaVe.Enabled = enabled;
            txtGheTrong.Enabled = enabled;
            txtDiemDen.Enabled = enabled;
            txtDiemDon.Enabled = enabled;
            txtNgayDi.Enabled = enabled;
            txtNgayVe.Enabled = enabled;
            txtGio.Enabled = enabled;
            txtPhut.Enabled = enabled;
        }

        void loadDataVeXe()
        {
            dtgvVeXe.DataSource = veXe.getDataVeXe();
        }

        private void frmVeXe_Load(object sender, EventArgs e)
        {
            loadDataVeXe();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            setEnabledText(true);
            txtMaVe.ResetText();
            txtTenVe.ResetText();
            txtGiaVe.ResetText();
            txtGheTrong.ResetText();
            txtDiemDen.ResetText();
            txtDiemDon.ResetText();
            txtNgayDi.ResetText();
            txtNgayVe.ResetText();
            txtGio.ResetText();
            txtPhut.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnMoi.Enabled = true;
            setEnabledText(false);
            btnThem.Enabled = false;

            VEXE vx = new VEXE();
            vx.TENVE = txtTenVe.Text;
            vx.GIAVE = Int32.Parse(txtGiaVe.Text);
            vx.CONTRONG = Int32.Parse(txtGheTrong.Text);
            vx.DIEMDON = txtDiemDon.Text;
            vx.DIEMDEN = txtDiemDen.Text;
            vx.NGAYDI = DateTime.Parse(txtNgayDi.Text);
            vx.NGAYVE = DateTime.Parse(txtNgayVe.Text);
            vx.THOIGIANDON = txtGio.Text + " giờ " + txtPhut.Text + " phút";
            vx.MOTA = "Giường nằm 40 chỗ có toilet";
            vx.HINHANH = "phuongnam.jpeg";

            if (veXe.addNewVeXe(vx))
            {
                MessageBox.Show("Thêm thành công");
                loadDataVeXe();
            }
            else
                MessageBox.Show("Trùng khóa chính!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (veXe.deleteVeXe(Int32.Parse(txtMaVe.Text)))
            {
                MessageBox.Show("Xóa thành công");
                loadDataVeXe();
            }
            else
                MessageBox.Show("Không tìm thấy !!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Lưu")
            {
                VEXE vx = new VEXE();
                vx.MAVE = Int32.Parse(txtMaVe.Text);
                vx.TENVE = txtTenVe.Text;
                vx.GIAVE = Int32.Parse(txtGiaVe.Text);
                vx.CONTRONG = Int32.Parse(txtGheTrong.Text);
                vx.DIEMDON = txtDiemDon.Text;
                vx.DIEMDEN = txtDiemDen.Text;
                vx.NGAYDI = DateTime.Parse(txtNgayDi.Text);
                vx.NGAYVE = DateTime.Parse(txtNgayVe.Text);
                vx.THOIGIANDON = txtGio.Text + " giờ " + txtPhut.Text + " phút";
                vx.MOTA = "Giường nằm 40 chỗ có toilet";
                vx.HINHANH = "offer_4.jpg";

                btnSua.Text = "Sửa";

                if (veXe.updateVeXe(vx))
                {
                    MessageBox.Show("Cập nhật thành công");
                    loadDataVeXe();
                }
                else
                    MessageBox.Show("Không tìm thấy !!");
            }
            else
            {
                setEnabledText(true);
                btnSua.Text = "Lưu";
            }
        }

        private void dtgvVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgvVeXe.CurrentRow.Index;
            txtMaVe.Text = dtgvVeXe.Rows[row].Cells[0].Value.ToString();
            txtTenVe.Text = dtgvVeXe.Rows[row].Cells[1].Value.ToString();
            txtGiaVe.Text = dtgvVeXe.Rows[row].Cells[2].Value.ToString();
            txtGheTrong.Text = dtgvVeXe.Rows[row].Cells[3].Value.ToString();
            txtDiemDon.Text = dtgvVeXe.Rows[row].Cells[4].Value.ToString();
            txtDiemDen.Text = dtgvVeXe.Rows[row].Cells[5].Value.ToString();
            txtNgayDi.Text = dtgvVeXe.Rows[row].Cells[6].Value.ToString();
            txtNgayVe.Text = dtgvVeXe.Rows[row].Cells[7].Value.ToString();
            string timeGio = dtgvVeXe.Rows[row].Cells[8].Value.ToString();
            string timePhut = dtgvVeXe.Rows[row].Cells[8].Value.ToString();
            txtGio.Text = timeGio.Substring(0,2).Trim();
            txtPhut.Text = timePhut.Substring(0,2).Trim();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
