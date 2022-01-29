using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ProductDetailController : Controller
    {
        IProductService ser;
        public ProductDetailController(IProductService _ser)
        {
            ser = _ser;
        }
        public IActionResult Index(int id)
        {
            return View(ser.GetById(id));
        }
    }
}
