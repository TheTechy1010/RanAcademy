using RanAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RanAcademy.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BuyCourse()
        {
            ViewBag.Students = new SelectList(db.Students.ToList(), "Id", "FullName");
            ViewBag.Courses = new SelectList(db.Courses.ToList(), "Id", "Name");

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
    }
}