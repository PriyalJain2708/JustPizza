#nullable disable

namespace ApiCorePizza.Models
{
    public partial class Pizzadetail
    {
        public int PizzaId { get; set; }
        public string ImageSrc { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCode { get; set; }
        public string Category { get; set; }
        public int? Rating { get; set; }
        public int? ReviewCount { get; set; }
    }
}