using HomeWork5_SOLID.Intefaces;
using HomeWork5_SOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5_SOLID.Services
{
    public class ApiProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product { Id = 1, Name = "Product from API 1" },
                new Product { Id = 2, Name = "Product from API 2" }
            };
        }
    }
}
