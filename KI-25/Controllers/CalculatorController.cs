using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalculatorController : Controller
    {
        public String Index1(int a, int b, string c)
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
