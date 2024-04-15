using KI_25.Controllers.Data;
using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id, ShopData dataJson)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "data.json");
            var json = System.IO.File.ReadAllText(path);

            ShopData dataJson = Newtonsoft.Json.JsonConvert.DeserializeObject<ShopData>(json);

            string output = "";
            if (id == 0)
            {
                for (int i = 0; i < dataJson.Id.Length; i++)
                {
                    output += dataJson.Id[i].ToString() + "\n" + dataJson.Name[i] + "\n" + dataJson.Cost[i] + "\n\n";
                }
                
            }
            else if (id > 0 && id <= dataJson.Id.Length)
            {
                output = dataJson.Id[id - 1].ToString() + "\n" + dataJson.Name[id - 1] + "\n" + dataJson.Cost[id - 1] + "\n" + dataJson.Description[id - 1];
            }
            else
            {
                output = "Invalid ID"; 
            }
            return output;
        }
    }
}