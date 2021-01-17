using StudentMgmt.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StudentMgmt.Controllers
{
    [RoutePrefix("Student")]
    public class StudentController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<string> Stud = new StudentBusinessLayer().GetDepartment();
            ViewBag.Header = "Department List";
            return View("Index",Stud);
        }

        public ActionResult Department(string department)
        {
            List<Student> Stud = new StudentBusinessLayer().GetStudent(department);
            ViewBag.Header = "Student List";
            return View("Department",Stud);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Header = "Student Details";
            Student student = new StudentBusinessLayer().GetStudentById(id);
            return View("StudentDetails", student);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
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

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
