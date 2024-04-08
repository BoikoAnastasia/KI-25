using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id)
        {
            string output = "";

            OrderList.GetShopDataList(1);

            switch (id)
            {
                case 0:
                    for (int i = 0; i < OrderList.shopDatas.Count; i++)
                    {
                        output += OrderList.GetShopDataList(i).Id.ToString() + "\n" + OrderList.GetShopDataList(i).Name + "\n" + OrderList.GetShopDataList(i).Cost + "\n\n";
                    }
                    return output;
                default:
                    return OrderList.GetShopDataList(id - 1).Id.ToString() + "\n" + OrderList.GetShopDataList(id - 1).Name + "\n" + OrderList.GetShopDataList(id - 1).Cost + "\n" + OrderList.GetShopDataList(id - 1).Description;
            }
        }
    }
}