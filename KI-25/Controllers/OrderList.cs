using KI_25.Controllers.Data;

namespace KI_25.Controllers
{
    public static class OrderList
    {
        public static List<ShopData> shopDatas = new List<ShopData>() {
            new ShopData(1, "Premier Item", 100, "Insight on the premier item"),
            new ShopData(2, "Elite Gear", 200, "Details of the elite gear"),
            new ShopData(3, "Trio Treasure", 300, "Profile of the trio treasure"),
            new ShopData(4, "Quartet Bundle", 400, "Overview of the quartet bundle"),
        };
    }
}
