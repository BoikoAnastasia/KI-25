using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalcController : Controller
    {
        public string Index(int a, int b, string c)
        {
            switch (c)
            {
                default:
                case "+": return a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
                case "-": return a.ToString() + c + b.ToString() + " = " + (a - b).ToString();
                case "*": return a.ToString() + c + b.ToString() + " = " + (a * b).ToString();
                case "/": return a.ToString() + c + b.ToString() + " = " + ((double)a / (double)b).ToString();
            }
        }
    }
}
