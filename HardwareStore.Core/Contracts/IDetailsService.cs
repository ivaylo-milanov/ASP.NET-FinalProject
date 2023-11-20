namespace HardwareStore.Core.Contracts
{
    using HardwareStore.Core.ViewModels.Details;

    public interface IDetailsService
    {
        Task<ProductDetailsModel> GetProductDetails(string productId);

        Task<bool> IsProductInDbFavorites(string customerId, string productId);

        Task<bool> IsProductInSessionFavorites(ICollection<string> sessionFavorites, string productId);
    }
}
