using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;

namespace KI_25.Controllers
{
    public class ProductsController : Controller
    {
        public IList<Products> Items { get; set; }
       

        public string GetInfo()
        {
            string returnStr = "";
            var json = System.IO.File.ReadAllText(@"products.json");
            Items = JsonConvert.DeserializeObject<IList<Products>>(json);
            for (int i = 0; i < Items.Count; i++)
            {
                
               returnStr += Items[i].Id.ToString() + " " + Items[i].Name.ToString() + " " + Items[i].Cost.ToString() + " " + Items[i].Description.ToString() + "\n";
            }
            return returnStr;
        }
    }
}
