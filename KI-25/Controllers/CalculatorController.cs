using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalculatorController : Controller
    {
        
        public string Index(int  num1, int num2)
        {
            if (num1 == null)
            {
                num1 = 0;
            }
            if (num2 == null)
            {
                num2 = 0;
            }
            int num= num1 + num2;
            string result = num.ToString();
            return result;
        }


        
    }
    
}
