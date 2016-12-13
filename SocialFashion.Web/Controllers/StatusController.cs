using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        IDbFactory db;
        IStatusRepository repository;
        IUnitOfWork work;
        IStatusService service;
        public StatusController()
        {
            db = new DbFactory();
            repository = new StatusRepository(db);
            work = new UnitOfWork(db);
            service = new StatusService(repository, work);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(String txtContent, int sltStatus)
        {
            Status s = new Status();
            s.StatusId = sltStatus;
            s.Content = txtContent;
            s.UserId = 1;
            s.ProductId = 1;
            s.Date = new DateTime(1995, 8, 8);
            service.Add(s);
            service.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}