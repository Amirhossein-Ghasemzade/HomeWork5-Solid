using HomeWork5_SOLID.Intefaces;
using HomeWork5_SOLID.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5_SOLID.Factory
{
    public class ProductServiceFactory
    {
        public static IProductService Create(string type)
        {
            if (type == "db")
                return new DatabaseProductService();

            if (type == "api")
                return new ApiProductService();

            if (type == "file")
                return new FileProductService();

            return new DatabaseProductService();
        }
    }
}
