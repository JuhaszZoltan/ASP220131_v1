using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP220131_v1.Models;

namespace ASP220131_v1.Controllers
{
    public class FilmekController : Controller
    {
        static Random rnd = new Random();
        static List<Film> filmek = new List<Film>()
        {
            new Film()
            {
                Id = 1,
                Cim = "Coco",
                Megjelenes = new DateTime(2017, 10, 27),
            },
            new Film()
            {
                Id = 2,
                Cim = "Érkezés",
                Megjelenes = new DateTime(2016, 09, 01),
            },
        };

        // GET: Filmek/Random
        public ActionResult Random()
        {
            var film = new Film()
            {
                Id = 20,
                Cim = "Matrix",
                Megjelenes = new DateTime(1999, 12, 07),
            };
            var kolcsonzok = new List<Ugyfel>()
            {
                new Ugyfel() { ID = 1, Nev = "Géza" },
                new Ugyfel() { ID = 2, Nev = "Lenke" },
                new Ugyfel() { ID = 3, Nev = "Béla" },
                new Ugyfel() { ID = 4, Nev = "Zoli" },
                new Ugyfel() { ID = 5, Nev = "Jakab" },
            };

            var viewModel = new RandomFilmViewModel()
            {
                Film = film,
                Kolcsonzok = kolcsonzok,
            };

            return View(viewModel);
        }

        //GET: Filmek/Szerkesztes/Id
        //GET: Filmek/Szekesztes/1 -> 

        public ActionResult Szerkesztes(int filmId)
        {
            return Content($"{filmek[filmId].Cim} ({filmek[filmId].Megjelenes.Year})");
        }

        [Route("Filmek/Megjelenes/{ev:regex(\\d{4}):range(1990, 2022)}/{honap:regex(\\d{2}):range(1, 12)}")]
        public ActionResult Megjelenes(int ev, int honap)
        {
            return Content($"{ev} - {honap}");
        }
    }
}