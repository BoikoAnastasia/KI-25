using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id)
        {
            return "View()" + id;
        }

        public string Bom()
        {
            return "Bom";
        }
    }
}