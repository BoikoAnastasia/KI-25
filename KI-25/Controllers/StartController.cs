using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace KI_25.Controllers
{

    public class StartController : Controller
    {
        public string Index(string id)            
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour >= 0 && currentTime.Hour <=5 && currentTime.Minute <=59)
            {
                return "Доброй ночи";
            }
            else if (currentTime.Hour >= 6 && currentTime.Hour <= 11 && currentTime.Minute <= 59)
            {
                return "Доброе утро";
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour <= 17 && currentTime.Minute <= 59)
            {
                return "Добрый День";
            }
            else if (currentTime.Hour >= 18 && currentTime.Hour <= 23 && currentTime.Minute <= 59)
            {
                return "Добрый Вечер";
            }


            return currentTime.ToString();

           
        }
    }
}



