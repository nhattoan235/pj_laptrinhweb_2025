using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NhanVienQL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string employeeId, string password)
        {
            // Giả sử kiểm tra đơn giản
            if (employeeId == "NV001" && password == "123")
            {
                // Có thể lưu thông tin đăng nhập vào Session
                Session["EmployeeId"] = employeeId;

                // Sau đó chuyển hướng sang trang dành cho nhân viên
                return RedirectToAction("Dashboard", "NhanVien");
            }
            else
            {
                // Báo lỗi nếu sai
                ViewBag.ErrorMessage = "Sai mã nhân viên hoặc mật khẩu!";
                return View();
            }
        }

        public ActionResult DangNhap()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}