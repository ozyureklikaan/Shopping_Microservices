using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone X",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Samsung S10",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                    ImageFile = "product-2.png",
                    Price = 840.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Huawei Plus",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                    ImageFile = "product-3.png",
                    Price = 950.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Name = "Xiaomi Mi 9",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                    ImageFile = "product-4.png",
                    Price = 470.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Name = "HTC U11+ Plus",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                    ImageFile = "product-5.png",
                    Price = 300.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "LG G7 ThinQ",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                    ImageFile = "product-6.png",
                    Price = 240.00M,
                    Category = "Home Kitchen"
                },
            };
        }
    }
}
