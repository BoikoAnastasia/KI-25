﻿using KI_25.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KI_25.Controllers
{
    public class HomeController : Controller
    {
        public IList<Product> Items { get; set; }
        public string Index()
        {
            var str = "";
            var json = System.IO.File.ReadAllText(@"Product.json");
            Items = JsonConvert.DeserializeObject<IList<Product>>(json);



            for (int i = 0; i < Items.Count; i++)
            {
                str += Items[i].Id.ToString() + " " + Items[i].Name.ToString() + " " + Items[i].Price.ToString() + " " + Items[i].Description.ToString() + Items[i].Category + "\n";
            }
        }
    }