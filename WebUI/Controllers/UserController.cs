using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {
        IUserService ser;
        public UserController(IUserService _ser)
        {
            ser = _ser;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email,string password)
        {
           var data= ser.Login(email, password);
            if (data==null)
            {
              return RedirectToAction("Index", "Category");

            }
            else
            {
              return  RedirectToAction("Index", "Product");
            }

        }
    }
}
