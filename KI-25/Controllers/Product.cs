namespace KI_25.Controllers
{
    public class Product
    {
        public Product(int id, string Name, string Description, string Price, string ImageUrl)
        {
            this.Id = id;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.ImageUrl = ImageUrl;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
