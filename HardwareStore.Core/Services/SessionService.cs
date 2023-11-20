namespace HardwareStore.Core.Services
{
    using HardwareStore.Common;
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.Infrastructure.Exceptions;
    using HardwareStore.Core.ViewModels.ShoppingCart;
    using HardwareStore.Infrastructure.Common;
    using HardwareStore.Infrastructure.Models;
    using System.Threading.Tasks;

    public class SessionService : ISessionService
    {
        private readonly IRepository repository;

        public SessionService(IRepository repository)
        {
            this.repository = repository;
        }
        private async Task AddToFavoritesAsync(Guid userId, ICollection<string> favorites)
        { 
            ICollection<Favorite> dbFavorites = new List<Favorite>();
            foreach (var productId in favorites)
            {
                if (!Guid.TryParse(productId, out Guid guidProductId))
                {
                    throw new InvalidGuidFormatException();
                }

                if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
                {
                    throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
                }

                var existingFavorite = await this.repository
                    .FirstOrDefaultAsync<Favorite>(f => f.ProductId == guidProductId && f.CustomerId == userId);

                if (existingFavorite == null)
                {
                    var favoriteProduct = new Favorite
                    {
                        ProductId = guidProductId,
                        CustomerId = userId
                    };

                    dbFavorites.Add(favoriteProduct);
                }
            }

            this.repository.AddRange(dbFavorites);
        }

        private async Task AddToShoppingCartAsync(Guid userId, ICollection<ShoppingCartExportModel> cart)
        {
            ICollection<ShoppingCartItem> shoppings = new List<ShoppingCartItem>();
            foreach (var item in cart)
            {
                if (!Guid.TryParse(item.ProductId, out Guid guidProductId))
                {
                    throw new InvalidGuidFormatException();
                }

                if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
                {
                    throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
                }

                var existingCartItem = await this.repository
                    .FirstOrDefaultAsync<ShoppingCartItem>(f => f.ProductId == guidProductId && f.CustomerId == userId);

                if (existingCartItem == null)
                {
                    var dbCartItem = new ShoppingCartItem
                    {
                        ProductId = guidProductId,
                        Quantity = item.Quantity,
                        CustomerId = userId
                    };

                    shoppings.Add(dbCartItem);
                }
                else
                {
                    existingCartItem.Quantity += item.Quantity;
                }
            }

            this.repository.AddRange(shoppings);
        }

        public async Task AddToDatabase(string userId, ICollection<string> favorites, ICollection<ShoppingCartExportModel> cart)
        {
            if (!Guid.TryParse(userId, out Guid guidUserId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Customer>(c => c.Id == guidUserId))
            {
                throw new ArgumentNullException(ExceptionMessages.UserNotFound);
            }

            if (favorites != null && favorites.Count > 0)
            {
                await this.AddToFavoritesAsync(guidUserId, favorites);
            }

            if (cart != null && cart.Count > 0)
            {
                await this.AddToShoppingCartAsync(guidUserId, cart);
            }

            await this.repository.SaveChangesAsync();
        } 
    }
}