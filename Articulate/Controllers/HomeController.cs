using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Articulate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.applicationName = App_Start.ApplicationConfig.ApplicationName;
            ViewBag.instanceIndex = App_Start.ApplicationConfig.InstanceIndex;
            ViewBag.containerAddress = App_Start.ApplicationConfig.ContainerAddress;
            ViewBag.cellAddress = App_Start.ApplicationConfig.CellAddress;
            ViewBag.dotNetVersion = App_Start.ApplicationConfig.DotNetVersion;
            Console.WriteLine("*** Render Index View ***");
            return View();
        }

        public ActionResult Basics(string kill)
        {
            if (kill == "true")
            {
                Console.Error.WriteLine("*** The Instance with {0} is shutting down. ***", App_Start.ApplicationConfig.InstanceGUID);
                
                Environment.Exit(-1);
            }
            //ViewBag.Message = "Your application Services page.";
            ViewBag.applicationName = App_Start.ApplicationConfig.ApplicationName;
            ViewBag.instanceIndex = App_Start.ApplicationConfig.InstanceIndex;
            ViewBag.containerAddress = App_Start.ApplicationConfig.ContainerAddress;
            ViewBag.cellAddress = App_Start.ApplicationConfig.CellAddress;
            ViewBag.dotNetVersion = App_Start.ApplicationConfig.DotNetVersion;
            Console.WriteLine("*** Render Basics View ***");
            return View();
        }
        
        public ActionResult Services()
        {
            //ViewBag.Message = "Your application Services page.";
            ViewBag.applicationName = App_Start.ApplicationConfig.ApplicationName;
            ViewBag.instanceIndex = App_Start.ApplicationConfig.InstanceIndex;
            ViewBag.containerAddress = App_Start.ApplicationConfig.ContainerAddress;
            ViewBag.cellAddress = App_Start.ApplicationConfig.CellAddress;
            ViewBag.dotNetVersion = App_Start.ApplicationConfig.DotNetVersion;
            Console.WriteLine("*** Render Services View ***");
            return View();
        }

        public ActionResult Bluegreen()
        {
            ViewBag.Message = "Your Blue-Green page.";
            Console.WriteLine("*** Render Blue/Green View ***");
            return View("Bluegreen");
        }
        public ContentResult BluegreenCheck()
        {
            return Content(App_Start.ApplicationConfig.ApplicationName);
        }

    }
}