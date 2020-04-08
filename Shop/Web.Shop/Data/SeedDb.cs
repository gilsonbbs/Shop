using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Shop.Data.Entities;

namespace Web.Shop.Data
{
    public class SeedDb
    {
        private readonly DataContext context;
        private Random random;
        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }
        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();
            if (!this.context.Products.Any())
            {
                this.AddProduct("Samsung Edge 7");
                this.AddProduct("PC Box");
                this.AddProduct("Portatil Asus");
                await this.context.SaveChangesAsync();
            }
        }
        private void AddProduct(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(100),
                IsAvailabe = true,
                Stock = this.random.Next(100)
            });
        }
    }
}
