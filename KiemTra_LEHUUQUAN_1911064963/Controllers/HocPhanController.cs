using KiemTra_LEHUUQUAN_1911064963.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_LEHUUQUAN_1911064963.Controllers
{
    public class HocPhanController : Controller
    {
        SinhVienDataContext data = new SinhVienDataContext();
        // GET: HocPhan
        public ActionResult Index()
        {
            var all_sinhvien = from tt in data.HocPhans select tt;
            
            return View(all_sinhvien);
          
        }
        public List<HocPhan> Laygiohang()
        {
            List<HocPhan> lstGiohang = Session["HocPhan"] as List<HocPhan>;
            if (lstGiohang == null)
            {
                lstGiohang = new List<HocPhan>();
                Session["HocPhan"] = lstGiohang;
            }
            return lstGiohang;
        }
        public ActionResult ThemGioHang(String id, string strURL)
        {
            List<HocPhan> lstGiohang = Laygiohang();
            HocPhan sanpham = lstGiohang.Find(n => n.MaHP == id);
            if (sanpham == null)
            {
                sanpham = new (id);
                lstGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoluong++;
                return Redirect(strURL);
            }
        }
    }

}