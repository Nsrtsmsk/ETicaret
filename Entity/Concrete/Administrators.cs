using Core.Entities;

namespace Entity.Concrete
{
    public class Administrators:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string EMail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
