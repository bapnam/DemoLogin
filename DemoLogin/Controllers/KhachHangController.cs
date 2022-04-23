using DemoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoLogin.Controllers
{
    public class KhachHangController : Controller
    {
        Model1 db = new Model1();
        // GET: KhachHang
        public ActionResult Index()
        {
            var list = db.KhachHangs;
            return View(list);
        }
    }
}