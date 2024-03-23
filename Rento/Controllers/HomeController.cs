using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rento.Data;
using Rento.Models;

namespace Rento.Controllers
{
    public class HomeController : Controller
    {
        private RentoContext db = new RentoContext();
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
        public ActionResult Car_List()
        {
            return View(db.Cars.ToList());
        }
        public ActionResult Car_Info(int? id)
        {
            Car car = db.Cars.Find(id);
            return View(car);
        }


    }
}