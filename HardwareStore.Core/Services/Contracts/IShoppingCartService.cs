namespace HardwareStore.Core.Services.Contracts
{
    using HardwareStore.Core.ViewModels.ShoppingCart;

    public interface IShoppingCartService
    {
        Task AddToDatabaseShoppingCartAsync(string productId, int quantity, string userId);

        Task<ICollection<ShoppingCartExportModel>> AddToSessionShoppingCartAsync(string productId, int quantity, ICollection<ShoppingCartExportModel> cart);

        Task RemoveFromDatabaseShoppingCartAsync(string productId, string userId);

        Task<ICollection<ShoppingCartExportModel>> RemoveFromSessionShoppingCartAsync(string productId, ICollection<ShoppingCartExportModel> cart);

        Task<ShoppingCartViewModel> GetDatabaseShoppingCartAsync(string userId);

        Task<ShoppingCartViewModel> GetSessionShoppingCartAsync(ICollection<ShoppingCartExportModel> cart);

        Task DecreaseDatabaseItemQuantityAsync(string productId, string userId);

        Task<ICollection<ShoppingCartExportModel>> DecreaseSessionItemQuantityAsync(string productId, ICollection<ShoppingCartExportModel> cart);

        Task IncreaseDatabaseItemQuantityAsync(string productId, string userId);

        Task<ICollection<ShoppingCartExportModel>> IncreaseSessionItemQuantityAsync(string productId, ICollection<ShoppingCartExportModel> cart);

        Task UpdateDatabaseItemQuantityAsync(int quantity, string productId, string userId);

        Task<ICollection<ShoppingCartExportModel>> UpdateSessionItemQuantityAsync(int quantity, string productId, ICollection<ShoppingCartExportModel> cart);
    }
}
