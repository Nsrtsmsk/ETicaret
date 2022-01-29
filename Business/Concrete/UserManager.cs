using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL service;
        public UserManager(IUserDAL _service)
        {
            service = _service;
        }
        public void Add(Users User)
        {
            service.Add(User);
        }

        public void Delete(Users User)
        {
            service.Delete(User);
        }



        public List<Users> GetAll()
        {

            return service.GetAll();
        }

        public Users GetById(int id)
        {
            return service.Get(x => x.Id == id);
        }

        public Users Login(string Email, string Password)
        {
           return  service.Get(x => x.EMail == Email && x.Password == Password);
           
            
        }

        public void Update(Users User)
        {
            service.Update(User);
        }
    }
}
