using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int num1, int num2, char operation)
        {

            switch (operation)
            {
                case '+':
                    int plus = num1 + num2;
                    return plus.ToString();
                case '-':
                    int minus = num1 - num2;
                    return minus.ToString();
                case '*':
                    int multiplymultiplication = num1 * num2;
                    return multiplymultiplication.ToString();
                default:
                    int def = num1 + num2;
                    return def.ToString();
            }
        }
    }
}