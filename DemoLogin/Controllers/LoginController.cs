using DemoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        Model1 db = new Model1();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(KhachHang user)
        {
            var r = db.KhachHangs.Where(u => u.NameLogin == user.NameLogin && u.Password == user.Password);

            if (r.Count() > 0)
            {
                return RedirectToAction("Index", "KhachHang");

            }
            ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            return View("Index");
        }

    }
}