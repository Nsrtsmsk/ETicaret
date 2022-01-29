using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Products> GetAll();
        void Add(Products product);
        void Update(Products product);
        void Delete(Products product);
        Products GetById(int id);
    }
}
