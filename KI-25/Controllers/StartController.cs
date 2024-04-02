using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace KI_25.Controllers
{
    public class StartController : Controller
    {
        public String Hello()
        {
            DateTime currentTime = DateTime.Now;

            CultureInfo russianCulture = new CultureInfo("ru-RU");
            string russianTime = currentTime.ToString("HH:mm:ss", russianCulture);

            string[] currentTimeString = russianTime.ToString().Split(':');

            if (Convert.ToUInt32(currentTimeString[0]) >= 0 && Convert.ToUInt32(currentTimeString[0]) <= 5 && Convert.ToUInt32(currentTimeString[1]) <= 59)
            {
                return "Доброй ночи";
            } 
            else if (Convert.ToUInt32(currentTimeString[0]) >= 6 && Convert.ToUInt32(currentTimeString[0]) <= 11 && Convert.ToUInt32(currentTimeString[1]) <= 59)
            {
                return "Доброе утро";
            }
            else if (Convert.ToUInt32(currentTimeString[0]) >= 12 && Convert.ToUInt32(currentTimeString[0]) <= 17 && Convert.ToUInt32(currentTimeString[1]) <= 59)
            {
                return "Добрый день";
            }
            else if (Convert.ToUInt32(currentTimeString[0]) >= 18 && Convert.ToUInt32(currentTimeString[0]) <= 23 && Convert.ToUInt32(currentTimeString[1]) <= 59)
            {
                return "Добрый вечер";
            }

            return "Я ни знаю какое время :((";
        }
    }
}
