﻿using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalculatorController : Controller
    {
        public String Index(int a, int b)
        {
            switch (c)
            {
                case "+":
                    return a.ToString() + c + b.ToString() + " = " + (a + b).ToString();
                case "-":
                    return a.ToString() + c + b.ToString() + " = " + (a - b).ToString();
                case "*":
                    return a.ToString() + c + b.ToString() + " = " + (a * b).ToString();
            }
            return "Я ни знаю :((";
        }
    }
}