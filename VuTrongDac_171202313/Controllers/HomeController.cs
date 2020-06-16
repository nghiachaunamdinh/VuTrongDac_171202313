using sanphamDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VuTrongDac_171202313.Controllers
{
    public class HomeController : Controller
    {
        sanpham db = new sanpham();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult menu()
        {
            return PartialView(db.SANVANDONGs.ToList());
        }
        public ActionResult Loai(string ma)
        {
            
            var sanpham = (from s in db.SANVANDONGs where s.SanVanDongID == ma select s).ToList();
            ViewBag.sanpham = sanpham;
            return View(sanpham);
        }
        public ActionResult matrandau(string ma)
        {
            var trandau= (from s in db.TRANDAUs where s.SanVanDongID == ma select s).ToList();
            return View(trandau);
        }
        public ActionResult doidau(string ma,string ma2)
        {
            CAULACBO c = db.CAULACBOes.SingleOrDefault(x => x.CauLacBoID == ma);
            ViewBag.clb1 = c;
            CAULACBO b= db.CAULACBOes.SingleOrDefault(x => x.CauLacBoID == ma2);
            ViewBag.clb2 = b;
            return View();
        }
        public ActionResult danhsachcauthu(string ma,string hlv)
        {
            HUANLUYENVIEN h= db.HUANLUYENVIENs.SingleOrDefault(x => x.HuanLuyenVienID == hlv);
            ViewBag.hlv = h;
            CAULACBO c = db.CAULACBOes.SingleOrDefault(x => x.CauLacBoID == ma);
            ViewBag.name = c.TenCLB;
            var dscauthu = (from s in db.CAUTHUs where s.CauLacBoID == ma select s).ToList();
            return View(dscauthu);
        }
        public ActionResult thongtin(string ma)
        {
            CAUTHU ct = db.CAUTHUs.SingleOrDefault(x => x.CauThuID == ma);
            ViewBag.cauthu = ct;
            return View();
        }
    }
}