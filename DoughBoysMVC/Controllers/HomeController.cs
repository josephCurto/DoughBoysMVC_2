using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using DoughBoysMVC.Models;

namespace DoughBoysMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult PreOrder()
        {
            return View();
        }

        public ActionResult Questions()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }
    }
}
