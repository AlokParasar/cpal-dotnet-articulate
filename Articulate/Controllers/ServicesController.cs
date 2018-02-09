using Articulate.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Articulate.Controllers
{
    public class ServicesController : Controller
    {
        HttpClient client = new HttpClient();


        /// <summary>
        /// This is to create a new Attendee item 
        /// </summary>
        /// <param name="form"></param>
        /// <returns>If this is success it will rediect to index page otherwise error page</returns>
        [HttpPost]
        public async Task<ActionResult> AddAttendee(AttendeeModel item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(App_Start.ApplicationConfig.AttendeeServiceUri);
                    client.DefaultRequestHeaders.Accept.Add(
                       new MediaTypeWithQualityHeaderValue("application/json"));
                    Console.WriteLine(client.BaseAddress);
                    var response = await client.PostAsJsonAsync("/api/Attendee", item);
                    response.EnsureSuccessStatusCode();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("Services", "Home");
        }

        [HttpGet]
        public async Task<JsonResult> GetAttendees()
        {
            var model = new List<AttendeeModel>();
            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(App_Start.ApplicationConfig.AttendeeServiceUri);
                
                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("/api/Attendee");
                if (response.IsSuccessStatusCode)
                {
                    model = await response.Content.ReadAsAsync<List<AttendeeModel>>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}