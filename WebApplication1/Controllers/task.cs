﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Design;

namespace WebApplication1.Controllers
{
    public class task : Controller
    {
        // GET: task
        public ActionResult Index()
        {

            Response.Write("kl;k;lk;k;lk;lk;l");


            return View();



        }

        // GET: task/Details/5
        public ActionResult Details(int id)
        {


            return View();
        }

        // GET: task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: task/Create
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

        // GET: task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: task/Edit/5
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

        // GET: task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: task/Delete/5
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
        [HttpGet]
        public ActionResult Fillform(string email)
        {


            return View();
        }

    }


}

