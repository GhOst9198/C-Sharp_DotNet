using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Web.Mvc;
using TheReaLState.Models;
using TheReaLState.Manager;

namespace TheReaLState.Controllers
{
    public class BuyController : Controller
    {
        // GET: Buy
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Homes()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Homes(BuyModel Buy)
        {
            if (ModelState.IsValid)
            {
                BuyManager obj = new BuyManager();
                int a = obj.Homes(Buy);
                return RedirectToAction("ViewBuy", "Buy");
            }
            
            else
            {
                ViewBag.Message = "ChooSe FiLters properLy";
                return View();
            }
        }
        public ActionResult Plots()
        {
            return View();
        }
        public ActionResult Commercial()
        {
            return View();
        }
        public ActionResult ViewBuy()
        {
            BuyManager Obj = new BuyManager();
            List<BuyModel> BM = Obj.SelectBuy();
            if (BM != null)
            {
                return View(BM);
            }
            else
            {
                ViewBag.message = "Sorry nO results of your Search";
                return View();
            }
            
        }
    }
}