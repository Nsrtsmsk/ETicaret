using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Cart:IEntity
    {
        public int Id { get; set; }
        public int ProductsId { get; set; }
        public string MainImages { get; set; }
        public string Name { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
    }
}
