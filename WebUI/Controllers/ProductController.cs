using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService ser;
        public ProductController(IProductService _ser)
        {
            ser = _ser;
        }
        public IActionResult Index()
        {
            return View(ser.GetAll());
        }
        #region Add
        public IActionResult Add()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Add(Products p)
        {
            ser.Add(p);
            return RedirectToAction("Index", "Product");
        }
        #endregion
        #region Update
        [HttpGet]
        public IActionResult Update(int id)
        {
            var data = ser.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Update(Products p)
        {
            ser.Update(p);
            return RedirectToAction("Index", "Product");
        }

        #endregion
        #region Delete
        public IActionResult Delete(int id)
        {
            var data = ser.GetById(id);
            ser.Delete(data);
            ViewBag.Message = "İşlem Başarılı";
            return RedirectToAction("Index", "Product");
        }

        #endregion
    }
}
