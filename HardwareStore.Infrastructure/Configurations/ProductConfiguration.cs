namespace HardwareStore.Infrastructure.Configurations
{
    using HardwareStore.Infrastructure.DTOs;
    using HardwareStore.Infrastructure.Models;
    using HardwareStore.Infrastructure.Seed;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var products = GetProducts();

            foreach (var product in products)
            {
                builder.HasData(new
                {
                    product.Name,
                    product.ReferenceNumber,
                    AddDate = DateTime.Now,
                    product.CategoryId,
                    product.ManufacturerId,
                    product.Description,
                    product.Quantity,
                    product.Warranty,
                    product.Model,
                    product.Price
                });

                builder.OwnsMany<Characteristic>("Characteristics", c =>
                {
                    c.HasData(product.Characteristics.Select(characteristic => new
                    {
                        ProductId = product.Id,
                        characteristic.CharacteristicNameId,
                        characteristic.Value
                    }));
                });
            }

            builder.HasData(GetProducts());
        }

        public IEnumerable<Product> GetProducts()
        {
            var productFiles = FileReader.GetFilesNames("*-products.json");
            var data = new List<Product>();

            foreach (var file in productFiles)
            {
                var productDtos = FileReader.LoadJson<ProductDto>(file);
                var products = GetCategoryProducts(productDtos);

                data.AddRange(products);
            }

            return data;
        }

        private IEnumerable<Product> GetCategoryProducts(IEnumerable<ProductDto> productDtos)
        {
            var products = productDtos
                .Select(p => new Product
                {
                    Name = p.Name,
                    ReferenceNumber = p.ReferenceNumber,
                    AddDate = DateTime.Now,
                    CategoryId = p.CategoryId,
                    ManufacturerId = p.ManufacturerId,
                    Description = p.Description,
                    Quantity = p.Quantity,
                    Warranty = p.Warranty,
                    Model = p.Model,
                    Price = p.Price,
                    Characteristics = p.Characteristics
                        .Select(chr => new Characteristic
                        {
                            CharacteristicNameId = chr.CharacteristicNameId,
                            Value = chr.Value
                        })
                        .ToList()
                });

            return products;
        }
    }
}