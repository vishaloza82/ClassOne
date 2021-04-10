using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassOne.Controllers
{
    [Authorize]
    public class EbooksController : Controller
    {
        // GET: Ebooks
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ebooks(string OrderNumber)
        {
            ViewBag.OrderNumber = OrderNumber;
            return View();
        }
        public ActionResult SamplePDF(string NestId)
        {
            @ViewBag.filename = NestId;
            return View();
        }
    }
}