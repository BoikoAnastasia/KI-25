using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalcController : Controller
    {
        public string Index(int a, int b, string c)
        {
            if (a.GetType() == typeof(int) && b.GetType() == typeof(int))
            {
                switch (c)
                {
                    case "+":
                    default:
                        return a.ToString() + c + b.ToString() + " = " + (a + b).ToString();
                    case "-":
                        return a.ToString() + c + b.ToString() + " = " + (a - b).ToString();
                    case "*":
                        return a.ToString() + c + b.ToString() + " = " + (a * b).ToString();
                    case "/":
                        if (b != 0)
                        {
                            double result = (double)a / b;
                            return a.ToString() + c + b.ToString() + " = " + result.ToString();
                        }
                        else
                        {
                            return "На нуль дилить низя";
                        }
                }
                return "Я ни знаю :((";
            }
            else return "Подумай ещё раз";
        }
    }
}
