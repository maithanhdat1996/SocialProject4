using Newtonsoft.Json;
using SocialFashion.Data.Infrastructure;
using SocialFashion.Data.Repositories;
using SocialFashion.Model.Models;
using SocialFashion.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SocialFashion.Web.Controllers
{
    public class HomeController : Controller
    {
        IDbFactory db;
        IStatusRepository repository;
        IUnitOfWork work;
        IStatusService serviceStatus;
        public HomeController()
        {
            db = new DbFactory();
            repository = new StatusRepository(db);
            work = new UnitOfWork(db);
            serviceStatus = new StatusService(repository, work);
        }
        public ActionResult Index()
        {
            IEnumerable<Status> listStatus = serviceStatus.GetAll();
            return View(listStatus);
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