using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class Calculator1Controller : Controller
    {
        public string Index(int a, int b, string c)
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
