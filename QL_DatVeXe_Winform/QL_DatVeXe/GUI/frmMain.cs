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
        public frmMain(TAIKHOANNV taiKhoan)
        {
            InitializeComponent();

            //NHANVIEN nv = nhanVien.getDataOneNhanVien((int)taiKhoan.MANV);
            nguoiDungToolStripMenuItem.Text = taiKhoan.TAIKHOAN;
            if (taiKhoan.QUYEN != "Quản lí")
            {
                nhânViênToolStripMenuItem.Visible = false;
            }
        }

        private void nguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void véXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            frmVeXe f = new frmVeXe();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelControl.Controls.Add(f);
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            frmNhanVien f = new frmNhanVien();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelControl.Controls.Add(f);
            f.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
