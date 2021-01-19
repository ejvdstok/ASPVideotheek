using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Eindtest.Services;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ASP_Eindtest.Controllers
{
    public class VerhuringenController : Controller
    {
        private GenreService genreService;
        private VideoVerhuurContext videoVerhuurContext;
        private WinkelmandService winkelmandService;
        private FilmService filmService;
        public VerhuringenController(GenreService genreService,VideoVerhuurContext videoVerhuurContext, WinkelmandService winkelmandService,FilmService filmService )
        {
            this.genreService = genreService;
            this.videoVerhuurContext = videoVerhuurContext;
            this.winkelmandService = winkelmandService;
            this.filmService = filmService;
        }
        public IActionResult Index()
        {
            var klant = HttpContext.Session.GetString("klant");
            if (string.IsNullOrEmpty(klant))
            {
                ViewBag.klant = "geen"; 
 }
            else
            {
                ViewBag.klant =
                JsonConvert.DeserializeObject<Klant>(klant); 
            }
            return View(genreService.GetAllGenres());
        }
        public async Task<IActionResult> Details(int? id)
        {
            var klant = HttpContext.Session.GetString("klant");
            if (string.IsNullOrEmpty(klant))
            {
                ViewBag.klant = "geen";
            }
            else
            {
                ViewBag.klant =
                JsonConvert.DeserializeObject<Klant>(klant);
            }

            if (id == null)
            {
                return NotFound();
            }

            var genre = await videoVerhuurContext.Genres
                .Include(g => g.Films)
                .FirstOrDefaultAsync(m => m.GenreId == id);
            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }
        public IActionResult Huren(int id)
        {
            var film = filmService.GetFilmById(id);
            winkelmandService.Add(film);
            return RedirectToAction("Mandje");          
        }
        public IActionResult Verwijderen(int id)
        {
            var film = filmService.GetFilmById(id);
            if (film == null)
            {
                return NotFound();
            }
            return View(film);
        }

        [HttpPost, ActionName("Verwijderen")]
        [ValidateAntiForgeryToken]
        public IActionResult VerwijderenConfirmed(int id)
        {
            winkelmandService.Delete(id);
            return RedirectToAction(nameof(Mandje));
        }
        public IActionResult Mandje()
        {
            return View(winkelmandService.FindAll());
        }

        public IActionResult Afrekenen()
        {
            var klant = HttpContext.Session.GetString("klant");
            if (string.IsNullOrEmpty(klant))
            {
                ViewBag.klant = "geen";
            }
            else
            {
                ViewBag.klant =
                JsonConvert.DeserializeObject<Klant>(klant);
            }
            decimal totaal = 0;
            foreach(var film in winkelmandService.FindAll())
            {
                totaal += film.Prijs;
            }
            ViewBag.totaal =  totaal;
            return View(winkelmandService.FindAll());
        }
    }
}
