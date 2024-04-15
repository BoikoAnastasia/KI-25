using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KI_25.Controllers
{
    public class StartController : Controller
    {
        public string getTime()
        {
            DateTime time = DateTime.Now;

            return getString(time.Hour);
        }

        public string getString(int hour)
        {

            if (hour >= 0 && hour < 6)
            {
                return "Ночь";
            }

            if (hour >= 6 && hour < 12)
            {
                return "Утро";
            }

            if (hour >= 12 && hour < 18)
            {
                return "День";
            }

            if (hour >= 18)
            {
                return "Вечер";
            }

            return "";
        }
    }
}