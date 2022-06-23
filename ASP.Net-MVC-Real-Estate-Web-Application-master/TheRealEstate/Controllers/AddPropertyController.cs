using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheReaLState.Models;
using System.IO;
using System.ComponentModel;
using TheReaLState.Manager;

namespace TheReaLState.Controllers
{
    [Filter.Authorization]
    public class AddPropertyController : Controller
    {
        // GET: AddProperty
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Homes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Homes(AddPropertyModel APModel)
        {
            /*using (TempProjectEntities DB = new TempProjectEntities())
            {
                DB.ProductTables.Add(Product);
                DB.SaveChanges();
            }*/
                string FileName = Path.GetFileNameWithoutExtension(APModel.ProductImage.FileName);
                string Extension = Path.GetExtension(APModel.ProductImage.FileName);
                FileName = FileName + DateTime.Now.ToString("yymmssfff") + Extension;
                APModel.ImageUrl = FileName;
                FileName = Path.Combine(Server.MapPath("~/Content/LogoImages/"), FileName);
                APModel.ProductImage.SaveAs(FileName);

                AddPropertyManager obj = new AddPropertyManager();
                int a = obj.Homes(APModel);
                if (a!=0)
                {
                    ViewBag.Message = "Property Entered Succesfully";
                }
                else
                {
                    ViewBag.Message = "Property Not Entered Succesfully";
                }
            return View();
        }
        public ActionResult Plots()
        {
            return View();
        }
        public ActionResult Commercial()
        {
            return View();
        }
    }
}