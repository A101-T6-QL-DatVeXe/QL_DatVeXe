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
        public ActionResult ShowAllVeXe (int? page)
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
    }
}