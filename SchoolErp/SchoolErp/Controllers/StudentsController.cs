using SchoolErp.Models;
using SchoolErp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolErp.Controllers
{
    public class StudentsController : Controller
    {
        InvictusSchoolEntities db = new InvictusSchoolEntities();
        StudentServices services = new StudentServices();
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

       
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddStudent(Student_Record rec)
        {
           
            services.AddStudent(rec);
            return Json(new { msg="save"},JsonRequestBehavior.AllowGet);
        }

        public ActionResult StudentList()

        {


            var list = services.List();
            return View(list);


        }


        public ActionResult AddParents()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Student_Enrolment()
        {
            var stud_list = db.Student_Records.ToList();
            ViewBag.stud = stud_list;
            var cl_list = db.Classes.ToList();
            ViewBag.cl = cl_list;
            var sec_list = db.Sections.ToList();
            ViewBag.sec = sec_list;
            var st_list = db.Staffs.ToList();
            ViewBag.st = st_list;
            return View();
        }
        [HttpPost]
        public JsonResult Student_Enrolment(Student_Enrolment rec)
        {
            EnrolmentServices services = new EnrolmentServices();
            services.Student_Enrolment(rec);
            var stud_list = db.Student_Records.ToList();
            ViewBag.stud = stud_list;
            var cl_list = db.Classes.ToList();
            ViewBag.cl = cl_list;
            var sec_list = db.Sections.ToList();
            ViewBag.sec = sec_list;
            var st_list = db.Staffs.ToList();
            ViewBag.st = st_list;



            return Json(new { msg = "save" }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddAttendence()
        {
            var stud_list = db.Student_Records.ToList();
            ViewBag.stud = stud_list;
            return View();
        }
        [HttpPost]
        public JsonResult AddAttendence(Attendence rec)
        {
            S_AttendenceServices services = new S_AttendenceServices();
            services.AddAttendence(rec);
            var stud_list = db.Student_Records.ToList();
            ViewBag.stud = stud_list;
            return Json(new { msg = "save" }, JsonRequestBehavior.AllowGet);
        }


        

    }

}