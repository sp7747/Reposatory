using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCrepo.Repository;
using MVCrepo.Models;
namespace MVCrepo.Controllers
{
    public class EmpController : Controller
    {
       



        private IEmployee Iemp; 

        public EmpController()
        {

            this.Iemp = new EmployeeRepository(new EmployeeDBEntities());

        }





        //
        // GET: /Emp/

        public ActionResult Index()
        {
            var list = Iemp.GetEmployees().ToList();
            return View(list);
        }

        //
        // GET: /Emp/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Emp/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Emp/Create

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

        //
        // GET: /Emp/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Emp/Edit/5

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

        //
        // GET: /Emp/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Emp/Delete/5

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
