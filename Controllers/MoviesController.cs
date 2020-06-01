using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly3.Controllers
{
    public class MoviesController : Controller
    {
    // GET: Random
    public ActionResult Random()
    {
      return View();
      //return Content("Hellow Hallow");
      //return HttpNotFound();
      //return new EmptyResult();
      return RedirectToAction("Index", "Home", new {page=1, sortby="name"});
    }
    // GET: Movies
    public ActionResult Index(int? pageIndex, string sortBy)
    {
      if (!pageIndex.HasValue)
        pageIndex = 1;

      if (String.IsNullOrWhiteSpace(sortBy))
        sortBy = "Free Range Chickens";

      return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
    }

    public ActionResult ByReleaseDate(int year, int month)
    {
      return Content(year + "/" + month);
    }


    // GET: Movies/Details/5
    public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
      return Content("id=" + id);
        }



    // POST: Movies/Edit/5
    [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movies/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
