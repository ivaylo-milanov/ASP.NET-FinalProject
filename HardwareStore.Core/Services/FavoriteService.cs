namespace HardwareStore.Core.Services
{
    using HardwareStore.Common;
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.Infrastructure.Exceptions;
    using HardwareStore.Core.ViewModels.Favorite;
    using HardwareStore.Infrastructure.Common;
    using HardwareStore.Infrastructure.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class FavoriteService : IFavoriteService
    {
        private readonly IRepository repository;

        public FavoriteService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddToDatabaseFavoriteAsync(string productId, string userId)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await GetFavoritesCustomer(userId);

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = customer.Favorites.FirstOrDefault(p => p.ProductId == guidProductId);

            if (cartItem == null)
            {
                Favorite favorite = new Favorite
                {
                    ProductId = guidProductId
                };

                customer.Favorites.Add(favorite);
                await this.repository.SaveChangesAsync();
            }
        }

        public async Task<ICollection<string>> AddToSessionFavoriteAsync(string productId, ICollection<string> favorites)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            if (!favorites.Contains(productId))
            {
                favorites.Add(productId);
            }

            return favorites;
        }

        public async Task RemoveFromDatabaseFavoriteAsync(string productId, string userId)
        {
            var customer = await GetFavoritesCustomer(userId);

            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = customer.Favorites.FirstOrDefault(p => p.ProductId == guidProductId);

            if (cartItem != null)
            {
                this.repository.Remove(cartItem);
                await this.repository.SaveChangesAsync();
            }
        }

        public async Task<ICollection<string>> RemoveFromSessionFavoriteAsync(string productId, ICollection<string> favorites)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }
            
            if (favorites.Contains(productId))
            {
                favorites.Remove(productId);
            }

            return favorites;
        }

        public async Task<ICollection<FavoriteExportModel>> GetDatabaseFavoriteAsync(string userId)
        {
            var customer = await GetFavoritesCustomer(userId);
            ICollection<FavoriteExportModel> favoriteItems = new List<FavoriteExportModel>();

            var favoritesModels = customer
                .Favorites
                .Select(f => new FavoriteExportModel
                {
                    Id = f.ProductId,
                    Name = f.Product.Name,
                    Price = f.Product.Price
                })
                .ToList();

            return favoritesModels;
        }

        public async Task<ICollection<FavoriteExportModel>> GetSessionFavoriteAsync(ICollection<string> favorites)
        {
            ICollection<FavoriteExportModel> favoriteItems = new List<FavoriteExportModel>();

            foreach (var favoriteId in favorites)
            {
                if (!Guid.TryParse(favoriteId, out Guid guidProductId))
                {
                    throw new InvalidGuidFormatException();
                }

                var product = await this.repository.FindAsync<Product>(favoriteId);

                if (product == null)
                {
                    throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
                }

                var favoriteItem = new FavoriteExportModel
                {
                    Id = guidProductId,
                    Name = product.Name,
                    Price = product.Price
                };

                favoriteItems.Add(favoriteItem);
            }

            return favoriteItems;
        }

        private async Task<Customer> GetFavoritesCustomer(string userId)
        {
            if (!Guid.TryParse(userId, out Guid guidUserId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await this.repository
                .All<Customer>()
                .Include(c => c.Favorites)
                .ThenInclude(c => c.Product)
                .FirstOrDefaultAsync(c => c.Id == guidUserId);

            if (customer == null)
            {
                throw new ArgumentNullException(ExceptionMessages.UserNotFound);
            }

            return customer;
        }
    }
}