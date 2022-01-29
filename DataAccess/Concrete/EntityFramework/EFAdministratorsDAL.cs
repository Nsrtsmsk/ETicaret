using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class EFAdministratorsDAL:EfEntityRepositoryBase<Administrators, ProjectContext>, IAdministratorsDAL
    {
    }
}
