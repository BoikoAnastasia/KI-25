namespace KI_25.Models
{
    public static class BacketList
    {
        public static List<Products> ShopData = new List<Products>();

        public static void AddProduct(Products product)
        {
            ShopData.Add(product);
        }
    }
}
