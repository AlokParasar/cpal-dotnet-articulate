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
            ViewBag.userProvidedService = App_Start.ApplicationConfig.UserProvidedService;
            System.Diagnostics.Trace.TraceWarning("Warn*** Render Index View ***");
            System.Diagnostics.Trace.TraceInformation("TraceInformation");
            System.Diagnostics.Trace.TraceError("TraceError");

            return View();
        }

        public ActionResult Basics()
        {
            //ViewBag.Message = "Your application Services page.";
            ViewBag.applicationName = App_Start.ApplicationConfig.ApplicationName;
            ViewBag.instanceIndex = App_Start.ApplicationConfig.InstanceIndex;
            ViewBag.containerAddress = App_Start.ApplicationConfig.ContainerAddress;
            ViewBag.cellAddress = App_Start.ApplicationConfig.CellAddress;
            ViewBag.dotNetVersion = App_Start.ApplicationConfig.DotNetVersion;
            ViewBag.userProvidedService = App_Start.ApplicationConfig.UserProvidedService;
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
            ViewBag.userProvidedService = App_Start.ApplicationConfig.UserProvidedService;
            Console.WriteLine("*** Render Services View ***");
            return View();
        }

        public ActionResult Bluegreen()
        {
            ViewBag.Message = "Your Blue-Green page.";
            ViewBag.applicationName = App_Start.ApplicationConfig.ApplicationName;
            ViewBag.instanceIndex = App_Start.ApplicationConfig.InstanceIndex;
            ViewBag.containerAddress = App_Start.ApplicationConfig.ContainerAddress;
            ViewBag.cellAddress = App_Start.ApplicationConfig.CellAddress;
            ViewBag.dotNetVersion = App_Start.ApplicationConfig.DotNetVersion;
            ViewBag.userProvidedService = App_Start.ApplicationConfig.UserProvidedService;
            Console.WriteLine("*** Render Blue/Green View ***");
            return View("Bluegreen");
        }
        public ContentResult BluegreenCheck()
        {
            return Content(App_Start.ApplicationConfig.ApplicationName);
        }

        [HttpGet]
        public void Kill(string kill)
        {
            if (kill == "true")
            {
                Console.Error.WriteLine("*** The Instance with {0} is shutting down. ***", App_Start.ApplicationConfig.InstanceGUID);

                Environment.Exit(-1);
            }

        }
    }
}