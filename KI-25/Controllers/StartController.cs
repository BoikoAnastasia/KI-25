﻿using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class HomeController1 : Controller
    {
        public string Hello(string time)
        {
            DateTime currentTime = DateTime.Now;

            string greeting = GetGreeting(currentTime.Hour);

            return greeting;
        }

        public string GetGreeting(int hour)
        {
            if (hour >= 0 && hour < 6)
            {
                return "Добрый ночи.";
            }
            else if (hour >= 6 && hour < 12)
            {
                return "Доброе утро.";
            }
            else if (hour >= 12 && hour < 18)
            {
                return "Добрый день.";
            }
            else { return "Добрый вечер."; }
        }
    }
}
