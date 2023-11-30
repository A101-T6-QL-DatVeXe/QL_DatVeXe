using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Login_BLL_DAL
    {
        QL_DatVeXeDataContext db = new QL_DatVeXeDataContext();

        public Login_BLL_DAL()
        {

        }

        public TAIKHOANNV checkUserLogin(string userNV, string passNV)
        {
            TAIKHOANNV taiKhoan = db.TAIKHOANNVs.Where(tk => tk.TAIKHOAN == userNV && tk.MATKHAU == passNV).FirstOrDefault();
            if (taiKhoan != null)
                return taiKhoan;
            else
                return null;
        }
    }
}
