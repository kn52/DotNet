using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactDemo.Models;
using ReactDemo.Models.Infc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReactDemo.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
       public EmployeeController(IEmployeeBusinessLayer employeeBusinessLayer)
        {
            this.EmployeeBusinessLayer = employeeBusinessLayer;
        }
        public IEmployeeBusinessLayer EmployeeBusinessLayer { get; set; }

        // GET: Employee
        [HttpGet("[action]")]
        public IEnumerable<Employee> GetEmployees()
        {
            var rd = EmployeeBusinessLayer.GetAllEmployees();
            return rd;
        }

        //// GET: Employee/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Employee/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Employee/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Employee/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Employee/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Employee/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Employee/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}