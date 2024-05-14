using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKS.Controllers
{
    public class BangGiaController : Controller
        //
    {
        // GET: BangGia
        QLKS.Models.dataQLKSEntities db = new Models.dataQLKSEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GiaPhong()
        {
            return View(db.tblLoaiPhongs.ToList());
        }
        public ActionResult GiaDichVu()
        {
            return View(db.tblDichVus.ToList());
        }
        public ActionResult ChiTiet(int id)
        {
            if (id.ToString() == null)
            {
                return RedirectToAction("GiaPhong");
            }
            //loai_phong
            var lp = db.tblLoaiPhongs.SingleOrDefault(x => x.loai_phong.Equals(id));
            if (lp != null)
            {
                return View(lp);
            }
            return RedirectToAction("GiaPhong");
        }
    }
}