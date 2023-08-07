﻿namespace HardwareStore.Tests.Mocking
{
    using HardwareStore.Infrastructure.Common;
    using HardwareStore.Infrastructure.Data;
    using HardwareStore.Infrastructure.Models;
    using Microsoft.EntityFrameworkCore;

    public static class TestRepository
    {
        public static async Task<IRepository> GetRepository()
        {
            var options = new DbContextOptionsBuilder<HardwareStoreDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new HardwareStoreDbContext(options);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            var repository = new Repository(context);

            await SeedDatabase(context);

            return repository;
        }

        private static async Task SeedDatabase(HardwareStoreDbContext context)
        {
            var manufacturers = Enumerable.Range(1, 3)
                .Select(i => new Manufacturer { Id = i, Name = $"Manufacturer{i}" }).ToList();

            var characteristicNames = Enumerable.Range(1, 4)
                .Select(i => new CharacteristicName { Id = i, Name = $"CharacteristicName{i}" }).ToList();

            var categories = Enumerable.Range(1, 5)
                .Select(i => new Category { Id = i, Name = $"Category{i}" }).ToList();

            var products = Enumerable.Range(1, 12)
                .Select(i => new Product
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = 10 * i,
                    Quantity = 100 * i,
                    AddDate = DateTime.Now,
                    Warranty = 1,
                    ManufacturerId = manufacturers[i % manufacturers.Count].Id,
                    ReferenceNumber = $"Ref00{i}",
                    CategoryId = categories[i % categories.Count].Id,
                    Model = $"Model{i}",
                    Characteristics = Enumerable.Range(1, 3)
                        .Select(j => new Characteristic
                        {
                            Id = (i - 1) * 3 + j,
                            CharacteristicNameId = characteristicNames[(j - 1) % characteristicNames.Count].Id,
                            Value = $"Value{(i - 1) * 3 + j}"
                        }).ToList()
                }).ToList();

            products.Add(new Product
            {
                Id = 13,
                Name = "Product13",
                Price = 130,
                Quantity = 100 * 13,
                AddDate = DateTime.Now,
                Warranty = 1,
                ManufacturerId = null,
                ReferenceNumber = "Ref0013",
                CategoryId = 4,
                Model = "Model13",
                Characteristics = new[]
                {
                    new Characteristic
                    {
                        Id = 37,
                        CharacteristicNameId = 2,
                        Value = "Value37"
                    },
                    new Characteristic
                    {
                        Id = 38,
                        CharacteristicNameId = 4,
                        Value = "1"
                    }
                }
            });

            products.Add(new Product
            {
                Id = 14,
                Name = "Product14",
                Price = 140,
                Quantity = 100 * 14,
                AddDate = DateTime.Now,
                Warranty = 1,
                ManufacturerId = 2,
                ReferenceNumber = "Ref0014",
                Model = "Model14",
                CategoryId = 2
            });

            products.Add(new Product
            {
                Id = 15,
                Name = "Product15",
                Price = 150,
                Quantity = 100 * 15,
                AddDate = new DateTime(2022, 11, 22),
                Warranty = 1,
                ManufacturerId = 2,
                ReferenceNumber = "Ref0015",
                CategoryId = 5,
                Model = "Model15",
                Characteristics = new[]
                {
                    new Characteristic
                    {
                        Id = 39,
                        CharacteristicNameId = 2,
                        Value = "Value39"
                    },
                    new Characteristic
                    {
                        Id = 40,
                        CharacteristicNameId = 4,
                        Value = "Value40, Value41"
                    }
                }
            });

            var user = new Customer
            {
                Id = "TestCustomer",
                UserName = "Customer1",
                Email = "customer@mail.com",
                FirstName = "FirstName1",
                LastName = "LastNam1",
                Phone = "Phone1",
                Area = "Area1",
                City = "City1",
                Address = "Address1",
                Favorites = new List<Favorite>()
                {
                    new Favorite
                    {
                        CustomerId = "TestCustomer",
                        ProductId = 13
                    }, 
                    new Favorite
                    {
                        CustomerId = "TestCustomer",
                        ProductId = 14
                    }
                }
            };

            context.Manufacturers.AddRange(manufacturers);
            context.CharacteristicsNames.AddRange(characteristicNames);
            context.Categories.AddRange(categories);
            context.Products.AddRange(products);
            context.Users.Add(user);

            await context.SaveChangesAsync();
        }
    }
}
