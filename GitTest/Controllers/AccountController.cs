using GitTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitTest.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult RegisterOrLogin()
        {
            Person person = new Person();

            person.InviteCode = "123";
            return View();

        }
    }
}
