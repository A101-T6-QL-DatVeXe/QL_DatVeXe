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

        public HOADON getDataOneHoaDon(int maHD)
        {
            HOADON hoaDon = db.HOADONs.Where(hd => hd.MAHD == maHD).FirstOrDefault();
            if (hoaDon != null)
                return hoaDon;
            else
                return null;
        }


    }
}
