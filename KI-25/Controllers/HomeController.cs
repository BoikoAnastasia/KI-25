using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id)
        {
            string output = "";
            switch (id)
            {
                case 0:
                    for (int i = 0; i < OrderList.shopDatas.Count; i++)
                    {
                        output += OrderList.shopDatas[i].Id.ToString() + "\n" + OrderList.shopDatas[i].Name + "\n" + OrderList.shopDatas[i].Cost + "\n\n";
                    }
                    return output;
                default:
                    return OrderList.shopDatas[id - 1].Id.ToString() + "\n" + OrderList.shopDatas[id - 1].Name + "\n" + OrderList.shopDatas[id - 1].Cost + "\n" + OrderList.shopDatas[id - 1].Description;
            }
        }
    }
}