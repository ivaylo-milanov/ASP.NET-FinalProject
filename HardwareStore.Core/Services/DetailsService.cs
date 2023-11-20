namespace HardwareStore.Core.Services
{
    using HardwareStore.Common;
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.Infrastructure.Exceptions;
    using HardwareStore.Core.ViewModels.Details;
    using HardwareStore.Core.ViewModels.Product;
    using HardwareStore.Infrastructure.Common;
    using HardwareStore.Infrastructure.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class DetailsService : IDetailsService
    {
        private readonly IRepository repository;

        public DetailsService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ProductDetailsModel> GetProductDetails(string productId)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var product = await this.repository
                .All<Product>()
                .Include(p => p.Manufacturer)
                .Include(p => p.Characteristics)
                .ThenInclude(p => p.CharacteristicName)
                .Where(p => p.Id == guidProductId)
                .FirstOrDefaultAsync();

            if (product == null)
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var model = new ProductDetailsModel
            {
                Id = productId,
                Price = product.Price,
                Name = product.Name,
                AddDate = product.AddDate,
                Manufacturer = product.Manufacturer?.Name,
                ReferenceNumber = product.ReferenceNumber,
                Description = product.Description,
                Warranty = product.Warranty,
                Attributes = product.Characteristics
                        .Select(pa => new ProductAttributeExportModel
                        {
                            Name = pa.CharacteristicName.Name,
                            Value = pa.Value
                        })
                        .ToList()
            };

            return model;
        }

        public async Task<bool> IsProductInDbFavorites(string customerId, string productId)
        {
            if (!Guid.TryParse(customerId, out Guid guidCustomerId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await this.repository.FindAsync<Customer>(customerId);

            if (customer == null)
            {
                throw new ArgumentNullException(ExceptionMessages.UserNotFound);
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            return await this.repository.AnyAsync<Favorite>(f => f.CustomerId == guidCustomerId && f.ProductId == guidProductId);
        }

        public async Task<bool> IsProductInSessionFavorites(ICollection<string> sessionFavorites, string productId)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            return sessionFavorites != null && sessionFavorites.Contains(productId);
        }
    }
}
