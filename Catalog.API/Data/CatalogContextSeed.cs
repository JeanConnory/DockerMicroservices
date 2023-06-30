using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if(existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Iphone 11",
                    Description = "Smartphone da marca Apple modelo Iphone versão 11",
                    Image = "product-1.png",
                    Price = 950m,
                    Category = "Smartphone"
                },
                new Product()
                {
                    Id = "702d2149e773f2a3990b47f6",
                    Name = "Samsung S22",
                    Description = "Smartphone da marca Samsung modelo Galaxy versão S22",
                    Image = "product-2.png",
                    Price = 900m,
                    Category = "Smartphone"
                }
            };
        }
    }
}
