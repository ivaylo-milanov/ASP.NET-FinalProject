namespace HardwareStore.Core.Services
{
    using HardwareStore.Common;
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.Infrastructure.Exceptions;
    using HardwareStore.Core.ViewModels.ShoppingCart;
    using HardwareStore.Infrastructure.Common;
    using HardwareStore.Infrastructure.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository repository;

        public ShoppingCartService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ICollection<ShoppingCartExportModel>> AddToSessionShoppingCartAsync(string productId, int quantity, ICollection<ShoppingCartExportModel> cart)
        {
            if (quantity <= 0) quantity = 1;

            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var product = await this.repository.FindAsync<Product>(guidProductId);

            if (product == null)
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = cart.FirstOrDefault(p => p.ProductId == productId);

            if (cartItem == null)
            {
                if (quantity > product.Quantity)
                {
                    throw new InvalidOperationException(String.Format(ExceptionMessages.NotManyItemsLeftInStock, product.Quantity, product.Name));
                }

                var model = new ShoppingCartExportModel
                {
                    ProductId = productId,
                    Quantity = quantity,
                };

                cart.Add(model);
            }
            else
            {
                if (cartItem.Quantity + quantity > product.Quantity)
                {
                    throw new InvalidOperationException(String.Format(ExceptionMessages.NotManyItemsLeftInStock, product.Quantity, product.Name));
                }

                cartItem.Quantity += quantity;
            }

            return cart;
        }



        public async Task<ICollection<ShoppingCartExportModel>> DecreaseSessionItemQuantityAsync(string productId, ICollection<ShoppingCartExportModel> cart)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = cart.FirstOrDefault(p => p.ProductId == productId);

            if (cartItem == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CartItemNotFound);
            }

            if (cartItem.Quantity > 1)
            {
                cartItem.Quantity--;
            }

            return cart;
        }

        public async Task<ShoppingCartViewModel> GetSessionShoppingCartAsync(ICollection<ShoppingCartExportModel> cart)
        {
            var shoppingItems = new List<ShoppingCartItemViewModel>();

            foreach (var shopping in cart)
            {
                var product = await repository.FindAsync<Product>(shopping.ProductId);

                if (product == null)
                {
                    throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
                }

                ShoppingCartItemViewModel item = new ShoppingCartItemViewModel
                {
                    ProductId = shopping.ProductId,
                    Quantity = shopping.Quantity,
                    Name = product.Name,
                    Price = product.Price,
                    TotalPrice = product.Price * shopping.Quantity,
                    ProductQuantity = product.Quantity
                };

                shoppingItems.Add(item);
            }

            ShoppingCartViewModel model = new ShoppingCartViewModel
            {
                Shoppings = shoppingItems,
                TotalCartPrice = shoppingItems.Sum(x => x.TotalPrice)
            };

            return model;
        }

        public async Task<ICollection<ShoppingCartExportModel>> RemoveFromSessionShoppingCartAsync(string productId, ICollection<ShoppingCartExportModel> cart)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = cart.FirstOrDefault(p => p.ProductId == productId);

            if (cartItem == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CartItemNotFound);
            }

            cart.Remove(cartItem);

            return cart;
        }

        public async Task<ICollection<ShoppingCartExportModel>> IncreaseSessionItemQuantityAsync(string productId, ICollection<ShoppingCartExportModel> cart)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = cart.FirstOrDefault(p => p.ProductId == productId);

            if (cartItem == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CartItemNotFound);
            }

            cartItem.Quantity++;

            return cart;
        }

        public async Task<ICollection<ShoppingCartExportModel>> UpdateSessionItemQuantityAsync(int quantity, string productId, ICollection<ShoppingCartExportModel> cart)
        {
            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = cart.FirstOrDefault(p => p.ProductId == productId);

            if (cartItem == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CartItemNotFound);
            }

            cartItem.Quantity = quantity;

            return cart;
        }

        public async Task AddToDatabaseShoppingCartAsync(string productId, int quantity, string userId)
        {
            if (!Guid.TryParse(userId, out Guid guidUserId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await GetCartCustomer(guidUserId);

            if (quantity <= 0) quantity = 1;

            var product = await this.repository.FindAsync<Product>(productId);

            if (product == null)
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = customer.ShoppingCartItems.FirstOrDefault(p => p.ProductId == guidProductId);

            if (cartItem == null)
            {
                if (quantity > product.Quantity)
                {
                    throw new InvalidOperationException(String.Format(ExceptionMessages.NotManyItemsLeftInStock, product.Quantity, product.Name));
                }

                var model = new ShoppingCartItem
                {
                    ProductId = guidProductId,
                    Quantity = quantity
                };

                customer.ShoppingCartItems.Add(model);
            }
            else
            {
                if (cartItem.Quantity + quantity > product.Quantity)
                {
                    throw new InvalidOperationException(String.Format(ExceptionMessages.NotManyItemsLeftInStock, product.Quantity, product.Name));
                }

                cartItem.Quantity += quantity;
            }

            await this.repository.SaveChangesAsync();
        }

        public async Task RemoveFromDatabaseShoppingCartAsync(string productId, string userId)
        {
            if (!Guid.TryParse(userId, out Guid guidUserId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await GetCartCustomer(guidUserId);

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = customer.ShoppingCartItems
                .FirstOrDefault(i => i.ProductId == guidProductId);

            if (cartItem == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CartItemNotFound);
            }

            this.repository.Remove(cartItem);
            await repository.SaveChangesAsync();
        }

        public async Task<ShoppingCartViewModel> GetDatabaseShoppingCartAsync(string userId)
        {
            if (!Guid.TryParse(userId, out Guid guidUserId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await GetCartCustomer(guidUserId);

            var shoppings = customer.ShoppingCartItems
                .Select(sci => new ShoppingCartItemViewModel
                {
                    ProductId = sci.Product.Id.ToString(),
                    Name = sci.Product.Name,
                    Quantity = sci.Quantity,
                    Price = sci.Product.Price,
                    TotalPrice = sci.Product.Price * sci.Quantity,
                    ProductQuantity = sci.Product.Quantity
                })
                .ToList();

            var model = new ShoppingCartViewModel
            {
                Shoppings = shoppings,
                TotalCartPrice = shoppings.Sum(sci => sci.TotalPrice)
            };

            return model;
        }

        public async Task DecreaseDatabaseItemQuantityAsync(string productId, string userId)
        {
            if (!Guid.TryParse(userId, out Guid guidUserId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await GetCartCustomer(guidUserId);

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = customer.ShoppingCartItems
                .FirstOrDefault(i => i.ProductId == guidProductId);

            if (cartItem == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CartItemNotFound);
            }

            if (cartItem.Quantity > 1)
            {
                cartItem.Quantity--;
                await this.repository.SaveChangesAsync();
            }
        }

        public async Task IncreaseDatabaseItemQuantityAsync(string productId, string userId)
        {
            if (!Guid.TryParse(userId, out Guid guidUserId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await GetCartCustomer(guidUserId);

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = customer.ShoppingCartItems
                .FirstOrDefault(i => i.ProductId == guidProductId);

            if (cartItem == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CartItemNotFound);
            }

            cartItem.Quantity++;

            await this.repository.SaveChangesAsync();
        }

        public async Task UpdateDatabaseItemQuantityAsync(int quantity, string productId, string userId)
        {
            if (!Guid.TryParse(userId, out Guid guidUserId))
            {
                throw new InvalidGuidFormatException();
            }

            if (!Guid.TryParse(productId, out Guid guidProductId))
            {
                throw new InvalidGuidFormatException();
            }

            var customer = await GetCartCustomer(guidUserId);

            if (!await this.repository.AnyAsync<Product>(p => p.Id == guidProductId))
            {
                throw new ArgumentNullException(ExceptionMessages.ProductNotFound);
            }

            var cartItem = customer.ShoppingCartItems.FirstOrDefault(i => i.ProductId == guidProductId);

            if (cartItem == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CartItemNotFound);
            }

            cartItem.Quantity = quantity;
            await this.repository.SaveChangesAsync();
        }

        private async Task<Customer> GetCartCustomer(Guid userId)
        {
            var customer = await this.repository
                .All<Customer>()
                .Include(c => c.ShoppingCartItems)
                .ThenInclude(c => c.Product)
                .FirstOrDefaultAsync(c => c.Id == userId);

            if (customer == null)
            {
                throw new ArgumentNullException(ExceptionMessages.UserNotFound);
            }

            return customer;
        }
    }
}