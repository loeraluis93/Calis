using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebUdemy.Models;
using WebUdemy.ViewModels;
using System.Linq;
using System.Web;


namespace WebUdemy.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2" }
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(ViewModel);
            //return Content("Hello World!"); regresa un string en la pagina
            //return HttpNotFound(); ctrl shift V o B regresa un error 404 mashin
            //return new EmptyResult(); regresa una pagina en blanco
            // return RedirectToAction("Action","Controller", new{page =1, sortBy="name"});
        }
        /*
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }
}