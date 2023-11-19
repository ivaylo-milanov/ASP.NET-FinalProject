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
                    Name = product.Name,
                    ReferenceNumber = product.ReferenceNumber,
                    AddDate = DateTime.Now,
                    CategoryId = product.CategoryId,
                    ManufacturerId = product.ManufacturerId,
                    Description = product.Description,
                    Quantity = product.Quantity,
                    Warranty = product.Warranty,
                    Model = product.Model,
                    Price = product.Price
                });

                foreach (var characteristic in product.Characteristics)
                {
                    builder.OwnsMany<Characteristic>("Characteristics", c =>
                    {
                        c.HasData(product.Characteristics.Select(characteristic => new
                        {
                            ProductId = product.Id,
                            CharacteristicNameId = characteristic.CharacteristicNameId,
                            Value = characteristic.Value
                        }));
                    });
                }
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
            var products = new List<Product>();

            foreach (var productDto in productDtos)
            {
                var product = new Product
                {
                    Name = productDto.Name,
                    ReferenceNumber = productDto.ReferenceNumber,
                    AddDate = DateTime.Now,
                    CategoryId = productDto.CategoryId,
                    ManufacturerId = productDto.ManufacturerId,
                    Description = productDto.Description,
                    Quantity = productDto.Quantity,
                    Warranty = productDto.Warranty,
                    Model = productDto.Model,
                    Price = productDto.Price
                };

                foreach (var characteristicDto in productDto.Characteristics)
                {
                    var characteristic = new Characteristic
                    {
                        CharacteristicNameId = characteristicDto.CharacteristicNameId,
                        Value = characteristicDto.Value
                    };

                    product.Characteristics.Add(characteristic);
                }

                products.Add(product);
            }

            return products;
        }
    }
}