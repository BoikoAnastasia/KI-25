namespace KI_25.Controllers.Data
{
    public class ShopData(int Id, string Name, int Cost, string Description)
    {
        public int Id { get; set; } = Id;

        public string Name { get; set; } = Name;

        public int Cost { get; set; } = Cost;

        public string Description { get; set; } = Description;
    }
}
