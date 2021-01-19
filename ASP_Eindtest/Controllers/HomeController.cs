using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP_Eindtest.Models;
using Data.Models;
using Data.Repositories;
using ASP_Eindtest.Services;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace ASP_Eindtest.Controllers
{
    public class HomeController : Controller
    {
        private KlantService klantService;
        private VideoVerhuurContext VideoVerhuurContext_;
        public HomeController(KlantService klantService, VideoVerhuurContext context)
        {
            this.klantService = klantService;
            VideoVerhuurContext_ = context; 
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CBUserModel model)
        {
            var klant = VideoVerhuurContext_.Klanten
                                        .Where(k => k.PostCode == model.Postcode)
                                        .FirstOrDefault();
            ViewBag.klant = klant;
            var geserializeerdeklant = JsonConvert.SerializeObject(klant);
            HttpContext.Session.SetString("klant", geserializeerdeklant);
            if (klant != null && klant.Naam == model.Naam.ToUpper())
            {
                return View("Landing", klant);
            }

            return View("Landing", klant);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
