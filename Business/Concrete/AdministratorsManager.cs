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
    public class AdministratorsManager:IAdministratorService
    {
        IAdministratorsDAL services;
        public AdministratorsManager(IAdministratorsDAL _services)
        {
            services = _services;
        }

        public void Add(Administrators administrators)
        {
            services.Add(administrators);
        }

        public void Delete(Administrators administrators)
        {
            services.Delete(administrators);
        }

        public List<Administrators> GetAll()
        {
            return services.GetAll();
        }

        public Administrators GetById(int id)
        {
            return services.Get(x=>x.Id==id);
        }

        public void Update(Administrators administrators)
        {
            services.Update(administrators);
        }
    }
}
