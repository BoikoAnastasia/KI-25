using Microsoft.AspNetCore.Mvc;

namespace CalculatorService.Controllers
{
    public class CalcController : Controller
    {
        public string PerformOperation(int firstNumber, int secondNumber, char op)
        {
            int result;
            switch (op)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                default:
                    result = firstNumber + secondNumber;
                    break;
            }
            return result.ToString();
            }
        public string SumNumbers(string firstValue, string secondValue)
        {
            double num1 = string.IsNullOrEmpty(firstValue) ? 0 : Convert.ToDouble(firstValue);
            double num2 = string.IsNullOrEmpty(secondValue) ? 0 : Convert.ToDouble(secondValue);
            double sum = num1 + num2;

            return $"{firstValue} + {secondValue} = {sum}";
        }
    }
}
