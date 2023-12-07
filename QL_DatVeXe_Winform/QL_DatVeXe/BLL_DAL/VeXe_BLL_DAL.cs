using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class VeXe_BLL_DAL
    {
        QL_DatVeXeDataContext db = new QL_DatVeXeDataContext();

        public VeXe_BLL_DAL()
        {

        }

        public List<VEXE> getDataVeXe()
        {
            return db.VEXEs.Select(vx => vx).ToList<VEXE>();
        }

        public bool addNewVeXe(VEXE veXe)
        {
            var kq = from vx in db.VEXEs where vx.MAVE == veXe.MAVE select vx.MAVE;
            if (kq.Count() > 0)
                return false;
            else
            {
                db.VEXEs.InsertOnSubmit(veXe);
                db.SubmitChanges();
                return true;
            }
        }

        public bool deleteVeXe(int maVeXe)
        {
            VEXE veXe = db.VEXEs.Where(vx => vx.MAVE == maVeXe).FirstOrDefault();
            if (veXe != null)
            {
                db.VEXEs.DeleteOnSubmit(veXe);
                db.SubmitChanges();
                return true;
            }
            else { return false; }
        }

        public bool updateVeXe(VEXE uVeXe)
        {
            VEXE veXe = db.VEXEs.Where(vx => vx.MAVE == uVeXe.MAVE).FirstOrDefault();
            if (veXe != null)
            {
                veXe.TENVE = uVeXe.TENVE;
                veXe.GIAVE = uVeXe.GIAVE;
                veXe.CONTRONG = uVeXe.CONTRONG;
                veXe.DIEMDEN = uVeXe.DIEMDEN;
                veXe.DIEMDON = uVeXe.DIEMDON;
                veXe.NGAYDI = uVeXe.NGAYDI;
                veXe.NGAYVE = uVeXe.NGAYVE;
                veXe.THOIGIANDON = uVeXe.THOIGIANDON;
                veXe.SOSAO = uVeXe.SOSAO;
                veXe.LUOTDANHGIA = uVeXe.LUOTDANHGIA;
                veXe.MOTA = uVeXe.MOTA;

                db.SubmitChanges();
                return true;
            }
            else { return false; }
        }
    }
}
