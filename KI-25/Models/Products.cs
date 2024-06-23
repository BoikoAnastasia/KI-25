using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace KI_25.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Specifications { get; set; }
        public Products(int id, string name, double cost, string description, string picture, string specifications)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Description = description;
            Picture = picture;
            Specifications = specifications;
        }
    }
}
