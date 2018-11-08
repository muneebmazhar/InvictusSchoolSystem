using SchoolErp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Dynamic;
namespace SchoolErp.Services
{
    public class StudentServices
    {

        InvictusSchoolEntities db = new InvictusSchoolEntities();
    

        // GET: StudentServices
        public void AddStudent(Student_Record rec)
        {
            rec.Admission_Date = DateTime.Now;
            db.Student_Records.Add(rec);
            db.SaveChanges();

        }

        public object List()
        {
            var obj = db.Student_Records.ToList();
            return obj;
        }
        

    }




}
