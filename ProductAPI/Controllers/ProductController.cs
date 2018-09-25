using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers 
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>
            {
                new Product {
                    ProductID = 1, 
                    Name = "Dark Fantasy",
                    Description = "This is an awesome cookie"
                },
                new Product {
                    ProductID = 2, 
                    Name = "Bhujia Sev",
                    Description = "This is an awesome snacks"
                },
            };
        } 
    }
}