﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class StartController : Controller
    {
        // GET: StartController
        public string Hello()
        {
            

            DateTime currentTime = DateTime.Now;
            int currentHour = currentTime.Hour;

            if (currentHour >= 0 && currentHour < 6)
            {
                return ("Доброй ночи");
            }
            else if (currentHour >= 6 && currentHour < 12)
            {
                return ("Доброе утро");
            }
            else if (currentHour >= 12 && currentHour < 18)
            {
                return ("Добрый день");
            }
            else
            {
                return("Добрый вечер");
            
            }
            
        }

    }
        
}

