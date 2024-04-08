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
        public string Index(int id)
        {
            string returnStr = "";
            var json = System.IO.File.ReadAllText(@"products.json");
            Items = JsonConvert.DeserializeObject<IList<Products>>(json);

            switch (id)
            {
                case 0:
                    for(int i = 0; i < Items.Count; i++) {
                        returnStr += Items[i].Id.ToString() + " " + Items[i].Name.ToString() + " " + Items[i].Cost.ToString() + " " + Items[i].Description.ToString() + "\n";
                    }
                    return returnStr;
                default:
                    return Items[id - 1].Id.ToString() + " " + Items[id - 1].Name.ToString() + " " + Items[id - 1].Cost.ToString() + " " + Items[id - 1].Description.ToString();
            }
        }
    }
}
