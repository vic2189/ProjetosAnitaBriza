using PortalProjetoAmor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace PortalProjetoAmor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            EntidadesPortal ep = new EntidadesPortal(ConfigurationManager.ConnectionStrings["ProjetoAmorConnectionString"].ConnectionString);
            ep.Database.Create();
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