using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QL_DatVeXe.Models;

namespace QL_DatVeXe.Controllers
{
    public class VeXeController : Controller
    {
        QL_DATVEXEDataContext db = new QL_DATVEXEDataContext();
        // GET: VeXe
        public ActionResult ShowAllVeXe(int? page)
        {
            var user = Session["user"] as string;
            if (string.IsNullOrEmpty(user))
                Session["user"] = string.Empty;

            int itemsPerPage = 9;
            int pageNumber = (page ?? 1);

            var listVeXe = db.VEXEs.OrderBy(t => t.TENVE).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            ViewBag.TotalPages = Math.Ceiling((double)db.VEXEs.Count() / itemsPerPage);
            ViewBag.CurrentPage = pageNumber;
            return View(listVeXe);
        }

        public ActionResult TimVe(int? page, string diemdon, string diemden, DateTime? ngaydi, DateTime? ngayve)
        {
            var listVeXe = new List<VEXE>();
            var user = Session["user"] as string;
            if (string.IsNullOrEmpty(user))
                Session["user"] = string.Empty;

            int itemsPerPage = 9;
            int pageNumber = (page ?? 1);

            if (diemdon == null && diemden == null && ngaydi == null && ngayve == null)
                listVeXe = db.VEXEs.OrderBy(t => t.TENVE).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();

            else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
            {
                listVeXe = db.VEXEs.OrderBy(t => t.TENVE).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDON == diemdon && t.DIEMDEN == diemden && t.NGAYDI == ngaydi && t.NGAYVE == ngayve).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDON == diemdon && t.DIEMDEN == diemden && t.NGAYDI == ngaydi).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDON == diemdon && t.DIEMDEN == diemden).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDEN == diemden).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDON == diemdon).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
            {
                listVeXe = db.VEXEs.Where(t => t.NGAYDI == ngaydi).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve != null)
            {
                listVeXe = db.VEXEs.Where(t => t.NGAYVE == ngayve).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
            {
                listVeXe = db.VEXEs.Where(t => t.NGAYDI == ngaydi && t.NGAYVE == ngayve).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDON == diemdon && t.NGAYDI == ngaydi && t.NGAYVE == ngayve).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDON == diemdon && t.NGAYDI == ngaydi).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDEN == diemden && t.NGAYDI == ngaydi && t.NGAYVE == ngayve).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
            {
                listVeXe = db.VEXEs.Where(t => t.DIEMDEN == diemden && t.NGAYDI == ngaydi).Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            }
            if (listVeXe.Count == 0)
            {
                if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
                    Session["TB"] = "Bạn chưa chọn mục tiêu để tìm kiếm";
                else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
                    Session["TB"] = "Không có vé xe đi từ " + diemdon + " đến " + diemden + " ngày " + ngaydi + " - " + ngayve;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
                    Session["TB"] = "Không có vé xe đi từ " + diemdon + " đến " + diemden + " ngày " + ngaydi;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
                    Session["TB"] = "Không có vé xe đi từ " + diemdon + " đến " + diemden;
                else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
                    Session["TB"] = "Không có vé xe đến " + diemden;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
                    Session["TB"] = "Không có vé xe đi từ " + diemdon;
                else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
                    Session["TB"] = "Không có vé xe đi từ ngày " + ngaydi;
                else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve != null)
                    Session["TB"] = "Không có vé xe đi về ngày " + ngayve;
                else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
                    Session["TB"] = "Không có vé xe đi từ ngày " + ngaydi + " - " + ngayve;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
                    Session["TB"] = "Không có vé xe đi từ " + diemdon + " ngày " + ngaydi + " - " + ngayve;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
                    Session["TB"] = "Không có vé xe đi từ " + diemdon + " ngày " + ngaydi;
                else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
                    Session["TB"] = "Không có vé xe đến " + diemden + " ngày " + ngaydi + " - " + ngayve;
                else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
                    Session["TB"] = "Không có vé xe đến " + diemden + " ngày " + ngaydi;
            }
            else
            {
                if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
                    Session["TB"] = "Bạn chưa chọn mục tiêu để tìm kiếm";
                else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
                    Session["TB"] = "Bạn đang tìm vé xe đi từ " + diemdon + " đến " + diemden + " ngày " + ngaydi + " - " + ngayve;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
                    Session["TB"] = "Bạn đang tìm vé xe đi từ " + diemdon + " đến " + diemden + " ngày " + ngaydi;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
                    Session["TB"] = "Bạn đang tìm vé xe đi từ " + diemdon + " đến " + diemden;
                else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
                    Session["TB"] = "Bạn đang tìm vé xe đến " + diemden;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve == null)
                    Session["TB"] = "Bạn đang tìm vé xe đi từ " + diemdon;
                else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
                    Session["TB"] = "Bạn đang tìm vé xe đi từ ngày " + ngaydi;
                else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi == null && ngayve != null)
                    Session["TB"] = "Bạn đang tìm vé xe đi về ngày " + ngayve;
                else if (diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
                    Session["TB"] = "Bạn đang tìm vé xe đi từ ngày " + ngaydi + " - " + ngayve;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
                    Session["TB"] = "Bạn đang tìm vé xe đi từ " + diemdon + " ngày " + ngaydi + " - " + ngayve;
                else if (!diemdon.Equals("Chọn nơi xuất phát") && diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
                    Session["TB"] = "Bạn đang tìm vé xe đi từ " + diemdon + " ngày " + ngaydi;
                else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve != null)
                    Session["TB"] = "Bạn đang tìm vé xe đến " + diemden + " ngày " + ngaydi + " - " + ngayve;
                else if (diemdon.Equals("Chọn nơi xuất phát") && !diemden.Equals("Chọn nơi đến") && ngaydi != null && ngayve == null)
                    Session["TB"] = "Bạn đang tìm vé xe đến " + diemden + " ngày " + ngaydi;
            }
            ViewBag.TotalPages = Math.Ceiling((double)listVeXe.Count() / itemsPerPage);
            ViewBag.CurrentPage = pageNumber;
            return View(listVeXe);
        }
    }
}