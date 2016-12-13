using Microsoft.AspNet.Identity;
using SocialFashion.Model.Models;
using SocialFashion.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialFashion.Web.Controllers
{
    public class HomeController : Controller
    {
        SocialFashionDbContext db;
        public HomeController(IProductService productServicer)
        {
            db = new SocialFashionDbContext();
        }

        public ActionResult Index()
        {
            IEnumerable<GetAllStutusByUserId_Result> list = db.GetAllStutusByUserId(User.Identity.GetUserId()).ToList<GetAllStutusByUserId_Result>();
            return View(list);
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