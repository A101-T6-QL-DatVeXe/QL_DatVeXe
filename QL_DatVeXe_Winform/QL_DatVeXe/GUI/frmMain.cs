using BLL_DAL;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : XtraForm
    {
        public TAIKHOANNV tk;
        public frmMain(TAIKHOANNV taiKhoan)
        {
            InitializeComponent();
            nguoiDungToolStripMenuItem.Text = taiKhoan.TAIKHOAN;
            tk = taiKhoan;
            if (taiKhoan.QUYEN != "Quản lí")
            {
                nhânViênToolStripMenuItem.Visible = false;
            }

            panelControl.Controls.Clear();
            frmThongTin f = new frmThongTin(Convert.ToInt32(taiKhoan.MANV));
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelControl.Controls.Add(f);
            f.Show();
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
            panelControl.Controls.Clear();
            frmHoaDon f = new frmHoaDon();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelControl.Controls.Add(f);
            f.Show();
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

        private void nguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            frmThongTin f = new frmThongTin(Convert.ToInt32(tk.MANV));
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelControl.Controls.Add(f);
            f.Show();
        }
    }
}