using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RezorViewEngineTestOrhtmHelperMethodTest.Controllers
{
    public class StudentController : Controller
    {
        Models.StudentDataClassDataContext de = new Models.StudentDataClassDataContext();
        //
        // GET: /Student/

        [HttpPost]
        public ActionResult SearchStudent(FormCollection frm)
        {
            var result = from s in de.StudentTables
                         where s.studentID == frm[0].ToString()
                         select s;
            foreach (var r in result)
            {
                ViewBag.studentID = r.studentID;
                ViewBag.studentName = r.studentName;
                ViewBag.studentAddress = r.studentAddress;
            }
            return View();
        }
        public ActionResult SearchStudent()
        {
            return View();
        }
        public ActionResult ForBanner()
        {
            return View();
        }

        public ActionResult Index()
        {
            var result = from s in de.StudentTables
                         select s;
            return View(result.ToList());
        }

        //
        // GET: /Student/Details/5

        public ActionResult Details(string id)
        {
            var result = from s in de.StudentTables
                         where s.studentID == id
                         select s;
            Models.StudentTable st = new Models.StudentTable();
            foreach (var r in result)
            {
                st = r;
            }
            return View(st);
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {
            Models.StudentTable st = new Models.StudentTable();
            return View(st);
        }

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(Models.StudentTable st)
        {
            try
            {
                de.StudentTables.InsertOnSubmit(st);
                de.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.msg = "Please change the student ID...";
                return View();
            }
        }

        //
        // GET: /Student/Edit/5

        public ActionResult Edit(string id)
        {
            var result = from s in de.StudentTables
                         where s.studentID == id
                         select s;
            Models.StudentTable st = new Models.StudentTable();
            foreach (var r in result)
            {
                st = r;
            }

            return View(st);
        }

        //
        // POST: /Student/Edit/5

        [HttpPost]
        public ActionResult Edit(string id, Models.StudentTable st)
        {
            try
            {
                var result = from s in de.StudentTables
                             where s.studentID == id
                             select s;
                
                foreach (var r in result)
                {
                    r.studentName = st.studentName;
                    r.studentAddress = st.studentAddress;
                }
                de.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Student/Delete/5

        public ActionResult Delete(string id)
        {
            var result = from s in de.StudentTables
                         where s.studentID == id
                         select s;
            Models.StudentTable st = new Models.StudentTable();
            foreach (var r in result)
            {
                st = r;
            }
            return View();
        }

        //
        // POST: /Student/Delete/5

        [HttpPost]
        public ActionResult Delete(string id, Models.StudentTable st)
        {
            try
            {
                var result = from s in de.StudentTables
                             where s.studentID == id
                             select s;

                foreach (var r in result)
                {
                    de.StudentTables.DeleteOnSubmit(r);
                }
                de.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
