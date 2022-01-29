using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDAL service;
        public CategoryManager(ICategoryDAL _service)
        {
            service = _service;
        }

        public void Add(Categories category)
        {
            service.Add(category);
        }

        public void Delete(Categories category)
        {
            service.Delete(category);
        }

        public List<Categories> GetAll()
        {
            return service.GetAll();
        }

        public Categories GetById(int id)
        {
            return service.Get(x => x.Id == id);
        }

        public void Update(Categories category)
        {
            service.Update(category);
        }
    }
}
