using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;

namespace KI_25.Controllers
{
    public class ProductsController : Controller
    {
        public IList<Products> Items { get; set; }
        public string strId = ""; 
        public string strName = "";
        public string returnStr = "";
        public string strPrice = "";
        public string strDescriptions = "";

        public string GetInfo()
        {
            var json = System.IO.File.ReadAllText(@"products.json");
            Items = JsonConvert.DeserializeObject<IList<Products>>(json);
            for (int i = 0; i < Items.Count; i++)
            {
                strId = Items[i].Id.ToString();
                strName = Items[i].Name.ToString();
                strPrice = Items[i].Cost.ToString();
                strDescriptions = Items[i].Description.ToString();
                returnStr += strId + " " + strName + " " + strPrice + " " + strDescriptions + "\n";
            }
            return returnStr;
        }
    }
}
