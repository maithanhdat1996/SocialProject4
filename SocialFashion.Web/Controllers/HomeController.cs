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
        IProductService _productService;
        
        public HomeController(IProductService productServicer)
        {
            this._productService = productServicer;

        }

         
        public ActionResult Index()
        {
            if(Request.IsAuthenticated)
            {
                var userId = User.Identity.GetUserId();
                using (SocialFashionDbContext db = new SocialFashionDbContext())
                {
                    AspNetUser user = db.AspNetUsers.SingleOrDefault(m => m.Id == userId);
                }
                   
               

            }
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