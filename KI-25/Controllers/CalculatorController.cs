using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalculatorController : Controller
    {
        public string calculate(int firstNum, int secondNum)
        {
            return firstNum + " + " + secondNum + " = " + (firstNum + secondNum).ToString();
        }
    }
}
