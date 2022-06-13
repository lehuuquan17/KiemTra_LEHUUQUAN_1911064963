using KiemTra_LEHUUQUAN_1911064963.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_LEHUUQUAN_1911064963.Controllers
{
    public class DangKyController : Controller
    {
        SinhVienDataContext data = new SinhVienDataContext();
        // GET: DangKy
        
        public ActionResult Index()
        {
            var all_sinhvien = from tt in data.HocPhans select tt;
            return View(all_sinhvien);
        }
    }
}