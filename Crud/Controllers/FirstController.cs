using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud.Models;
namespace Crud.Controllers
{
    public class FirstController : Controller
    {
        Istudent Repo = null;
        public FirstController() 
        {
            Repo = new StudentRepo();
        }
        // GET: First
        public ActionResult Index()
        {
            return View(Repo.SelectAll());
        }
        public JsonResult create(Student st)
        {
            Repo.Create(st);
            Repo.Save();
            return Json("Created Sucessfully", JsonRequestBehavior.AllowGet);
        }
    }
}