using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService ser;
        public CategoryController(ICategoryService _ser)
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
        public IActionResult Add(Categories c)
        {
            ser.Add(c);
            return RedirectToAction("Index", "Category");
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
        public IActionResult Update(Categories c)
        {
            ser.Update(c);
            return RedirectToAction("Index", "Category");
        }
        #endregion
        #region Delete

        public IActionResult Delete(int id)
        {
            var data= ser.GetById(id);
            ser.Delete(data);
            ViewBag.Message = "İşlem Başarılı";
            return RedirectToAction("Index", "Category");
        }
        #endregion


    }
}
