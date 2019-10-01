using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLoginForm.Models;

namespace MvcLoginForm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Model objmodel)
        {
            if (objmodel.userName=="Maddineni" && objmodel.password=="Anjineyulu")
            return RedirectToAction("WelcomePage");
            else
            {
                objmodel.Message = "Invalid username/Password";
                return View(objmodel);
            }  
          }
        public ActionResult WelcomePage()
        {
            return View();
        }
    }
}