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
    public partial class frmMain : Form
    {
        private bool isAdmin;
        private int idNV;

        NhanVien_BLL_DAL nhanVien = new NhanVien_BLL_DAL();

        public frmMain(TAIKHOANNV taiKhoan)
        {
            InitializeComponent();

            NHANVIEN nv = nhanVien.getDataOneNhanVien((int)taiKhoan.MANV);
            nguoiDungToolStripMenuItem.Text = nv.TENNV;
            //isAdmin = taiKhoan.QUYEN;

            if (!isAdmin)
            {
                nhânViênToolStripMenuItem.Visible = false;
            }
        }
    }
}
