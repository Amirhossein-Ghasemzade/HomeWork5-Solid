using HomeWork5_SOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5_SOLID.Intefaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
