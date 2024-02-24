using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace WebApplication1.Controllers

{
   

    public class Home : Controller
    {
        // GET: baserel
        public ActionResult Index()
        {


            return View();

        }

        // GET: baserel/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: baserel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: baserel/Create
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

        // GET: baserel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: baserel/Edit/5
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

        // GET: baserel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        protected internal string Hello()
        {
            return "Hello ASP.NET";
        }

        // POST: baserel/Delete/5
        [HttpGet]
        public ActionResult getdat()
        {
            try
            {
               

               





                return View();



            }
            catch
            {
                return View();
            }
        }
    }

   




}

