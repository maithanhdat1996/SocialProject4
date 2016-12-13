using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using SocialFashion.Model.Models;
using SocialFashion.Service;
using SocialFashion.Data.Repositories;
using SocialFashion.Data.Infrastructure;

namespace SocialFashion.Web.Controllers
{
    public class StatusController : Controller
    {
        SocialFashionDbContext db;
        public StatusController()
        {
            db = new SocialFashionDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Add(IEnumerable<HttpPostedFileBase> FileUpload, String txtContent, int sltStatus)
        {
            if (Request.IsAuthenticated)
            {
                foreach (var file in FileUpload)
                {
                    file.SaveAs(Server.MapPath("~/Content/client/images/status/" + file.FileName));
                }
                var userId = User.Identity.GetUserId();
                AspNetUser user = db.AspNetUsers.SingleOrDefault(m => m.Id == userId);
                Status s = new Status();
                s.StatusId = sltStatus;
                s.Content = txtContent;
                s.UserId = userId;
                s.ProductId = 0;
                s.Date = DateTime.Now;
                db.Status.Add(s);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}