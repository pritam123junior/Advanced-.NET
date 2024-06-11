using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Person  person = new Person ()
            {
               Name = "Punam Das",
               Email = "punamdash178@gmail.com",
                Phone = "01991945572",
                Degree = "BSC",
                Expertise = "C#,Python, C++, JavaScript, NodeJs,"
               
            };

            ViewBag.Person = new Person [] { person };

            return View();
        }

        

       
        public ActionResult Education ()
        {
            Education  e1 = new Education ()
            {
                EducationName = "HSC",
                EducationYear = 2020,
                EducationGroup = "Science",
                EducationInstitute = "Dhaka Residential Model College (DRMC)"
            };
            Education  e2 = new Education ()
            {
                EducationName = "SSC",
                EducationYear = 2018,
                EducationGroup = "Science",
                EducationInstitute = "Dhaka Residential Model College (DRMC)"
            };

            ViewBag.Education = new Education [] { e1, e2 };

            return View();
        }
        public ActionResult Project() 
        {
            
            Project  p1 = new Project ()
            {
                ProjectTitle = "Banking Management System",
                ProjectDesc = "A simple command line banking management system",
                ProjectCourse = "OOP1 (Java)"
            };
            Project  p2 = new Project ()
            {
                ProjectTitle = "Parcel Management System",
                ProjectDesc = "A GUI-based parcel management system",
                ProjectCourse = "OOP2 (C#)"
            };
            Project  p3 = new Project ()
            {
                ProjectTitle = "Hospital Management System",
                ProjectDesc = "A HTML, CSS, PHP based Web Project for Hospital Management system",
                ProjectCourse = "Webtech"
            };
            Project  p4 = new Project ()
            {
                ProjectTitle = "SaaS-based Hospital Management System",
                ProjectDesc = "A SaaS Oriented Hospital Management system with Multi-tenency and AI integration",
                ProjectCourse = "Adv. Webtech"
            };

            ViewBag.Projects = new Project [] {p1, p2, p3, p4};

            return View();
        }
        public ActionResult Certifications()
        {


            return View();
        }
        public ActionResult Reference()
        {
            ViewBag.Reference1 = "MD. AL-AMIN";
            ViewBag.Reference2 = "S M ABDULLAH SHAFI";

            return View();
        }
        public ActionResult ReferenceDetails(string refName)
        {
            ViewBag.RefName = refName;

            return View();
        }

    }
}