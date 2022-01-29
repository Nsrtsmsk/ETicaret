using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<Users> GetAll();
        void Add(Users User);
        void Update(Users User);
        void Delete(Users User);
        Users GetById(int id);
        Users Login(string Email, string Password);
    }
}
