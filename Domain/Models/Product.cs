

namespace Domain.Models
{
    public class Product:BaseEntitiy
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }

        public Category CatagoryName { get; set; }
        public Category Category { get; internal set; }
    }
}
