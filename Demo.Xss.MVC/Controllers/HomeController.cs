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

        public ActionResult Index(int id = 0)
        {
            Dto data = new Dto();
            var temp = Session["data"];
            if(temp != null)
            {
                this.Session.Add("data", null);
                try
                {
                    data = (Dto)temp;
                }
                catch
                {
                    data = new Dto();
                };
            }
            return View("Index", data);
        }

        [ValidateInput(false)]
        public ActionResult SaveIndexDto(Dto data)
        {
            //data.Name = Server.HtmlEncode(data.Name);
            //data.Description = Server.HtmlEncode(data.Description);
            this.Session.Add("data", data);
            //data.Name = Server.HtmlDecode(data.Name);
            //data.Description = Server.HtmlDecode(data.Description);
            return RedirectToAction("Index", "Home", new { id = 1});
            //return View("Index", data);
        }

        //public ActionResult Knockout()
        //{
        //    return View("Knockout");
        //}

        ////[ValidateInput(false)]
        //public ActionResult SaveKnockoutDto(Dto data)
        //{
        //    return View("Knockout", data);
        //}

        //public ActionResult Angular()
        //{
        //    return View("Angular");
        //}

        ////[ValidateInput(false)]
        //public ActionResult SaveAngularDto(Dto data)
        //{
        //    return View("Angular", data);
        //}
    }
}