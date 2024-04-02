using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "data.json");
            var json = System.IO.File.ReadAllText(path);

            ShopData dataJson = Newtonsoft.Json.JsonConvert.DeserializeObject<ShopData>(json);

            string output = "";
            switch (id)
            {
                case 0:
                    for (int i = 0; i < dataJson.id.Length; i++)
                    {
                        output += dataJson.id[i].ToString() + "\n" + dataJson.Name[i] + "\n" + dataJson.Cost[i] + "\n\n";
                    }
                    return output;
                default:
                    return dataJson.id[id-1].ToString() + "\n" + dataJson.Name[id-1] + "\n" + dataJson.Cost[id-1] + "\n" + dataJson.Description[id-1];
            }
        }
    }
}