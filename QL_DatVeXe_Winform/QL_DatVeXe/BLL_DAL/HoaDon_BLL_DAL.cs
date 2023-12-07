using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HoaDon_BLL_DAL
    {
        QL_DatVeXeDataContext db = new QL_DatVeXeDataContext();
        public HoaDon_BLL_DAL()
        {

        }

        public List<HOADON> getDataHoaDon()
        {
            return db.HOADONs.Select(hd => hd).ToList<HOADON>();
        }

        public List<HOADON> getDataHoaDonStateFalse()
        {
            return db.HOADONs.Where(hd => hd.TRANGTHAI == false).ToList<HOADON>();
        }

        public HOADON getDataOneHoaDon(int maHD)
        {
            HOADON hoaDon = db.HOADONs.Where(hd => hd.MAHD == maHD).FirstOrDefault();
            if (hoaDon != null)
                return hoaDon;
            else
                return null;
        }

        public CHITIETHOADON getOneChiTietHoaDon(int maHD) 
        { 
            CHITIETHOADON chiTiet = db.CHITIETHOADONs.Where(ct => ct.MAHD == maHD).FirstOrDefault();
            if (chiTiet != null)
                return chiTiet;
            else
                return null;
        }

        public bool updateStateHoaDon(int maHD)
        {
            HOADON hoaDon = db.HOADONs.Where(hd => hd.MAHD == maHD).FirstOrDefault();
            if (hoaDon != null)
            {
                hoaDon.TRANGTHAI = true;

                db.SubmitChanges();
                return true;
            }
            else { return false; }
        }

        public bool addNewXacNhanHoaDon(XACNHANHOADON xacNhan)
        {
            var kq = from xn in db.XACNHANHOADONs where xn.MAHD == xacNhan.MAHD select xn.MAHD;
            if (kq.Count() > 0)
                return false;
            else
            {
                db.XACNHANHOADONs.InsertOnSubmit(xacNhan);
                db.SubmitChanges();
                return true;
            }
        }
    }
}
