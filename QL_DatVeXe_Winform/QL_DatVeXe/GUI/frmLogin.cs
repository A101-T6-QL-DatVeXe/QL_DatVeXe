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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace GUI
{
    public partial class frmLogin : Form
    {
        Login_BLL_DAL login = new Login_BLL_DAL();
        NhanVien_BLL_DAL nhanVien_BLL_DAL = new NhanVien_BLL_DAL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String password = txtPassWord.Text;

            TAIKHOANNV taiKhoan = login.checkUserLogin(username, password);
            
            if (taiKhoan != null)
            {
                NHANVIEN nhanVien = nhanVien_BLL_DAL.getDataOneNhanVien((int)taiKhoan.MANV);
                if (nhanVien.TrangThai == "Đang làm" )
                {
                    frmMain formMain = new frmMain(taiKhoan);

                    this.Hide();
                    formMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản bị khóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
        }
    }
}
