using GigaByte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigaByte.Controllers
{
    public class PhonesController : Controller
    {
        // GET: Phones
        public ActionResult Index()
        {
            var phones = new Phones() { Name = "Abu" };
            
            return View(phones);
        }
    }
}