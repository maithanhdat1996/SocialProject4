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
            var userId = User.Identity.GetUserId();
            if (Request.IsAuthenticated)
            {
                String strImage = "";
                foreach (var file in FileUpload)
                {
                    if (file != null)
                    {
                        String strFileName = userId.Substring(0, 8) + DateTime.Now.ToString("yyyymmddMMss") + file.FileName;
                        strFileName.Replace('|', '@');
                        file.SaveAs(Server.MapPath("~/Content/client/images/status/" + strFileName));
                        strImage += strFileName + "|";
                    }
                }
                Status s = new Status();
                s.Privacy = (byte)sltStatus;
                s.Content = txtContent;
                s.UserId = userId;
                s.MoreImages = strImage;
                s.ProductId = 0;
                s.Date = DateTime.Now;
                db.Status.Add(s);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}