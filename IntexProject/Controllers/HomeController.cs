using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IntexProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        //POST

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String userName = form["User Name"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(userName, "customer") && (string.Equals(password, "intex")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);
                Session["userName"] = "admin";
                return RedirectToAction("Index", "Home");

            }
            else if (string.Equals(userName, "employee") && (string.Equals(password, "intex")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);
                Session["userName"] = "user";
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            
            return View();
        }

        public ActionResult LogoutConfirmed()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }


        [Authorize]
        public ActionResult Catalog()
        {
            return View();
        }
    }

}
