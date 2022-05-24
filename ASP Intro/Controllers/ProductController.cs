using ASP_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Intro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string search)
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Name ="Test 1",
                    Id=1,
                    Image= "headphone.jpg",
                    Description="Test 1 desc",
                    Price=100
                },
                new Product
                {
                    Name ="Test 2",
                    Id=2,
                    Image= "mercedes.png",
                    Description="Test 2 desc",
                    Price=200
                },
                new Product
                {
                    Name ="Test 3",
                    Id=3,
                    Image= "phone.jpg",
                    Description="Test 3 desc",
                    Price=300
                },
            };

            if (!string.IsNullOrWhiteSpace(search))
            {
               products= products.FindAll(p =>p.Name.ToLower().Contains(search.ToLower()));
                if (products.Count == 0)
                    return NotFound();
            }
            
            return View();
        }
    }
}
