using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                return "Доброй ночи";
            }

            if (hour >= 6 && hour < 12)
            {
                return "Доброе утро";
            }

            if (hour >= 12 && hour < 18)
            {
                return "Добрый День";
            } 

            if(hour >= 18)
            {
                return "Добрый вечер";
            }

            return "";
        }
    }
}
