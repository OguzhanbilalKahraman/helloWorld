using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloworld.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Uygulama Calisiyor....";
        }
        public string Test()
        {
            return "bu test aksiyonudur.";
        }

        public IActionResult Selamla()
        {
            ViewResult result = View();

             return result;
           // return View();
        }

        public IActionResult Selamla2()
        {
            ViewResult result = View("Test2");

            return result;
            // return View();
        }


    }
}
