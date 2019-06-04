using Demo.Xss.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Xss.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        //[ValidateInput(false)]
        public ActionResult SaveIndexDto(Dto data)
        {
            return View("Index", data);
        }

        public ActionResult Knockout()
        {
            return View("Knockout");
        }

        //[ValidateInput(false)]
        public ActionResult SaveKnockoutDto(Dto data)
        {
            return View("Knockout", data);
        }

        public ActionResult Angular()
        {
            return View("Angular");
        }

        //[ValidateInput(false)]
        public ActionResult SaveAngularDto(Dto data)
        {
            return View("Angular", data);
        }
    }
}