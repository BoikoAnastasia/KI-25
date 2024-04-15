using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalcController : Controller
    {
        public string Index(int a, int b, string c)
        {
            string result;
            switch (c)
            {
                case "+":
                    result = (a + b).ToString();
                    break;
                case "-":
                    result = (a - b).ToString();
                    break;
                case "*":
                    result = (a * b).ToString();
                    break;
                case "/":
                    result = b != 0 ? ((double)a / b).ToString() : "Ошибка: Деление на ноль";
                    break;
                default:
                    result = "Неизвестная операция";
                    break;
            }
            return $"{a} {c} {b} = {result}";
        }
    }
}
