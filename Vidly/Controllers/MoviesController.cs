using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageNumber, string sortBy)
        {
            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            //return RedirectToAction("Index", "Home", new { pageNumber = 10, sortBy = "Fun" });
            //return HttpNotFound();
            return Content("pageNumber: "+pageNumber+"sortBy: "+sortBy);
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Shrek"};
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = "+ id);
        }
    }
}