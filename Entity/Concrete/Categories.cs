using Core.Entities;
using System.Collections.Generic;

namespace Entity.Concrete
{
    public class Categories:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
