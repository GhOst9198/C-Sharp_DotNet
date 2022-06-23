using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheReaLState.Models;
using TheReaLState.Manager;

namespace TheReaLState.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SignInModel Login)
        {
            SignInManager Obj = new SignInManager();
            int a = Obj.SignIn(Login);
            if (a == 1)
            {
                Session["IsLogedIn"] = true;
                return RedirectToAction("Homes", "AddProperty");
            }
            else
            {
                ViewBag.Message = "Username Or Password is inCoreect";
                return View();
            }
        }
        public ActionResult Logout()
        {
            Session["IsLogedIn"] = null;
            return RedirectToAction("Homes","Buy");
        }
        public ActionResult Login(SignInModel Login)
        {
            SignInManager Obj = new SignInManager();
            int a = Obj.SignIn(Login);
            if (a == 1)
            {
                Session["IsLogedIn"] = true;
                return RedirectToAction("Homes", "AddProperty");
            }
            else
            {
                ViewBag.Message = "Username Or Password is inCoreect";
                return RedirectToAction("Homes", "Buy");
            }
        }
        public ActionResult CreateAccount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAccount(SignInModel Login)
        {
            return View();
        }
    }
}