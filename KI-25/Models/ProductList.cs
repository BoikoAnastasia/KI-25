using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json;

namespace KI_25.Models
{
    public static class ProductList
    {
        public static IList<Product> Items = JsonConvert.DeserializeObject<IList<Product>>(System.IO.File.ReadAllText(@"products.json"));
        public static Product TryGetProduct(int id)
        {
            return Items[id - 1];
        }
    }

}
