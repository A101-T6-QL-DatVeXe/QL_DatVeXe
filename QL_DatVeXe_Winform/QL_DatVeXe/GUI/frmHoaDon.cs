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
    public partial class frmHoaDon : Form
    {
        HoaDon_BLL_DAL hoaDon = new HoaDon_BLL_DAL();
        VeXe_BLL_DAL veXe = new VeXe_BLL_DAL();
      
        public frmHoaDon()
        {
            InitializeComponent();
        }

        void loadDataHoaDon()
        {
            dtgvHoaDon.DataSource = hoaDon.getDataHoaDon();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadDataHoaDon();
        }

        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgvHoaDon.CurrentRow.Index;
            btnXacNhan.Enabled = true;
            CHITIETHOADON cthd =  hoaDon.getOneChiTietHoaDon(Convert.ToInt32(dtgvHoaDon.Rows[row].Cells[0].Value.ToString()));
            if (cthd != null)
            {
                VEXE ve = veXe.getDataOneVeXe(cthd.MAVE);
                if (ve != null)
                {
                    txtTenVe.Text = ve.TENVE.ToString();
                    txtDiemDon.Text = ve.DIEMDON.ToString();
                    txtDiemDen.Text = ve.DIEMDEN.ToString();
                    txtDonLuc.Text = ve.THOIGIANDON.ToString();
                    txtNgayDi.Text = ve.NGAYDI.ToString();
                    txtNgayVe.Text = ve.NGAYVE.ToString();
                }
            }
        }

        private void rdoChuaXacNhan_CheckedChanged(object sender, EventArgs e)
        {
            dtgvHoaDon.DataSource = hoaDon.getDataHoaDonStateFalse();
            btnXacNhan.Enabled = false;
        }

        private void rdoTatCa_CheckedChanged(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = false;
            loadDataHoaDon();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = false;
            int row = dtgvHoaDon.CurrentRow.Index;
            int maHd = Convert.ToInt32(dtgvHoaDon.Rows[row].Cells[0].Value.ToString());
            int soGheDat = Convert.ToInt32(dtgvHoaDon.Rows[row].Cells[3].Value.ToString());
            bool checkUpdateStateHoaDon = hoaDon.updateStateHoaDon(maHd);
            CHITIETHOADON cthd = hoaDon.getOneChiTietHoaDon(maHd);
            if (cthd != null && checkUpdateStateHoaDon == true)
            {
                VEXE ve = veXe.getDataOneVeXe(cthd.MAVE);
                if (ve != null)
                {
                    bool checkUpdateSoGhe = veXe.updateSoGheVeXe(ve.MAVE, soGheDat);
                    if (checkUpdateSoGhe == true)
                    {
                        XACNHANHOADON xacNhan = new XACNHANHOADON();
                        xacNhan.MAHD = maHd;
                        xacNhan.MANV = 1;
                        xacNhan.NGAYXACNHAN = DateTime.Now;
                        if (hoaDon.addNewXacNhanHoaDon(xacNhan))
                        {
                            MessageBox.Show("Xác nhận đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDataHoaDon();
                        }                            
                        else MessageBox.Show("Xác nhận Thất bại", "Lỗi addNewXacNhanHoaDon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    else MessageBox.Show("Xác nhận Thất bại", "Lỗi updateSoGheVeXe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Xác nhận Thất bại", "Lỗi updateStateHoaDon", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
