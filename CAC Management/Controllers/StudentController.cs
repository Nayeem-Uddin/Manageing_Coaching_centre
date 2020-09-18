using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAC_Management.DataBase;
using CAC_Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CAC_Management.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataContext db;
        public StudentController(DataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Student model)
        {
            var i = db.Student.Where(x => x.StudentName == model.StudentName && x.Password == model.Password).FirstOrDefault();
            if (i != null)
            {
                ViewBag.Login = "Succeecful";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Login = "User Name or Password Invalid!!!";
                return View();
            }
        }

        public IActionResult StudentAdmission()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StudentAdmission(Student s)
        {
            if (ModelState.IsValid)
            {
                Student t = new Student();
                {
                    t.StudentId = s.StudentId;
                    t.StudentName = s.StudentName;
                    t.FatherName = s.FatherName;
                    t.MotherName = s.MotherName;
                    t.DOB = s.DOB;
                    t.Gender = s.Gender;
                    t.Address = s.Address;
                    t.Contact = s.Contact;
                    t.Email = s.Email;
                    t.Password = s.Password;
                    t.TuitionFee = s.TuitionFee;
                    t.PayAmount = s.PayAmount;
                    t.DueAmount = t.TuitionFee - t.PayAmount;
                    t.PaymentStatus = t.DueAmount;
                };
                db.Student.Add(t);
                db.SaveChanges();
                ViewBag.Success = "Student Account Created Successfully.";
                ModelState.Clear();
            }
            return View();
        }
        
        public IActionResult StudentList()
        {
            var test = db.Student;
            var i = new List<Student>();
            foreach (var s in test)
            {
                Student t = new Student();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.FatherName = s.FatherName;
                t.MotherName = s.MotherName;
                t.DOB = s.DOB;
                t.Gender = s.Gender;
                t.Address = s.Address;
                t.Contact = s.Contact;
                t.Email = s.Email;
                t.Password = s.Password;
                t.TuitionFee = s.TuitionFee;
                t.PayAmount = s.PayAmount;
                t.DueAmount = t.TuitionFee - t.PayAmount;
                t.PaymentStatus = t.DueAmount;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult Search(int Id)
        {
            var l = db.Student.Find(Id);
            return View(l);
        }

        public IActionResult StudentSearch(int Id)
        {
            var l = db.Student.Find(Id);
            return View(l);
        }

        public IActionResult StudentDetails(int Id)
        {
            var n = db.Student.Find(Id);
            return View(n);
        }

        public IActionResult EditStudent(int Id)
        {
            var l = db.Student.Find(Id);
            return View(l);
        }

        [HttpPost]
        public IActionResult EditStudent(Student s)
        {
            if (ModelState.IsValid)
            {
                Student t = new Student();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.FatherName = s.FatherName;
                t.MotherName = s.MotherName;
                t.DOB = s.DOB;
                t.Gender = s.Gender;
                t.Address = s.Address;
                t.Contact = s.Contact;
                t.Email = s.Email;
                t.Password = s.Password;
                t.TuitionFee = s.TuitionFee;
                t.PayAmount = s.PayAmount;
                t.DueAmount = t.TuitionFee - t.PayAmount;
                t.PaymentStatus = t.DueAmount;
                db.Student.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("StudentList");
        }

        public IActionResult DeleteStudent(int Id)
        {
            var l = db.Student.Find(Id);
            db.Student.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }

        public IActionResult ClassRoutine()
        {
            return View();
        }

        public IActionResult ExamRoutine()
        {
            return View();
        }

    }
}