using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NhanVien_BLL_DAL
    {
        QL_DatVeXeDataContext db = new QL_DatVeXeDataContext();

        public NhanVien_BLL_DAL()
        {

        }

        public List<NHANVIEN> getDataNhanVien()
        {
            return db.NHANVIENs.Select(nv => nv).ToList<NHANVIEN>();
        }

        public NHANVIEN getDataOneNhanVien(int maNV)
        {
            NHANVIEN nhanVien = db.NHANVIENs.Where(nv => nv.MANV == maNV).FirstOrDefault();
            if (nhanVien != null)
                return nhanVien;
            else 
                return null;
        }

        public bool addNewNhanVien(NHANVIEN nhanVien)
        {
            var kq = from nv in db.NHANVIENs where nv.MANV == nhanVien.MANV select nv.MANV;
            if (kq.Count() > 0)
                return false;
            else
            {
                db.NHANVIENs.InsertOnSubmit(nhanVien);
                db.SubmitChanges();
                return true;
            }
        }

        public bool deleteNhanVien(int maNV)
        {
            NHANVIEN nhanVien = db.NHANVIENs.Where(nv => nv.MANV == maNV).FirstOrDefault();
            if (nhanVien != null)
            {
                db.NHANVIENs.DeleteOnSubmit(nhanVien);
                db.SubmitChanges();
                return true;
            } 
            else { return false; }  
        }

        public bool updateNhanVien(NHANVIEN uNhanVien)
        {
            NHANVIEN nhanVien = db.NHANVIENs.Where(nv => nv.MANV == uNhanVien.MANV).FirstOrDefault();
            if (nhanVien != null)
            {
                //db.NHANVIENs.SingleOrDefault(nv => nv == uNhanVien);
                nhanVien.TENNV = uNhanVien.TENNV;
                nhanVien.DIACHI = uNhanVien.DIACHI;
                nhanVien.TrangThai = uNhanVien.TrangThai;
                nhanVien.GIOITINH = uNhanVien.GIOITINH;
                nhanVien.NGAYSINH = uNhanVien.NGAYSINH;
                nhanVien.SDT = uNhanVien.SDT;

                db.SubmitChanges();
                return true;
            }
            else { return false; }
        }
    }
}
