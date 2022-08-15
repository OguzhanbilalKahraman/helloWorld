using helloworld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloworld.Controllers
{
    public class UserController : Controller
    {
        public IActionResult GetUser()
        {
            User user = new User();
            user.ID = 14;
            user.FirstName = "oguz";
            user.LastName = "kahraman";

            return View();
        }

        [NonAction]// asagisini aksiyon almiyor.

        public string GetFullName(User user)
        {
            return user.FirstName+" "+user.LastName;
        }
    }
}
