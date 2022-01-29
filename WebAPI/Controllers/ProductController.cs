using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService ser;
        public ProductController(IProductService _ser)
        {
            ser = _ser;
        }

        [HttpGet]
        public IList<Products> Get()
        {
            return ser.GetAll();
        }
        [HttpGet("{id}")]
        public Products Get(int id)
        {
            return ser.GetById(id);
        }
        [HttpPost]
        public IActionResult Post(Products products)
        {
            ser.Add(products);
            if (products!=null)
            {
                return Ok("Başarılı");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = ser.GetById(id);
            ser.Delete(data);

            if (ModelState.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult Put(Products products, int id)
        {
            ser.Update(products);
            if (ModelState.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
