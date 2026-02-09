//using HomeWork5_SOLID.Factory; برای تسک شماره 3 بود
using HomeWork5_SOLID.Intefaces;
using HomeWork5_SOLID.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace HomeWork5_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select source: db / api / file");
            string input = Console.ReadLine();

            //IProductService service = ProductServiceFactory.Create(input);  برای تسک شماره 3 بود

            var services = new ServiceCollection();

            Console.WriteLine("Select source: db / api / file");
            if (input == "db")
                services.AddScoped<IProductService, DatabaseProductService>();
            else if (input == "api")
                services.AddScoped<IProductService, ApiProductService>();
            else
                services.AddScoped<IProductService, FileProductService>();

            var provider = services.BuildServiceProvider();

            IProductService service = provider.GetService<IProductService>();

            var products = service.GetProducts();

            foreach (var p in products)
            {
                Console.WriteLine(p.Id + " - " + p.Name);
            }

            Console.ReadLine();
        }
    }
}
