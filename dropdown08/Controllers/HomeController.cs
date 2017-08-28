using dropdown08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dropdown08.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext context = new EmployeeContext();
        // GET: Home
        public ActionResult FillCity(int state)
        {
            var cities = context.Citys.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.StateList = context.States;
            var model = new Employee();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(model);
                context.SaveChanges();
                // code to save record  and redirect to listing page
            }
            ViewBag.StateList = context.States;
            return View(model);
        }
    }

}