using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class CalculatorController : Controller
    {
        public String Index(int a, int b)
        {
            return a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
        }
    }
}
