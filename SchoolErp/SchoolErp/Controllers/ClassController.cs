using SchoolErp.Models;
using SchoolErp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolErp.Controllers
{
    public class ClassController : Controller
    {
        InvictusSchoolEntities db = new InvictusSchoolEntities();

        // GET: Class
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddClass()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddClass(Class rec)
        {

            ClassServices services = new ClassServices();
            services.AddClass(rec);
            return Json(new { msg = "save" }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddSection()
        {
            var cl_list = db.Classes.ToList();
            var st_list = db.Staffs.ToList();
            ViewBag.cl = cl_list;
            ViewBag.st = st_list;
            return View();
        }
        [HttpPost]
        public JsonResult AddSection(Section rec )
        {
            SectionServices services = new SectionServices();
            services.AddSection(rec);
            var cl_list = db.Classes.ToList();
            var st_list = db.Staffs.ToList();
            ViewBag.cl = cl_list;
            ViewBag.st = st_list;

            return Json(new { msg = "save" }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddSubject()
        {
            var cl_list = db.Classes.ToList();
            
            ViewBag.cl = cl_list;
            
            return View();
        }
        [HttpPost]
        public JsonResult AddSubject(Subject rec)
        {
            SubjectServices services = new SubjectServices();
            services.AddSubject(rec);
            var cl_list = db.Classes.ToList();
           
            ViewBag.cl = cl_list;
           

            return Json(new { msg = "save" }, JsonRequestBehavior.AllowGet);
        }
    }
}
