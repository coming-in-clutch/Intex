using IntexProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using IntexProject.Models;
using System.ComponentModel;

namespace IntexProject.Controllers
{
    public class HomeController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
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
                Session["userName"] = "Customer";

                return RedirectToAction("Orders", "Home");

            }
            else if (string.Equals(userName, "employee") && (string.Equals(password, "intex")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);
                Session["userName"] = "Employee";

                return RedirectToAction("Index", "Home");

            }
            else if (string.Equals(userName, "manager") && (string.Equals(password, "intex")))
            {
                FormsAuthentication.SetAuthCookie(userName, rememberMe);
                Session["userName"] = "Manager";
                return RedirectToAction("Manager", "Home");

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

        //public void LoginLink_OnClick(object sender, EventArgs args)
        //{
        //    FormsAuthentication.SignOut();
        //    FormsAuthentication.RedirectToLoginPage();
        //}

        //[Authorize]
        public ActionResult Catalog()
        {

            IEnumerable<Catalog> catalog = db.Database.SqlQuery<Catalog>("SELECT  Assay.assayID," +
                "assayName, " +
                "Test.testID, " +
                "test.testName, " +
                "material.materialID, " +
                "material.materialName " +
                "FROM Assay " +
                "   LEFT JOIN Assay_Test ON Assay_Test.assayID = Assay.assayID " +
                "   INNER JOIN Test ON Test.testID = Assay_Test.testID " +
                "   INNER JOIN Material_Test MT ON MT.testID = Test.testID " +
                "   INNER JOIN Material ON Material.materialID = MT.materialID " +
                "ORDER BY ASSAY.assayID, assayName ");
            return View(catalog);
        }

        [HttpGet]
        public ActionResult WorkOrder()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WorkOrder([Bind(Include = "workOrderID,assayName,numberSamples,apperance,dateDue")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                db.WorkOrders.Add(workOrder);

                //commites new workOrder to database
                db.SaveChanges();


                return RedirectToAction("Confirmation");

            }

            return View(workOrder);
        }

        [Authorize]
        public ActionResult Manager()
        {
            return View();
        }

        [Authorize]
        public ActionResult Employee()
        {
            return View();
        }

        public ActionResult Confirmation()
        {
            return View();
        }

        [Authorize]
        public ActionResult Orders()
        {
            IEnumerable<Orders> orders = db.Database.SqlQuery<Orders>("SELECT workOrderID, " +
                "numberSamples, " +
                "dateArrived, " +
                "dateDue, " +
                "apperance " +
                "FROM Work_Order; ");
            return View(orders);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewCustomer([Bind(Include = "customerID,custAddress,custPhone,custCity,custState,custZip,custEmail")] NewCustomer newcustomer)
        {
            if (ModelState.IsValid)
            {
                db.NewCustomers.Add(newcustomer);

                //commites new workOrder to database
                db.SaveChanges();


                return RedirectToAction("Confirmation");

            }

            return View(newcustomer);
        }


    }

}
