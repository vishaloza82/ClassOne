using ClassOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ClassOne.Controllers
{
    public class LoginController : Controller
    {
        ClassOneEntities db = new ClassOneEntities();
        // GET api/<controller>

        public ActionResult Student()
        {
            return View();
        }

        public ActionResult Teacher()
        {
            return View();
        }

        public JsonResult GetCurrentUser()
        {
            using (ClassOneEntities db = new ClassOneEntities())
            {
                string name = User.Identity.Name;
                usp_GetStudentDetails_Result resp = db.usp_GetStudentDetails(name).FirstOrDefault();
                return Json(resp, JsonRequestBehavior.AllowGet);
            }
        }
    }
}