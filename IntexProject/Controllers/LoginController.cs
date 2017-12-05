using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IntexProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        //POST

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(email, "greg@test.com") && (string.Equals(password, "greg")))
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View();
            }
        }
    }
}