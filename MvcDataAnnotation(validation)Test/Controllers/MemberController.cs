using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDataAnnotation_validation_Test.Controllers
{
    public class MemberController : Controller
    {
        Models.MemberDatabaseEntities de = new Models.MemberDatabaseEntities();
        //
        // GET: /Member/

        public ActionResult Index()
        {
            var result = from m in de.MemberTables
                         select m;
            return View(result.ToList());
        }

        //
        // GET: /Member/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Member/Create

        public ActionResult Create()
        {
            Models.MemberTable m = new Models.MemberTable();
            return View(m);
        }

        //
        // POST: /Member/Create

        [HttpPost]
        public ActionResult Create(Models.MemberTable m)
        {
            try
            {
                de.MemberTables.Add(m);
                de.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Member/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Member/Edit/5

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
        // GET: /Member/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Member/Delete/5

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
