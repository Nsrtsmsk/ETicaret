﻿using Core.DataAccess;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDAL : IEntityRepository<Products>
    {
    }
}
