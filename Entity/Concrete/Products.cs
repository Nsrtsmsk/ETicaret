using Core.Entities;

namespace Entity.Concrete
{
    public class Products:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string MainImage { get; set; }
        public bool Status { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }

    }
}
