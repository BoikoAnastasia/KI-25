using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KI_25.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StartController : Controller
    {
            [HttpGet("{time}")]
            public string GetTime(string time)
            {

            DateTime currentTime = DateTime.Now;

               
                string greeting = GetGreeting(currentTime.Hour);

                return greeting;
            }

            private string GetGreeting(int hour)
            {
                if (hour >= 0 && hour < 6)
                {
                    return "Доброй ночи";
                }
                else if (hour >= 6 && hour < 12)
                {
                    return "Доброе утро";
                }
                else if (hour >= 12 && hour < 18)
                {
                    return "Добрый день";
                }
                else
                {
                    return "Добрый вечер";
                }
            }
        }
    }
