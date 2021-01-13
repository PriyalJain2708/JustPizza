#nullable disable

namespace PizzaCoreApi.Models
{
    public partial class PizzaFact
    {
        public int PizzaId { get; set; }
        public string Imagesrc { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Category { get; set; }
        public string Rating { get; set; }
        public string ReviewCount { get; set; }
    }
}