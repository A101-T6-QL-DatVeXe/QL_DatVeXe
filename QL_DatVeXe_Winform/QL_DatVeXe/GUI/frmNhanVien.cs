using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        NhanVien_BLL_DAL nhanVien = new NhanVien_BLL_DAL();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        void setEnabledText(bool enabled)
        {
            txtTenNV.Enabled = enabled;
            txtTrangThai.Enabled = enabled;
            txtSDT.Enabled = enabled;
            txtGioiTinh.Enabled = enabled;
            txtDiaChi.Enabled = enabled;
            txtNgaySinh.Enabled = enabled;
        }

        void loadDataNhanVien()
        {
            dtgvNhanVien.DataSource = nhanVien.getDataNhanVien();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadDataNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnMoi.Enabled = true;
            setEnabledText(false);
            btnThem.Enabled = false;

            NHANVIEN nv = new NHANVIEN();
            nv.TENNV = txtTenNV.Text;
            nv.SDT = txtSDT.Text;
            nv.GIOITINH = txtGioiTinh.Text;   
            nv.DIACHI = txtDiaChi.Text;
            nv.NGAYSINH = DateTime.Parse(txtNgaySinh.Text);
            nv.TrangThai = txtTrangThai.Text;

            if (nhanVien.addNewNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công");
                loadDataNhanVien();
            }
            else
                MessageBox.Show("Trùng khóa chính!");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhanVien.deleteNhanVien(Int32.Parse(txtMaNV.Text)))
            {
                MessageBox.Show("Xóa thành công");
                loadDataNhanVien();
            }
            else
                MessageBox.Show("Không tìm thấy !!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(btnSua.Text == "Lưu")
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = Int32.Parse(txtMaNV.Text);
                nv.TENNV = txtTenNV.Text;
                nv.SDT = txtSDT.Text;
                nv.GIOITINH = txtGioiTinh.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.NGAYSINH = DateTime.Parse(txtNgaySinh.Text);
                nv.TrangThai = txtTrangThai.Text;

                if (nhanVien.updateNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật thành công");
                    loadDataNhanVien();
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

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            setEnabledText(true);
            btnMoi.Enabled = false;
            txtTenNV.ResetText();
            //txtTrangThai.ResetText();
            txtSDT.ResetText();
            //txtGioiTinh.ResetText();
            txtDiaChi.ResetText();
            txtNgaySinh.ResetText();
            txtTenNV.Focus();
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dtgvNhanVien.Rows[row].Cells[0].Value.ToString();
            txtTenNV.Text = dtgvNhanVien.Rows[row].Cells[1].Value.ToString();
            txtNgaySinh.Text = dtgvNhanVien.Rows[row].Cells[2].Value.ToString();
            txtGioiTinh.Text = dtgvNhanVien.Rows[row].Cells[3].Value.ToString();
            txtDiaChi.Text = dtgvNhanVien.Rows[row].Cells[4].Value.ToString();
            txtSDT.Text = dtgvNhanVien.Rows[row].Cells[5].Value.ToString();
            txtTrangThai.Text = dtgvNhanVien.Rows[row].Cells[6].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
