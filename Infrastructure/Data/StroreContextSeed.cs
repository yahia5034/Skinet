using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Infrastructure.Data
{
    public class StroreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.Products.Any())
            {
                var ProductData = await File.ReadAllTextAsync("../Infrastructure/Data/Seed_Data/products.json");

                var products = JsonSerializer.Deserialize<List<Product>>(ProductData);

                if (products == null) return;

                context.AddRange(products);

                await context.SaveChangesAsync();

            }
        }

   
    }
}
