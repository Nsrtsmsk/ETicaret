using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AllProductsController : Controller
    {
        IProductService ser;
        public AllProductsController(IProductService _ser)
        {
            ser = _ser;
        }
        public IActionResult Index()
        {
            return View(ser.GetAll());
        }
    }
}
