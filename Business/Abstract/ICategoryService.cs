using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Categories category);
        void Update(Categories category);
        void Delete(Categories category);
        List<Categories> GetAll();

        Categories GetById(int id);
    }
}
