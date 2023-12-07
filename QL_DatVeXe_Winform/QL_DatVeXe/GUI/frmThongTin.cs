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
    public partial class frmThongTin : Form
    {
        NhanVien_BLL_DAL nhanVien = new NhanVien_BLL_DAL();
        int maNV = 0;
        public frmThongTin(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            NHANVIEN nv = nhanVien.getDataOneNhanVien(maNV);
            if (nv != null )
            {
                txtMaNV.Text = nv.MANV.ToString();
                txtHoTen.Text = nv.TENNV.ToString();
                txtDiaChi.Text = nv.DIACHI.ToString();
                txtGioiTinh.Text = nv.GIOITINH.ToString();
                txtNgaySinh.Text = nv.NGAYSINH.ToString();
                txtSDT.Text = nv.SDT.ToString();
                txtTrangThai.Text = nv.TrangThai.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập nhật")
            {
                txtHoTen.Enabled = true;
                txtDiaChi.Enabled = true;
                txtGioiTinh.Enabled = true;
                txtNgaySinh.Enabled = true;
                txtSDT.Enabled = true;
                btnCapNhat.Text = "Lưu";
            }
            else
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = Int32.Parse(txtMaNV.Text);
                nv.TENNV = txtHoTen.Text;
                nv.SDT = txtSDT.Text;
                nv.GIOITINH = txtGioiTinh.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.NGAYSINH = DateTime.Parse(txtNgaySinh.Text);
                nv.TrangThai = txtTrangThai.Text;

                if (nhanVien.updateNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                    MessageBox.Show("Cập nhật thất bại !!");
            }
        }
    }
}
