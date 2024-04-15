using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    
    public class CalculatorController : ControllerBase
    {
        public string calculater(int firstNum, int secondNum, string sign)
        {
            if (sign.Equals("+"))
            {
                return firstNum + " + " + secondNum + " = " + (firstNum + secondNum).ToString();
            }

            if (sign.Equals("-"))
            {
                return firstNum + " - " + secondNum + " = " + (firstNum - secondNum).ToString();
            }

            if (sign.Equals("*"))
            {
                return firstNum + " * " + secondNum + " = " + (firstNum * secondNum).ToString();
            }

            return "";
        }
    }
}
