using KI_25.Controllers.Data;

namespace KI_25.Controllers
{
    public static class OrderList
    {
        public static List<ShopData> shopDatas = new List<ShopData>() {
        new ShopData(1, "First Product", 100, "Description for first Product"),
        new ShopData(2, "Second Product", 200, "Description for Second Product"),
        new ShopData(3, "Thirty Product", 300, "Description for Thirty Product"),
        new ShopData(4, "Four Product", 400, "Description for Four Product"),
        };

        public static ShopData GetShopDataList(int index)
        {
            if (index >= 0 && index < shopDatas.Count)
            {
                return shopDatas[index];
            }
            else return shopDatas[0]; 
        }
    }
}
