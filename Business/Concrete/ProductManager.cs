using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _productdal;
        public ProductManager(IProductDAL productdal)
        {
            _productdal = productdal;
        }
        public void Add(Products product)
        {
            _productdal.Add(product);
        }

        public void Delete(Products product)
        {
            _productdal.Delete(product);
        }

        public List<Products> GetAll()
        {
            return _productdal.GetAll();
        }

        public Products GetById(int id)
        {
            return _productdal.Get(x => x.Id == id);
        }

        public void Update(Products product)
        {
            _productdal.Update(product);
        }
    }
}
