using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {
        public IList<Product> Items { get; set; }
        public string Pindex() {
            var str = "";
             var json = System.IO.File.ReadAllText(@"Product.json");
            Items = JsonConvert.DeserializeObject<IList<Product>>(json);
        
          

            for (int i = 0; i < Items.Count; i++)
            {
                str += Items[i].Id.ToString() + " " + Items[i].Name.ToString() + " " + Items[i].Price.ToString() + " " + Items[i].Description.ToString() + Items[i].Category + "\n";
            }

                return str;
        }
        public string Index(int id)
        {
            string returnStr = "";
            var json = System.IO.File.ReadAllText(@"Product.json");
            Items = JsonConvert.DeserializeObject<IList<Product>>(json);

            switch (id)
            {
                case 0:
                    for (int i = 0; i < Items.Count; i++)
                    {
                        returnStr += Items[i].Id.ToString() + " " + Items[i].Name.ToString() + " " + Items[i].Price.ToString() + " " + Items[i].Description.ToString() +  Items[i].Category + "\n";
                    }
                    return returnStr;
                default:
                    return Items[id - 1].Id.ToString() + " " + Items[id - 1].Name.ToString() + " " + Items[id - 1].Price.ToString() + " " + Items[id - 1].Description.ToString() + Items[id - 1].Category ;
            }
        }
    }
}
  
  
