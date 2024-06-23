using KI_25.Models;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class ProductController
    {
        public IActionResult Index(int id)
        {
            return View(ProductsList.ShopData[id]);
        }

        private IActionResult View(Products products)
        {
            throw new NotImplementedException();
        }

        public IActionResult basket(int id)
        {

            BacketList.AddProduct(ProductsList.ShopData[id]);
            return View(BacketList.ShopData);
        }

        private IActionResult View(List<Products> shopData)
        {
            throw new NotImplementedException();
        }
    }
}

