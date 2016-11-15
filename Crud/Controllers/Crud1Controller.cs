using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud.Models; 
namespace Crud.Controllers
{
    public class Crud1Controller : Controller
    {
        Istudent stRepo = null;
        public Crud1Controller()
        {
            stRepo = new StudentRepo();
        }
        // GET: Crud1
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                stRepo.Create(st);
                stRepo.Save();
                return RedirectToAction("Index");
            }
            else
                return View(st);
        }
        public ActionResult Show()
        {
            return View(stRepo.SelectAll());
        }
   }
}